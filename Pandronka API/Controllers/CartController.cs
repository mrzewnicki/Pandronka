using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Pandronka.Models;

namespace Pandronka.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext Db;
        public CartController(ApplicationDbContext db)
        {
            Db = db;
        }
        public async Task<IActionResult> UpdateProduct(Produkt model)
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

            if (model.Id == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "Model ID field is null. Preventing danger update interrupt"

                    }
                );
            }

            if (Db.Produkt.Any(x => x.Id == model.Id))
            {
                Db.Produkt.Update(model);
                Db.SaveChanges();
                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Record have been updated"
                });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "The no exist product associated with posted id"

                    }
                );
            }
        }

        public async Task<IActionResult> AddProduct(int productId, int cartId)
        {
            if (productId == null || cartId == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "One of posted id is null"
                    }
                );
            }

            if (Db.Koszyk.Any(x => x.Id == cartId) && Db.Produkt.Any(x=>x.Id == productId))
            {
                Db.Kosz_Prod.Add(new Kosz_Prod()
                {
                    Koszyk = Db.Koszyk.Find(cartId),
                    Produkt = Db.Produkt.Find(productId)
                });

                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Reference have been added successfully"
                });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "One of posted have not been found"
                    }
                );
            }
        }

        public async Task<IActionResult> ShowProduct(int id)
        {
            if (id == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "One of posted id is null"
                    }
                );
            }

            var prod = await Db.Produkt.Where(x => x.Id == id)
                .Include(x => x.JednostkaMiary)
                .Include(y => y.Kategoria)
                .Include(x => x.Producent)
                .FirstAsync();

            if (prod is null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "Product have not been found"
                    }
                );
            }

            return Ok(new Response()
            {
                Status = "Success",
                Data = new []{prod}
            });
        }

        public async Task<IActionResult> CreateOrder()
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}