using Projeto.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.NET_MVC.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}