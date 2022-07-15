using InstaMazz2._0.Permisos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InstaMazz2._0.Models;

namespace InstaMazz2._0.Controllers
{
    [ValidarSesion]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            UsuarioModel usu = new UsuarioModel();
            //usu.email = "lucaspaz89.89@gmail.com";
            //var result = Session["usuario"];
            ViewBag.eamil = "lucaspaz89.89@gmail.com";

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

        public ActionResult CerrarSesion()
        {
            Session["usuario"] = null;
            return RedirectToAction("Login", "Acceso");
        }
        
    }
}