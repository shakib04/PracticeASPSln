using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCAppPractice.Controllers
{
    public class HomeController : Controller
    {
        //// GET: Home
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string MyMethod()
        {
            return "Hello World from BD";
        }
    }
}