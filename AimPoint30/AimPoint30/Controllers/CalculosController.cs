using Microsoft.AspNetCore.Mvc;

namespace AimPoint30.Controllers
{
    public class CalculosController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CalculosController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }
    }
}
