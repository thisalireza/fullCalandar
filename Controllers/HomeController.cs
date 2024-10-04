using fullCalandar.Models;
using fullCalandar.Services;
using fullCalandar.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace fullCalandar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAdminService _adminService;

        public HomeController(ILogger<HomeController> logger , IAdminService adminService)
        {
            _logger = logger;
            _adminService = adminService;
        }

        public IActionResult Index()
        {
            List<CalendarInfo> calendarInfos = _adminService.GetCalendarInfos();

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
