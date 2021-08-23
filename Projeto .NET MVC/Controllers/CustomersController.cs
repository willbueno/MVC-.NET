using RepositoryProjeto.Entities;
using RepositoryProjeto.Repositories;
using System.Linq;
using System.Web.Mvc;

namespace Projeto.NET_MVC.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            using (var reposityWrapper = new RepositoryWrapper())
            {
                var movies = reposityWrapper.CustomerRepository.GetAll();

                return View(movies);
            }
        }

        public ActionResult Details(int id)
        {
            using (var reposityWrapper = new RepositoryWrapper())
            {
                var movie = reposityWrapper.CustomerRepository.FindQuery().Where(cust => cust.Id == id).FirstOrDefault();

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
        public ActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                using (var reposityWrapper = new RepositoryWrapper())
                {
                    var _customer = reposityWrapper.CustomerRepository.Add(customer);
                }
            }
            // TODO redirect to index view
            return View();
        }
    }
}