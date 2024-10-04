using Microsoft.Win32;

namespace fullCalandar.Core.Convertor
{
    public class DateConvertor
    {
        public DateTime shamsiToMiladi(string date)
        {
            string[] dateSplter = date.Split("/");

            return new DateTime(int.Parse(dateSpliter[0])),
                int.Parse(dateSpliter[1]),
                int.Parse(dateSpliter[2]),
                new PersianCalendar()
                );

        }
    }
}
