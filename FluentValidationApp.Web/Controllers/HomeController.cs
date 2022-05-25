using FluentValidationApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FluentValidationApp.Web.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private readonly ILoggerFactory _loggerFactory;

        public HomeController(ILoggerFactory loggerFactory)
        {
            _loggerFactory = loggerFactory;
        }

        public IActionResult Index()
        {

            var _logger = _loggerFactory.CreateLogger("Home Page");
            _logger.LogTrace("Index Page Log Example");
            _logger.LogDebug("Index Page Log Example");
            _logger.LogInformation("Index Page Log Example");
            _logger.LogWarning("Index Page Log Example");
            _logger.LogError("Index Page Log Example");
            _logger.LogCritical("Index Page Log Example");

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