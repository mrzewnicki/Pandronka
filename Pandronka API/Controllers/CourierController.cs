using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pandronka.Models;

namespace Pandronka.Controllers
{
    public class CourierController : Controller
    {
        private ApplicationDbContext Db;

        public CourierController(ApplicationDbContext db)
        {
            Db = db;
        }

        public async Task<IActionResult> SelectCity()
        {
            //todo
            throw new NotImplementedException();
        }

        /// <summary>
        /// Function available for admin
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="courierId"></param>
        /// <returns></returns>
        public async Task<IActionResult> AssignOrder(int orderId, string courierId)
        {
            if (orderId == null || courierId == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "One of posted id is null"
                    }
                );
            }

            //ToDO: Sprawdzić czy istnieje taki user po id - OBECNIE BRAK POLA W BAZIE PO KTÓRYM MOŻNA SPRAWDZIĆ REALIZATORA
            if (await Db.Zamowienia.AnyAsync(x => x.Id == orderId) && await Db.Users.AnyAsync(x=>x.Id == courierId))
            {
                //todo: add reference between models
                //var addingResult = Db.

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

        /// <summary>
        /// Function available for courier
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="courierId"></param>
        /// <returns></returns>
        public async Task<IActionResult> PickUpOrder(int orderId, int courierId)
        {
            //todo - OBECNIE BRAK POLA W BAZIE DO STWORZENIA REFERENCJI
            throw new NotImplementedException();
        }

        public async Task<IActionResult> ShowOrders()
        {
            //todo - OBECNIE BRAK POLA W BAZIE DO STWORZENIA REFERENCJI
            throw new NotImplementedException();
        }

        public async Task<IActionResult> ShowSummary()
        {
            //todo summary - BRAK POMYSŁU CO TU MOŻE BYĆ, JESZCZE.. 
            throw new NotImplementedException();
        }
    }
}