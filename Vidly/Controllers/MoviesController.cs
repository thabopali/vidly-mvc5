using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {


        public ViewResult Index()
        {
           var movies = GetMovies();
 
            return View(movies);    
       }

        private object GetMovies()
        {
            throw new NotImplementedException();
        }

      

    }
}