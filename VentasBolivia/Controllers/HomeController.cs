using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VentasBolivia.Models;

namespace VentasBolivia.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            var acct = new Account()
            {
                Email = "saulex.v2@hotmail.com",
                Username = "saulex",
                Password = "saulex.v2",
                Name = "Saulo",
                Lastname = "Valdivia",
                Phone = "69549199",
                Ci = "6472568",
                Gender = "M",
                Country = "Bolivia",
                City = "Cochabamba"
            };

            var acctRepository = new MongoDbRepository<Account>();

            Console.WriteLine("Inserting Account");
            var insertResult = acctRepository.GetAll();

            return View();
        }

    }
}
