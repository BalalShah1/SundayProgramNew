using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* 
            * How many years in the 20th century
            * How many leap years during that time period
            * How many Sundays occur during that time
            */


            //number of Sundays falling on the first day of the month between 1901 and 2000
            int sundayCount = CountFirstDaySundays(1901, 2000);
            Console.WriteLine(sundayCount);
        }

        //number of Sundays falling on the first day of the month 
        public static int CountFirstDaySundays(int startYear, int endYear)
        {
            int sundayCount = 0;
            int currentDayOfWeek = 2; // January 1, 1901 is a Tuesday, so start with Tuesday (0 = Sunday, 1 = Monday, 2 = Tuesday)

            // Loop through each year
            for (int year = startYear; year <= endYear; year++)
            {
                // Loop through each month
                for (int month = 1; month <= 12; month++)
                {
                    // Check if the first day of the month is a Sunday 
                    if (currentDayOfWeek == 0)
                    {
                        sundayCount++;
                    }

                    // Calculate the number of days in the current month
                    int daysInMonth = CalculateDaysInMonth(month, year);

                    // Move to the first day of the next month
                    currentDayOfWeek = (currentDayOfWeek + daysInMonth) % 7;
                }
            }

            return sundayCount;
        }

        // Calculates the number of days in a given month of a specified year
        public static int CalculateDaysInMonth(int month, int year)
        {
            // Calculate the number of days in the current month
            if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                if (month == 2)
                {
                    // Check if the year is a leap year
                    if (IsLeapYear(year))
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                }
                else
                {
                    return 31;
                }
            }
        }

        // Checks if the year is a leap year
        public static bool IsLeapYear(int year)
        {
            // Check if a year is a leap year
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
