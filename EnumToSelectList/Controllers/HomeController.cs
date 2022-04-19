using EnumToSelectList.Enums;
using EnumToSelectList.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace EnumToSelectList.Controllers
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
            ViewBag.Priorities = Priority.High.ToSelectList();
            return View();
        }

    }
}