using Projeto.NET_MVC.Models;
using System.Linq;
using System.Web.Mvc;

namespace Projeto.NET_MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            using (var db = new ConexaoDB())
            {
                var movies = db.Movies.ToList();

                return View(movies);
            }
        }

        public ActionResult Details(int id)
        {
            using (var db = new ConexaoDB())
            {
                var movie = db.Movies.Where(mov => mov.Id == id).FirstOrDefault();

                if (movie == null)
                    return HttpNotFound();
                return View(movie);
            }
        }
    }
}