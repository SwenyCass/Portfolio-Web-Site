using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.WebSite.Controllers
{
    public class ExperienciasController : Controller
    {
        //[Route("Experiencias/Index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
