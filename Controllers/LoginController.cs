using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_final.Models;
using Projeto_final.Repositorios;

namespace Projeto_final.Controllers
{
    public class LoginController : Controller
    {
        CadastroRepositorio cadastroRepositorio = new CadastroRepositorio();

        private const string SESSION_EMAIL = "_EMAIL";
        private const string SESSION_CLIENTE = "_CLIENTE";
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Logar(IFormCollection form)
        {
            var cadastre = form["email"];
            var senha = form["senha"];

            var lista = cadastroRepositorio.Listar();

            foreach (var item in lista)
            {
                if (lista != null && item.Senha.Equals(senha) && item.Email.Equals(cadastre))
                {
                    HttpContext.Session.SetString(SESSION_EMAIL, cadastre);
                    HttpContext.Session.SetString(SESSION_CLIENTE, item.Nome);
                    System.Console.WriteLine("LOGOOOOOOOOOOOOOOOOOOOOOOOOOU!");
                }
            }
            return RedirectToAction("Index", "Comentario");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(SESSION_EMAIL);
            HttpContext.Session.Remove(SESSION_CLIENTE);
            HttpContext.Session.Clear();

            return RedirectToAction("Index", "Home");
        }
    }
}