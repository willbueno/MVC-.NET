using Projeto.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.NET_MVC.ViewModels
{
    public class MovieViewModel
    {
        public List<RandomMovieViewModel> RandomMovies { get; set; }

        public MovieViewModel()
        {
            RandomMovies = new List<RandomMovieViewModel>
            {
                new RandomMovieViewModel(),
                new RandomMovieViewModel()
                {
                    Movie = { Id = 2, Name = "Wall-e" }
                }
            };
        }
    }
}