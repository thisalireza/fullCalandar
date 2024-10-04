using fullCalandar.Models;

namespace fullCalandar.Services.Interfaces
{
    public class IAdminService
    {

        List<CalendarInfo> GetCalendarInfos();
        void AddCalendarInfo(CalendarInfo calendarInfo);
    }
}
