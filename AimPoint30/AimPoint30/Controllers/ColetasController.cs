using Microsoft.AspNetCore.Mvc;

namespace AimPoint30.Controllers
{
    public class ColetasController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ColetasController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {


            return View();
        }
    }
}
