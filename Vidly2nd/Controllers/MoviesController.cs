using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2nd.Models;

namespace Vidly2nd.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random(int id)
        {
            var movie = new Movie() { Name = "No 1 Shakib Khan", Id = 420 };
            movie.Id = id;
            return View(movie);
        }

        public ActionResult Test(int movieId)
        {
            return HttpNotFound();
        }
    }
}