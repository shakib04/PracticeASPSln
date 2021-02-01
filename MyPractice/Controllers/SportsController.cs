using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyPractice.Controllers
{
    public class SportsController : Controller
    {
        // GET: Sportss
        public ActionResult Homepage()
        {

            return View();
        }
    }
}