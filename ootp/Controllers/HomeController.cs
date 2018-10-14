using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ootp.Models;

namespace ootp.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;
            ViewBag.Books = books;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult Take(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Take(Order order)
        {
            order.Date = DateTime.Now;
            
            db.Purchases.Add(order);
            
            db.SaveChanges();
            return "Order Success";
        }
        public ActionResult Allorders()
        {
            IEnumerable<Order> orders = db.Purchases;
            ViewBag.Orders = orders;
            return View();
        }
    }
}