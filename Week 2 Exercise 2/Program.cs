using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2_Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter an integer
            Console.Write("Enter an integer: ");

            // Takes the users input and converts it to an integer
            int number = int.Parse(Console.ReadLine());

            // This takes the absolute value just incase the user enters a negative number
            number = Math.Abs(number);

            // This makes sum a variable
            int sum = 0;

            // This loops until the number the user enter is equal to 0 
            while (number > 0)
            {
                // Add the digits to the sum
                sum += number % 10;

                // This removes the last digit from the users number
                number /= 10;
            }

            // This prints the text and results from the code
            Console.WriteLine($"The sum of the digits is: {sum}");
            Console.ReadLine();
        }
    }
}
