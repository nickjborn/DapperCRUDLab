using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _10_21_ProductsDapper.Models;

namespace _10_21_ProductsDapper.Controllers
{
    public class HomeController : Controller
    {
        private readonly DapperConfiguration _config;
        public HomeController(DapperConfiguration config)
        {
            _config = config;
        }
        public IActionResult Index()
        {
            var connectionString = _config.Database.ConnectionString;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
