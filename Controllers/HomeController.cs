using Microsoft.AspNetCore.Mvc;
using Online_Shop.Models;
using Online_Shop.Services;

namespace Online_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ClothesService _clothesService;
        public HomeController(ILogger<HomeController> logger, ClothesService clothesService)
        {
            _logger = logger;
            _clothesService = clothesService;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*public async Task <IActionResult> Item1()
        {
            Shirt shirt = new Shirt
            {
                ShirtId = Guid.NewGuid(),
                Name = "Zoro",
                Path = "~/Images/zoropic.png",
                Color = "red"
            };
            await _clothesService.AddShirt(shirt);
            return View();
        }*/
        public IActionResult Item1()
        {
            return View();
        }
        public IActionResult Item2()
        {
            return View();
        }
        public IActionResult Item3()
        {
            return View();
        }
        public IActionResult Men()
        {
            return View();
        }
        public IActionResult Women()
        {
            return View();
        }
        public IActionResult Kids()
        {
            return View();
        }
        public IActionResult AddProduct()
        {
            return View();
        }
    }
}