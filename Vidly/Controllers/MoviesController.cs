﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies /movies/random
        public ActionResult Random()
        {

            var movie = new Movie() { Name = "Shrek!" };


//          return View(movie);
//          return new ViewResult();
//          return Content("Hello");
//          return HttpNotFound();
//          return new EmptyResult();
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name"});

        }
    }
}