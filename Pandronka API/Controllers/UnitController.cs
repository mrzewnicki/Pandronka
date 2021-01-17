﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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

        public async Task<IActionResult> UpdateUnit(JednostkaMiary model)
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
                    Message = "Updating interrupted due to preventing danger update method"

                }
                );
            }

            if (Db.Kategoria.Any(x => x.Id == model.Id))
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

        public async Task<IActionResult> AddUnit(JednostkaMiary model)
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
        }
    }
}