using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Customers
        public ViewResult Index()
        {
            //include to instant the objects into the html webpage
            //get the values from MembershipType Tables
            var customer = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customer);
        }

        public ViewResult Details(int ID)
        {
            //exerise 2 work
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.ID == ID);
            return View(customer);
        }

    }
}