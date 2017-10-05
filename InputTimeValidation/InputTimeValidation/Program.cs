/*
 * The Program will ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
 * A valid time should be between 00:00 and 23:59. If the time is valid, the program will display "Ok"; 
 * otherwise, display "Invalid Time". If the user doesn't provide any values, it will consider it as invalid time. 
 */

using System;

namespace InputTimeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time value in the 24-hour time format (e.g. 19:00)");
            var input = Console.ReadLine();

            var result = isValidTime(input) ? "Ok" : "Invalid Time";

            Console.WriteLine(result);

            
        }

        public static bool isValidTime(string str)
        {

            if (String.IsNullOrWhiteSpace(str))
                return false;

            var time = str.Split(':');
            if (time.Length != 2)
                return false;
            
            try
            {
                var hour = Convert.ToInt32(time[0]);
                var minute = Convert.ToInt32(time[1]);
                return ((hour >= 0 && hour <= 23) && (minute >= 0 && minute <= 59));
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
            

