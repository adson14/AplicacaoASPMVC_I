using AplicacaoASP.Models;
using System.Web.Mvc;

namespace AplicacaoASP.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            pessoa.PessoaId = 1;
            pessoa.Nome = "Adson Souza";
            pessoa.Email = "ty.msn@hotmail.com";
            pessoa.Tipo = "Física";

            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Email"] = pessoa.Email;
            ViewData["Tipo"] = pessoa.Tipo;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult List(int PessoaId, string Nome, string Email, string Tipo)
        {
            ViewData["PessoaId"] = PessoaId;
            ViewData["Nome"] = Nome;
            ViewData["Email"] = Email;
            ViewData["Tipo"] = Tipo;

            return View();
        }
    }
}