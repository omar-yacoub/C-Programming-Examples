/*
 This program will ask the user to enter a few numbers separated by a hyphen.
 If the user simply presses Enter, without supplying an input, The program will exit immediately; 
 otherwise, it will check to see if there are duplicates.
 If so, the program will display "Duplicate" on the console. 
*/


using System;
using System.Collections.Generic;

namespace FindDuplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a few numbers separated by a hyphen:");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;
            
            var numberString = input.Split('-');
            var numbers = new List<int>();

            foreach (var number in numberString)
                numbers.Add(Convert.ToInt32(number));
            
            if (isDuplicate(numbers))
                Console.WriteLine("Duplicate");

        }
        public static Boolean isDuplicate(List<int>numbers)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = i+1; j < numbers.Count; j++)
                    if (numbers[i] == numbers[j])
                        return true;
            }
           
            return false;
        }
    }
}
            
                    
                    
                
                
            


