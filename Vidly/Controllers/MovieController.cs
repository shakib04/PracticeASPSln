using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Index
        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Coco" };
            return View(movie);
            //return Content("Hello World"); //return a plain string
            //return HttpNotFound(); //404 error
            //return new EmptyResult(); //empty
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" }); // Redirect to 1st= page Name, 2nd=folder name, 3rd = query String 

        }

        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);
        }

        public ActionResult Test(int id)
        {
            return Content("Hello I am Testing " + id);
        }

        //movies list
        public ActionResult AllMovies(int? pageIndex, string sortBy) //? for null intialize
        {
            if (!pageIndex.HasValue) //default
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sortBy)) //default
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        //release order //mvc4action(shortcut)
        // url:../movie/ByReleaseDate/year/month
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year+"/"+month);
        }
    }
}