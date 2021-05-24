using Customers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Customers.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            List<UserModel> users = new List<UserModel>()
            {
                new UserModel("Roger","roger@example.com","(29) 111-12-32"),
                new UserModel("Igor","Igor@example.com","(29) 222-12-32"),
                new UserModel("Masha","Masha@example.com","(29) 333-12-32"),
                new UserModel("Zhenya","Zhenya@example.com","(29) 444-12-32")
            };
            return View(users);
        }
    }
}