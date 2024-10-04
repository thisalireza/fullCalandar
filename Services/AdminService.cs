using fullCalandar.Context;
using fullCalandar.Models;
using fullCalandar.Services.Interfaces;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace fullCalandar.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminService _adminService;

       private readonly MyContext _context;
        public AdminService(MyContext context)
        {
            _context = context;
        }

        /// <summary>
        /// گرفتن لیست
        /// CalendarInfo
        /// </summary>
        /// <returns></returns>
        public List<CalendarInfo> GetCalendarInfos()
        {
            return _context.CalandarInfos.ToList();
        }

        /// <summary>
        /// گرفتن
        /// calendarInfo
        /// از ورودی و ذخیره تغییرات در دیتابیس
        /// </summary>
        /// <param name="calendarInfo"></param>
        public void AddCalendarInfo(CalendarInfo calendarInfo)
        {
            _context.CalandarInfos.Add(calendarInfo);
            _context.SaveChanges();
        }

    }
}
