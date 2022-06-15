using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class DatabaseController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public DatabaseController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Connection()
        {
            return View();
        }

        public IActionResult Import()
        {
            return View();
        }

        public IActionResult Extractions()
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