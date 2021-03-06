
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Analytics.Data
{
    public sealed class Time
    {
        public sealed class Dimensions
        {
            
            [DescriptionAttribute("The date of the visit formatted as YYYYMMDD.")]
            public static DataItem date = new DataItem("date");
                                      
            [DescriptionAttribute("The year of the visit. A four-digit year from 2005 to the current year.")]
            public static DataItem year = new DataItem("year");
                                      
            [DescriptionAttribute("The month of the visit. A two digit integer from 01 to 12.")]
            public static DataItem month = new DataItem("month");
                                      
            [DescriptionAttribute("The week of the visit. A two-digit number from 01 to 53. Each week starts on Sunday.")]
            public static DataItem week = new DataItem("week");
                                      
            [DescriptionAttribute("The day of the month. A two-digit number from 01 to 31.")]
            public static DataItem day = new DataItem("day");
                                      
            [DescriptionAttribute("A two-digit hour of the day ranging from 00-23 in the timezone configured for the account. This filter is also corrected for daylight savings time, adhering to all local rules for daylight savings time. If your timezone follows daylight savings time, there will be an apparent bump in the number of visits during the change-over hour (e.g. between 1:00 and 2:00) for the day per year when that hour repeats. A corresponding hour with zero visits will occur at the opposite changeover. (Google Analytics does not track visitor time more precisely than hours.)")]
            public static DataItem hour = new DataItem("hour");
                                      
            [DescriptionAttribute("Returns the minute in the hour. The possible values are between 00 and 59.")]
            public static DataItem minute = new DataItem("minute");
                                      
            [DescriptionAttribute("Index for each month in the specified date range. Index for the first month in the date range is 0, 1 for the second month, and so on. The index corresponds to month entries.")]
            public static DataItem nthMonth = new DataItem("nthMonth");
                                      
            [DescriptionAttribute("Index for each week in the specified date range. Index for the first week in the date range is 0, 1 for the second week, and so on. The index corresponds to week entries.")]
            public static DataItem nthWeek = new DataItem("nthWeek");
                                      
            [DescriptionAttribute("Index for each day in the specified date range. Index for the first day (i.e., start-date) in the date range is 0, 1 for the second day, and so on.")]
            public static DataItem nthDay = new DataItem("nthDay");
                                      
            [DescriptionAttribute("Index for each minute in the specified date range. Index for the first minute of first day (i.e., start-date) in the date range is 0, 1 for the next minute, and so on.")]
            public static DataItem nthMinute = new DataItem("nthMinute");
                                      
            [DescriptionAttribute("The day of the week. A one-digit number from 0 (Sunday) to 6 (Saturday).")]
            public static DataItem dayOfWeek = new DataItem("dayOfWeek");
                                      
            [DescriptionAttribute("The name of the day of the week (in English).")]
            public static DataItem dayOfWeekName = new DataItem("dayOfWeekName");
                                      
            [DescriptionAttribute("Combined values of ga:date and ga:hour.")]
            public static DataItem dateHour = new DataItem("dateHour");
                                      
            [DescriptionAttribute("Combined values of ga:year and ga:month.")]
            public static DataItem yearMonth = new DataItem("yearMonth");
                                      
            [DescriptionAttribute("Combined values of ga:year and ga:week.")]
            public static DataItem yearWeek = new DataItem("yearWeek");
                                      
            [DescriptionAttribute("The ISO week number, where each week starts with a Monday. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoWeek should only be used with ga:isoYear since ga:year represents gregorian calendar.")]
            public static DataItem isoWeek = new DataItem("isoWeek");
                                      
            [DescriptionAttribute("The ISO year of the visit. Details: http://en.wikipedia.org/wiki/ISO_week_date. ga:isoYear should only be used with ga:isoWeek since ga:week represents gregorian calendar.")]
            public static DataItem isoYear = new DataItem("isoYear");
                                      
            [DescriptionAttribute("Combined values of ga:isoYear and ga:isoWeek.")]
            public static DataItem isoYearIsoWeek = new DataItem("isoYearIsoWeek");
                                      
        }

        public sealed class Metrics
        {
            

            public sealed class Calculated
            {
                
            }
        }
    }
}
