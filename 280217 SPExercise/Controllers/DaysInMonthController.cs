using System;

namespace Controllers
{
    public class DaysInMonthController
    {

        public int GetNumberOfDaysInMonth(int month, int year)
        {
            if (year >= 0 && year < int.MaxValue)
            {
                if (month >= 1 && month <= 12)
                {
                    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
                    {
                        return 31;
                    }
                    if (month == 2)
                    {
                        if (IsLeapYear(year) == true)
                        {
                            return 29;
                        }
                        return 28;
                    }
                    if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        return 30;
                    }
                }
                throw new Exception("Invalid month");
            }
            throw new Exception("Invalid year");
        }


        public bool IsLeapYear(int year)
        {
            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        return true;
                    }
                    return false;
                }
                return true;
            }
            return false;
        }



    }
}
