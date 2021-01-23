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
    public class UnitController : Controller
    {
        private ApplicationDbContext Db;
        public UnitController(ApplicationDbContext db)
        {
            Db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Update(JednostkaMiary model)
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

            if (await Db.Kategoria.AnyAsync(x => x.Id == model.Id))
            {
                Db.JednostkaMiary.Update(model);
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
                    Message = "The no exist manufacturer associated with posted id"

                }
                );
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add(JednostkaMiary model)
        {
            return await Task.Run(() =>
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

                var added = Db.JednostkaMiary.Add(model);
                Db.SaveChanges();

                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Record have been added",
                    Data = new[] { added }
                });
            });
        }
    }
}