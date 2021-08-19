using Projeto.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.NET_MVC.ViewModels
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; }

        public CustomerViewModel()
        {
            Customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith" },
                new Customer { Id = 2, Name = "Mary Williams" }
            };
        }
    }
}