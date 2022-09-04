using AimPoint30.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using AimPoint30.Entities.ViewModels;
using AimPoint30.Domain.Logics;
namespace AimPoint30.Controllers
{
    public class DashboardController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public DashboardController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var business = new DashboardBusiness();
            DashboardViewModel home = business.ObterDashboardValores();

            ViewBag.Message = home;

            return View();
        }
       
    }
}
