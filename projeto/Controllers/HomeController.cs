using Microsoft.AspNetCore.Mvc;
using projeto.Models;
using System.Diagnostics;

namespace projeto.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult NovaDemanda()
        {
            return View();
        }
        public IActionResult DemandasAbertas()
        {
            return View();
        }
        public IActionResult ListarTodas()
        {
            return View();
        }
        public IActionResult Relatorios()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
    }
}


