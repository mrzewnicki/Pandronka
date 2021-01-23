using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Pandronka.Models;
using Pandronka_API.Models.DTOS;

namespace Pandronka.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext Db;

        public ProductController(ApplicationDbContext db)
        {
            Db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Add(Produkt model)
        {
            if (!ModelState.IsValid)
            {
                string errCallBack = "";

                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        errCallBack += error.ErrorMessage + ";";
                    }
                }

                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = String.Format("Incorrect model data: {0}", errCallBack)
                    }
                );
            }

            if (await Db.Produkt.AnyAsync(x => x == model))
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = String.Format("Similar product already exists")
                    }
                );
            }

            var added = Db.Produkt.Add(model);
            Db.SaveChanges();

            return Ok(new Response()
            {
                Status = "Success",
                Message = "Product have been added",
                Data = new []{added}
            });
        }

        [HttpPost]
        public async Task<IActionResult> Update(Produkt model)
        {
            if (!ModelState.IsValid)
            {
                string errCallBack = "";

                foreach (var modelState in ViewData.ModelState.Values)
                {
                    foreach (ModelError error in modelState.Errors)
                    {
                        errCallBack += error.ErrorMessage + ";";
                    }
                }

                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = String.Format("Incorrect model data: {0}", errCallBack)
                    }
                );
            }

            if (await Db.Produkt.AnyAsync(x => x.Id == model.Id))
            {
                Db.Produkt.Update(model);
                Db.SaveChanges();

                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Product have been updated"
                });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "Product with posted id have not been found."
                    }
                );
            }

        }

        [HttpGet]
        public async Task<IActionResult> Show(int id)
        {
            if (await Db.Produkt.AnyAsync(x => x.Id == id))
            {
                var found = await Db.Produkt.Where(x => x.Id == id)
                    .Include(x => x.Producent)
                    .Include(x => x.JednostkaMiary)
                    .Include(x => x.Kategoria)
                    .FirstAsync();

                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Product have been found",
                    Data = new[]{found}
                });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "Product with posted id have not been found"
                    }
                );
            }
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            if (Db.Produkt.Any())
            {
                List<ShowProductsDTO> products = await Db.Produkt.Include(x => x.Kategoria)
                    .Select(x => new ShowProductsDTO(x))
                    .ToListAsync();

                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Found "+products.Count,
                    Data = new []{products}
                });
            }
            else
            {
                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Found 0 products",
                });
            }
        }
    }
}