using Microsoft.AspNetCore.Mvc;
using PRELIM_LAB3_BSIT31E1_joshua_Villafuerte.Models;
using System;
using System.Collections.Generic;

namespace PRELIM_LAB3_BSIT31E1_joshua_Villafuerte.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var customerList = new List<Customer>
            {
                // 5 Regular Customers
                new Customer { FirstName = "joshua", MiddleName = "B", LastName = "Carson", BirthDay = new DateTime(2004, 5, 20), CustomerId = 1001 },
                new Customer { FirstName = "jayson", MiddleName = "R", LastName = "Smith", BirthDay = new DateTime(2004, 1, 15), CustomerId = 1002 },
                new Customer { FirstName = "Rydner", MiddleName = "L", LastName = "Brown", BirthDay = new DateTime(2005, 8, 30), CustomerId = 1003 },
                new Customer { FirstName = "Jerome", MiddleName = "T", LastName = "Johnson", BirthDay = new DateTime(2004, 10, 5), CustomerId = 1004 },
                new Customer { FirstName = "Hans", MiddleName = "M", LastName = "Lee", BirthDay = new DateTime(2004, 12, 12), CustomerId = 1005 },

                // 5 VIP Customers
                new VipCustomer { FirstName = "Sean", MiddleName = "C", LastName = "Dylan", BirthDay = new DateTime(2005, 3, 10), CustomerId = 2001 },
                new VipCustomer { FirstName = "Keir", MiddleName = "N", LastName = "Martinez", BirthDay = new DateTime(2004, 4, 18), CustomerId = 2002 },
                new VipCustomer { FirstName = "Pamela", MiddleName = "Q", LastName = "Wright", BirthDay = new DateTime(2004, 7, 25), CustomerId = 2003 },
                new VipCustomer { FirstName = "Banag", MiddleName = "S", LastName = "Nguyen", BirthDay = new DateTime(2005, 9, 2), CustomerId = 2004 },
                new VipCustomer { FirstName = "Kyle", MiddleName = "U", LastName = "Ocampo", BirthDay = new DateTime(2004, 11, 11), CustomerId = 2005 }
            };

            ViewBag.CustomerList = customerList;
            return View();
        }
    }
}
