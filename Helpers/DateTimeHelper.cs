using System;

namespace NorthWind.API.Helpers
{
    public static class DateTimeHelper
    {
        public static long DateTimeToUnixTimestamp(DateTime date)
        {
            return ((DateTimeOffset)date).ToUnixTimeMilliseconds() ;
        }

        public static DateTime UnixTimeStampToDateTime(long unixTimeStamp)
        {
            DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeMilliseconds(unixTimeStamp);
           return dateTimeOffset.UtcDateTime;
        }

    }
}