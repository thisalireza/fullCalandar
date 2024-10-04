using fullCalandar.Core.Convertor;
using fullCalandar.Models;
using fullCalandar.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace fullCalandar.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService =  adminService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddEvent( )
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEvent(CalendarInfo calendarInfo)
        {
            if (!ModelState.IsValid)
            {
                return View(calendarInfo);

            }

            DateConvertor dateConvertor = new DateConvertor();
            string startDate=dateConvertor.shamsiToMiladi(calendarInfo.StartDate).ToString("yyyy-MM-dd");
            string endDate=dateConvertor.shamsiToMiladi(calendarInfo.EndDate).ToString("yyyy-MM-dd");

            calendarInfo.StartDate = startDate;
            calendarInfo.EndDate = endDate;

            _adminService.AddCalendarInfo(calendarInfo);
            ModelState.Clear();
            return View();
        }

    }
}
