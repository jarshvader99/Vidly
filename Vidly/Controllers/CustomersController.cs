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
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer { id = 1, Name = "cust 1" },
                new Customer { id = 2, Name = "cust 2" }
            };

            var viewResult = new CustomersViewModel()
            {
                Customers = customers
            };
            return View(viewResult);
        }

        // GET: Customer Details
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { id = 1, Name = "cust 1" },
                new Customer { id = 2, Name = "cust 2" }
            };
            var customerDetails = new Customer { };
            foreach(var customer in customers)
            {
                if(id == customer.id)
                {
                    customerDetails = customer;
                    break;
                }
                
            }
            return View(customerDetails);
        }
    }
}