using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace primer_proyecto_web.Controllers
{
    public class HelloWordController : Controller
    {
        // GET: HelloWord
        public ActionResult Index()
        {
            return View();
        }
        // GET: HelloWord/CarritoDeCompras
        public ActionResult CarritoDeCompras(string name)
        {
            ViewData["Nombre"] = name;
            return View();
        }
    }
}