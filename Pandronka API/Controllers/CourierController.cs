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
            if (await Db.Miasta.AnyAsync())
            {
                var cities = await Db.Miasta.ToListAsync();
                return Ok(new Response()
                {
                    Status = "Success",
                    Data = new []{cities}
                });
            }

            return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                {
                    Status = "Error",
                    Message = "No cities in system"
                }
            );
        }

        /// <summary>
        /// Function available for admin
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="courierId"></param>
        /// <returns></returns>
        public async Task<IActionResult> AssignOrder(int orderId, string courierId)
        {
            if (await Db.Zamowienia.AnyAsync(x => x.Id == orderId) && await Db.Users.AnyAsync(x=>x.Id == courierId))
            {
                Zamowienie order = await Db.Zamowienia.FindAsync(orderId);
                order.WykonujacyId = courierId;
                Db.Zamowienia.Update(order);
                Db.SaveChanges();

                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Reference have been added successfully"
                });
            }
            
            return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                {
                    Status = "Error",
                    Message = "One of posted have not been found"
                }
            );
            
        }

        /// <summary>
        /// Function available for courier
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="courierId"></param>
        /// <returns></returns>
        public async Task<IActionResult> PickUpOrder(int orderId, string courierId)
        {
            if (await Db.Zamowienia.AnyAsync(x => x.Id == orderId) && await Db.Users.AnyAsync(x => x.Id == courierId))
            {
                Zamowienie order = await Db.Zamowienia.FindAsync(orderId);
                order.WykonujacyId = courierId;
                Db.Zamowienia.Update(order);
                Db.SaveChanges();

                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Reference have been added successfully"
                });
            }

            return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                {
                    Status = "Error",
                    Message = "One of posted have not been found"
                }
            );
        }

        public async Task<IActionResult> ShowOrders(string courierId)
        {
            if (!await Db.Users.AnyAsync(x => x.Id == courierId))
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "Courier does not exists"
                    }
                );
            }

            if (!await Db.Zamowienia.AnyAsync(x => x.WykonujacyId == courierId))
            {
                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Courier does not performed any order",
                    Data = null
                });
            }

            var getResult = await Db.Zamowienia.Where(x => x.WykonujacyId == courierId)
                .Include(x => x.Koszyk)
                .Include(x => x.Platnosc)
                .Include(x => x.Status)
                .ToListAsync();

            return Ok(new Response()
            {
                Status = "Success",
                Message = "Courier performed " + getResult.Count,
                Data = new[] { getResult }
            });
        }

        [HttpGet]
        public async Task<IActionResult> ShowSummary(string courierId)
        {
            if (!await Db.Users.AnyAsync(x=>x.Id == courierId))
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Response()
                    {
                        Status = "Error",
                        Message = "Courier does not exists"
                    }
                );
            }

            if (!await Db.Zamowienia.AnyAsync(x => x.WykonujacyId == courierId))
            {
                return Ok(new Response()
                {
                    Status = "Success",
                    Message = "Courier does not performed any order",
                    Data = null
                });
            }

            var getResult = await Db.Zamowienia.Where(x => x.WykonujacyId == courierId)
                                                            .Include(x=>x.Koszyk)
                                                            .Include(x=>x.Platnosc)
                                                            .Include(x=>x.Status)
                                                            .ToListAsync();

            /*
            double totalEarn = 0.00;

            //Count total cash earned for finished orders
            foreach (Zamowienie zamowienie in getResult.Where(x=>x.StatusId == 4))
            {
                double cartPrice = 0.00;

                var getCartProducts = await Db.Kosz_Prod.Where(x => x.Koszyk == zamowienie.Koszyk).Include(x=>x.Produkt).ToListAsync();

                foreach (var cartProduct in getCartProducts)
                {
                    cartPrice += cartProduct.Produkt.Cena;
                }

                totalEarn += cartPrice;
            }
            */
            

            return Ok(new Response()
            {
                Status = "Success",
                Message = "Courier performed "+getResult.Count,
                Data = new []{ getResult }
            });

        }
    }
}