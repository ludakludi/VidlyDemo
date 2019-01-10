﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyDemo.Models;
using VidlyDemo.ViewModels;

namespace VidlyDemo.Controllers
{
    public class MoviesController : Controller
    {

        private readonly List<Movie> _movies = new List<Movie>
            {
               new Movie { Name = "Shrek", ID = 1},
               new Movie { Name = "Wall-E", ID = 2},
            };

        public ActionResult Index()
        {
            return View(_movies);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
               new Customer { Name = "Customer 1"},
               new Customer { Name = "Customer 2"},
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        [Route("Movies/Released/{year}/{month}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year + "/" + month);
        }


    }
}