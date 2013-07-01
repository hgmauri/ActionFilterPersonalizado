using Sistema.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema.Web.Controllers
{
    [BaseController]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            throw new Exception("Erro");
            //return View();
        }
    }
}
