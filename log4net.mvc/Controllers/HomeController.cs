using log4net.mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace log4net.mvc.Controllers
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
            //_logger.LogWarning("This is a warning from Index()");
            //_logger.LogInformation("This is an information from Index()");
            //_logger.LogDebug("This is a debug from Index()");
            return View();
        }

        public IActionResult Privacy()
        {
            throw new Exception("An exception was thrown at Privace()");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var data = HttpContext.Request.Headers["LogData"];
            _logger.LogError(data);

            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
