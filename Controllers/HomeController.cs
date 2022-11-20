using High_precisionMechanics.Data;
using High_precisionMechanics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace High_precisionMechanics.Controllers
{
    public class HomeController : Controller
    {
        public readonly appDbContext _appDb;

        public HomeController(appDbContext appDb)
        {
            _appDb = appDb;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var obj = _appDb.Users.FirstOrDefault();

            if (obj == null) return NotFound();

            return View(obj);
        }

        [HttpPost]
        public IActionResult Index(User obj)
        {
            if (ModelState.IsValid)
            {
                _appDb.Users.Update(obj);
                _appDb.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult CreateOrder()
        { 
            return View(); 
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateOrder(Order obj)
        {
            if (ModelState.IsValid)
            {
                obj.date = DateTime.Now;
                
                Random rand = new Random();
                obj.Price = "";
                obj.Status = "Отказано";

                if (rand.Next(1, 4) != 1)
                {
                    obj.Price = rand.Next(10000, 50000).ToString() + " руб.";
                    obj.CustomerServiceManager = true;
                    obj.HeaOfProduction = true;
                    obj.HeadOfQualityDepartment = true;
                    obj.HeadOfLogistics = true;
                    obj.HeadOfTheEconomicDepartment = true;

                    switch (rand.Next(1, 5))
                    {
                        case 1:
                            obj.Status = "Ждет отправки";
                            break;
                        case 2:
                            obj.Status = "Осуществляется доставка";
                            break;
                        case 3:
                            obj.Status = "Сборка";
                            break;
                        case 4:
                            obj.Status = "Ждет получения";
                            break;
                    }
                }
                
                _appDb.Orders.Add(obj);
                _appDb.SaveChanges();

                InsertDataIntoAgreement(obj.Id);

                return RedirectToAction("ShowOrders");
            }

            return View(obj);
        }


        public IActionResult ShowOrders ()
        {
            IEnumerable<Order> orders = _appDb.Orders;

            return View(orders);
        }

        public void InsertDataIntoAgreement (int id)
        {
            var obj = new Agreement();
            var order = _appDb.Orders.Find(id);

            obj.OrderId = order.Id;
            obj.HeaOfProduction = order.HeaOfProduction;
            obj.CustomerServiceManager = order.CustomerServiceManager;
            obj.HeadOfTheEconomicDepartment = order.HeadOfTheEconomicDepartment;
            obj.HeadOfLogistics = order.HeadOfLogistics;
            obj.HeadOfQualityDepartment = order.HeadOfQualityDepartment;

            _appDb.Agreements.Add(obj);
            _appDb.SaveChanges();
            
        }
    }
}
