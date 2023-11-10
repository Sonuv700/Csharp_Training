using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace project1_codebasetest.Controllers
{
    public class codeController : Controller
    {
        public class CodeController : Controller
        {
            private NorthwindEntities db = new NorthwindEntities();

            // First action method: Get customers residing in Germany
            public ActionResult CustomersInGermany()
            {
                var germanyCustomers = db.Customers.Where(c => c.Country == "Germany").ToList();
                return View(germanyCustomers);
            }

            // Second action method: Get customer details with orderId == 10248
            public ActionResult CustomerDetailsWithOrderId()
            {
                var customerDetails = db.Orders
                    .Where(o => o.OrderID == 10248)
                    .Select(o => o.Customer)
                    .FirstOrDefault();

                return View(customerDetails);
            }
        }
    }
}