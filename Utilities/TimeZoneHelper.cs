using System;

namespace ClientSchedule.Utilities
{
    public static class TimeZoneHelper
    {
        private static readonly TimeZoneInfo EST =
            TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

        public static DateTime ToUTC(DateTime local)
        {
            return TimeZoneInfo.ConvertTimeToUtc(local);
        }

        public static DateTime FromUTC(DateTime utc)
        {
            return TimeZoneInfo.ConvertTimeFromUtc(utc, TimeZoneInfo.Local);
        }

        public static bool IsWithinBusinessHours(DateTime localStart, DateTime localEnd)
        {
            // Convert local → EST
            var estStart = TimeZoneInfo.ConvertTime(localStart, EST);
            var estEnd = TimeZoneInfo.ConvertTime(localEnd, EST);

            // Monday–Friday
            if (estStart.DayOfWeek == DayOfWeek.Saturday ||
                estStart.DayOfWeek == DayOfWeek.Sunday)
                return false;

            // 9 AM – 5 PM EST
            var open = estStart.Date.AddHours(9);
            var close = estStart.Date.AddHours(17);

            return estStart >= open && estEnd <= close;
        }
    }
}