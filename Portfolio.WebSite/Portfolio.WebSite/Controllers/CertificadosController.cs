using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Portfolio.WebSite.Controllers
{
    public class CertificadosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
