using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Humanizer;
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
            //todo - policzyć pełną kwote zamówienia
            throw new NotImplementedException();
        }

        public async Task<IActionResult> ShowSummaryCart(int cartId)
        {
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

        [HttpGet]
        public async Task<IActionResult> SelectPayment()
        {
            if (await Db.Platnosci.AnyAsync())
            {
                var lst = await Db.Platnosci.ToListAsync();

                return Ok(new Response()
                {
                    Status = "Success",
                    Data = new []{lst}
                });
            }
            return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                {
                    Status = "Error",
                    Message = "Does not contain any paymentoptions"
                }
            );
        }

        public async Task<IActionResult> ShowStatus(int orderId)
        {
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