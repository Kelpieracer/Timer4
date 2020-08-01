using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using RCB.TypeScript.Infrastructure;

namespace RCB.TypeScript.Controllers
{
    public class MainController : ControllerBase
    {
        public IActionResult Index()
        {
            using (var context = new Models.TimerDbContext())
            {
                var customer = new Models.Customer
                {
                    Name = "asiakas",
                };
                context.Customers.Add(customer);
                context.SaveChanges();

                var customers = context.Customers.Take(10).ToList();
                foreach (var e in customers)
                    Console.WriteLine($"Customer: {e}");
            }


            var webSessionContext = new WebSessionContext
            {
                Ssr = new SsrSessionData
                {
                    Cookie = string.Join(", ", Request.Cookies.Select(x => $"{x.Key}={x.Value};"))
                },
                Isomorphic = new IsomorphicSessionData
                {
                    ServiceUser = ServiceUser
                }
            };

            return View(webSessionContext);
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }
}