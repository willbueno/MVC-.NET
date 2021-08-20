﻿using Projeto.NET_MVC.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

namespace Projeto.NET_MVC.Controllers
{
    public class AluguelController : Controller
    {
        // GET: Aluguel
        public ActionResult Index()
        {
            using (var db = new ConexaoDB())
            {
                //var rent = db.Aluguels.ToList();
                var rent = db.Aluguels
                    .Include(alug => alug.Customer)
                    .Include(mov => mov.Movie)
                    .ToList();

                return View(rent);
            }
        }
    }
}