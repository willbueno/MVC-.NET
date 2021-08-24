using RepositoryProjeto.Connection;
using System.Web.Mvc;
using System.Data.Entity;
using System.Linq;
using RepositoryProjeto.Entities;

namespace Projeto.NET_MVC.Controllers
{
    public class AluguelController : Controller
    {
        // GET: Aluguel
        public ActionResult Index()
        {
            using (var db = new ConexaoDB())
            {
                var rent = db.Aluguels
                    .Include(alug => alug.Customer).AsNoTracking()
                    .Include(mov => mov.Movie).AsNoTracking()
                    .Select(x => new AluguelView { CustomerName=x.Customer.Nome, MovieName=x.Movie.Nome, MovieId=x.Id_movie })
                    .ToList();

                return View(rent);
            }
        }
    }
}