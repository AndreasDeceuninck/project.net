using Microsoft.AspNetCore.Mvc;
using broodjeszaak.Models;

namespace broodjeszaak.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult order()
        {
            return View(new Order());
        }

        [HttpPost]
        public ViewResult order(Order orders, Repository repository)
        {
            if (ModelState.IsValid)
            {
                repository.AddOrder(orders);
                var order = Repository.Orders.Last();
                return View("show", order);
            }
            else
            {
                return View(new Order());
            }
        }

        public ViewResult ListOrders()
        {
            var orders = Repository.Orders;
            return View(orders);
        }
    }
}