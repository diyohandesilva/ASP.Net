using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dafcon.Models;


namespace dafcon.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Models.Movie() {Name = "Rush Hour"};
            //return View(movie);
            //return Content("Hello Diyi");
            //return HttpNotFound();
            //return new EmptyResult();
            var customers = new List<Customer> {
                new Customer {Name = "Diyohan" },
                new Customer { Name = "Melanie"}

            };


            var RandomMovieModel = new ViewModels.RandomMovieView
            {

                Movie = movie,
                Customer = customers
            };



            return View(RandomMovieModel);

        }
        //
        public ActionResult Edit(int id)
        {
            return Content("This is the Id " + id);
        }

        public ActionResult Index (int? pageindex, String sortBy) {
            if (!pageindex.HasValue)
                pageindex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("Pageindex={0}&sortBy={1}",pageindex,sortBy));

        }
        //Atttribute route
        [Route("movies/released/{year}/{month:regex(\\d{2})}")]
        public ActionResult ReleaseDate(int year, byte month) {

            return Content(year + "/"+ month);
        }
      
    }
}