using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;


namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ViewResult Index()
        {
            var customer = GetCustomers();
            return View(customer);
        }

        public ViewResult Details(int ID)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.ID == ID);
            return View(customer);
        }

        private IEnumerable<Customers> GetCustomers()
        {
            var number = 1;
            number = number + 1;
            return new List<Customers>
            {
                new Customers {ID = 1, Name = "John Smith" },
                new Customers {ID = 2, Name = "Mary Williams" }
            };
        }
    }
}