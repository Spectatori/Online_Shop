using Microsoft.AspNetCore.Mvc;
using Online_Shop.Models;

namespace Online_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Item()
        {
            PriceModel model = new PriceModel();
            model.price = 50;
            return View(model);
        }
    }
}