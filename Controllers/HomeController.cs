using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MassAssignment.Models;
using MassAssignment.Filters;
using MassAssignment.Utility;

namespace MassAssignment.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [InitializerFilterAction]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update(User user)
        {
            UserRepository.Store(user, HttpContext);
            ViewBag.Result = "Successfully updated the user!";
            return View("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
