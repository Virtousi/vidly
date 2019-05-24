using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ViewResult Index()
        {
            //include to instant the objects into the html webpage
            //get the values from MembershipType Tables
            var movie = _context.Movies.Include(c => c.GenreType).ToList();
            return View(movie);
        }

        public ViewResult Details(int ID)
        {
            //exerise 3 work
            var movie = _context.Movies.Include(c => c.GenreType).SingleOrDefault(c => c.ID == ID);
            return View(movie);
        }
    }
}