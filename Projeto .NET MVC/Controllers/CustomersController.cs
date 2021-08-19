using Projeto.NET_MVC.Models;
using Projeto.NET_MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.NET_MVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var viewModel = new CustomerViewModel();

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var customers = new CustomerViewModel().Customers;
            var customer = customers.Where(l=>l.Id==id).FirstOrDefault();

            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }
    }
}