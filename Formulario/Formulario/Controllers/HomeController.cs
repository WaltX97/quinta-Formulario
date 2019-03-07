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
            // viewbag para  guardar a resposta
            ViewBag.resposta = "";
            return View();
        }


        [HttpPost]
        public ActionResult Index(string nome, int? idade)
        {
            //precisamos de validar os dados introduzidos pelo utilizador
            /// 1ª questão : o "nome" nao é um nome?
            /// 2ª questão : a idade está dentro dos parametros pretendidos [0,120]
            // validar a idade
            string mensagem = "";
            if (idade >= 0 && idade <= 120) { 
            // criar a mensagem da resposta
             mensagem = "Voce chama-se "+nome+" e tem " +idade+" anos.";

            }
            else{
                //mensagem alternativa
                mensagem = "Deve especificar uma idade valida!\n"+
                           " A idade deve ser maior que zero e menor que 120 anos...";
            }
            // criar o contentor que levara a mensagem para a View
            ViewBag.resposta = mensagem;
            // invoca a view
            return View();
        }


      
    }
}