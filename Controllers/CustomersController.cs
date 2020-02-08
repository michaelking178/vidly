using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = GetCustomers().FirstOrDefault(c => c.Id == id);

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Name = "James Bennett", Id = 1 },
                new Customer { Name = "Marianne Bourdeaux", Id = 2 },
                new Customer { Name = "Phil Rawlings", Id = 3 },
                new Customer { Name = "Bonny Taylor", Id = 4 }
            };
        }
    }
}
