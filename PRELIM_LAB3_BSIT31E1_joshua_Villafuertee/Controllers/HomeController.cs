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
                new Customer {
                    FirstName = "Joshua", MiddleName = "B", LastName = "Carson",
                    BirthDay = new DateTime(2004, 5, 20), CustomerId = 1001,
                    Email = "joshua.carson@gmail.com", Address = "Blk 1, Alabang"
                },
                new Customer {
                    FirstName = "Jayson", MiddleName = "R", LastName = "Smith",
                    BirthDay = new DateTime(2004, 1, 15), CustomerId = 1002,
                    Email = "jayson.smith@gmail.com", Address = "123 Park St, Makati"
                },
                new Customer {
                    FirstName = "Rydner", MiddleName = "L", LastName = "Brown",
                    BirthDay = new DateTime(2005, 8, 30), CustomerId = 1003,
                    Email = "rydner.brown@gmail.com", Address = "456 Quezon Ave"
                },
                new Customer {
                    FirstName = "Jerome", MiddleName = "T", LastName = "Johnson",
                    BirthDay = new DateTime(2004, 10, 5), CustomerId = 1004,
                    Email = "jerome.johnson@gmail.com", Address = "789 Manila Blvd"
                },
                new Customer {
                    FirstName = "Hans", MiddleName = "M", LastName = "Lee",
                    BirthDay = new DateTime(2004, 12, 12), CustomerId = 1005,
                    Email = "hans.lee@gmail.com", Address = "101 Ortigas Ext"
                },

                // 5 VIP Customers
                new VipCustomer {
                    FirstName = "Sean", MiddleName = "C", LastName = "Dylan",
                    BirthDay = new DateTime(2005, 3, 10), CustomerId = 2001,
                    Email = "sean.dylan@gmail.com", Address = "Golden Tower, Makati", IsVip = true
                },
                new VipCustomer {
                    FirstName = "Keir", MiddleName = "N", LastName = "Martinez",
                    BirthDay = new DateTime(2004, 4, 18), CustomerId = 2002,
                    Email = "keir.martinez@gmail.com", Address = "VIP Heights, BGC", IsVip = true
                },
                new VipCustomer {
                    FirstName = "Pamela", MiddleName = "Q", LastName = "Wright",
                    BirthDay = new DateTime(2004, 7, 25), CustomerId = 2003,
                    Email = "pamela.wright@gmail.com", Address = "Executive Towers, Taguig", IsVip = true
                },
                new VipCustomer {
                    FirstName = "Banag", MiddleName = "S", LastName = "Nguyen",
                    BirthDay = new DateTime(2005, 9, 2), CustomerId = 2004,
                    Email = "banag.nguyen@gmail.com", Address = "Royal Residences, QC", IsVip = true
                },
                new VipCustomer {
                    FirstName = "Kyle", MiddleName = "U", LastName = "Ocampo",
                    BirthDay = new DateTime(2004, 11, 11), CustomerId = 2005,
                    Email = "kyle.ocampo@gmail.com", Address = "Platinum Suites, Alabang", IsVip = true
                }
            };

            ViewBag.CustomerList = customerList;
            return View();
        }
    }
}
