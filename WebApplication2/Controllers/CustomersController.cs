using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customer = GetCustomers();
            return View(customer);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id=1,Name="John Smith" },
                new Customer {Id=2,Name="Harry Williams" }
            };
        }

        public ActionResult Details(int id)
        {
            var Customer = GetCustomers().SingleOrDefault(c => c.Id == id);
            if (Customer == null)
                return HttpNotFound();

            return View(Customer);
        }

    }
}