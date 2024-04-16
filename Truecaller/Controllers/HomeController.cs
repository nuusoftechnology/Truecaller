using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Truecaller.Models;

namespace Truecaller.Controllers
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
        [HttpGet]
        public IActionResult Login(string? requestId, string? accessToken)//, Truecallermodels? truecallermodels
        {
            //_logger.Log(LogLevel.Information, truecallermodels.phoneNumbers);
            return View();
        }
        [HttpPost, Route("/auth/token")]
        //[HttpPost]
        public IActionResult Login(string? accessToken)//(AccessURLModel accessURL)
        {
            //_logger.Log(LogLevel.Information, truecallermodels.phoneNumbers);
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
