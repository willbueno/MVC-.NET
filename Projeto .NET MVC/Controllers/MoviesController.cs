using Projeto.NET_MVC.Models;
using Projeto.NET_MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Projeto.NET_MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var viewModel = new MovieViewModel();

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            var movies = new MovieViewModel().RandomMovies;
            var movie = movies.Where(l => l.Movie.Id == id).FirstOrDefault();

            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }

        public ActionResult Random()
        {
            var viewModel = new RandomMovieViewModel();

            return View(viewModel);
            //return Content("Hello world!");
            //return Json(movie, JsonRequestBehavior.AllowGet);
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("movies/param")]
        public ActionResult Param(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")] // ASP.NET MVC Attribute Route Constraints
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}