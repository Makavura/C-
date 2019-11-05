using System;

namespace mod_two_lab
{
    class Program
    {
        static void Main(string[] args)
        {

            //  an if decision block to check for an even number

            //  Request user input with ReadLine()
            Console.WriteLine("Please enter an integer value and press Enter.");

            // Assign the entered value to a variable and convert input to integer
            int input = Int32.Parse(Console.ReadLine());

            // Check to see if number is even by using % | modulus

            if (input % 2 == 0)
            {
                Console.WriteLine("The entered number was an even number.");
            }
            else
            {
                Console.WriteLine("The entered number was not an even number.");
            }
        }
    }
}
