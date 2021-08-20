﻿using Projeto.NET_MVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace Projeto.NET_MVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            using (var db = new ConexaoDB())
            {
                var customers = db.Customers.ToList();

                return View(customers);
            }
        }

        public ActionResult Details(int id)
        {
            using (var db = new ConexaoDB())
            {
                var customer = db.Customers.Where(cust => cust.Id == id).FirstOrDefault();

                if (customer == null)
                    return HttpNotFound();

                return View(customer);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                using (var db = new ConexaoDB())
                {
                    db.Customers.Add(customer);
                    db.SaveChanges();
                }
            }
            return View();
        }
    }
}