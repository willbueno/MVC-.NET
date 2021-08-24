using RepositoryProjeto.Entities;
using RepositoryProjeto.Repositories;
using System.Linq;
using System.Web.Mvc;

namespace Projeto.NET_MVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            using (var reposityWrapper = new RepositoryWrapper())
            {
                var movies = reposityWrapper.MovieRepository.GetAll();

                return View(movies);
            }
        }
        public ActionResult Details(int id)
        {
            using (var reposityWrapper = new RepositoryWrapper())
            {
                var movie = reposityWrapper.MovieRepository.FindQuery().Where(mov => mov.Id == id).FirstOrDefault();

                if (movie == null)
                    return HttpNotFound();
                return View(movie);
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                using (var reposityWrapper = new RepositoryWrapper())
                {
                    var _movie = reposityWrapper.MovieRepository.Add(movie);
                }
            }
            return Redirect("Index");
        }
    }
}