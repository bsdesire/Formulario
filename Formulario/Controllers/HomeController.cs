using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Formulario.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            // Cria o ViewBag e coloca nele um valor vazio
            ViewBag.mensagem = "";
            return View();
        }
        [HttpPost]
        public ActionResult Index(string nome, int? idade)
        {
            // Agora vai-se fazer alguma coisa...

            string msg;

            if(idade >= 0 && idade <= 130)
            {
                // Cria a mensagem a entregar na View
                msg = "Olá sou o(a) " + nome + " e tenho " + idade + " anos";
            }
            else
            {
                msg = "Escolha uma idade entre 0 e 130 anos.";
            }
            

            // 'Envelopa' a mensagem (msg) paa ser enviada para a view
            ViewBag.mensagem = msg;

            return View();
        }
    }
}