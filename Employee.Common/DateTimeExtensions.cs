using System;
using System.Globalization;

namespace Employee.Common
{
    public static class DateTimeExtensions
    {
        private static readonly DateTime _tempTime = new(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

        public static long ToMilliseconds(this DateTime dateTime)
        {
            return (long)dateTime.Subtract(_tempTime).TotalMilliseconds;
        }

        public static string ToPersianDate(this DateTime dateTime)
        {
            var pc = new PersianCalendar();
            var year = pc.GetYear(dateTime);
            var month = pc.GetMonth(dateTime);
            var day = pc.GetDayOfMonth(dateTime);
            return $"{year}/{month.ToString("D2")}/{day.ToString("D2")}";
        }
    }
}