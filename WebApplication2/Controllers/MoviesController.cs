using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movie = GetMovies();
            return View(movie);
        }
       
        public IEnumerable<Movies> GetMovies()
        {
            return new List<Movies>
            {
                new Models.Movies {Id=1,Name="giugbuibhinioo" },
                new Movies {Id=2,Name="kkkkkkkkkkkkkkk" }
                };
        }

    }
}