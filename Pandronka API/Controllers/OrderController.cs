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
    public class OrderController : Controller
    {
        private ApplicationDbContext Db;
        public OrderController(ApplicationDbContext db)
        {
            Db = db;
        }

        public async Task<IActionResult> ShowAmount()
        {
            //todo - do czego to było???
            throw new NotImplementedException();
        }

        public async Task<IActionResult> ShowSummaryCart(int cartId)
        {
            if (cartId == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "One of posted id is null"
                    }
                );
            }

            if (Db.Koszyk.Any(x => x.Id == cartId))
            {
                var cart = await Db.Koszyk.Where(x=>x.Id== cartId).Include(x => x.Uzytkownik).FirstAsync();
                List<Kosz_Prod> products = await Db.Kosz_Prod.Where(x => x.Koszyk == cart).ToListAsync();

                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Status of order have been found",
                    Data = new object[]
                    {
                        cart,products
                    }
                });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "Order have not been found"
                    }
                );
            }
        }

        public async Task<IActionResult> SelectPayment()
        {
            //todo
            throw new NotImplementedException();
        }

        public async Task<IActionResult> ShowStatus(int orderId)
        {
            if (orderId == null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "One of posted id is null"
                    }
                );
            }

            if (Db.Zamowienia.Any(x=>x.Id == orderId))
            {
                var order = await Db.Zamowienia.Where(x => x.Id == orderId).Include(x => x.Status).FirstAsync();

                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Status of order have been found",
                    Data = new []{order.Status.Nazwa}
                });
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "Order have not been found"
                    }
                );
            }
        }
    }
}