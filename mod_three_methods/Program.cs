using System;

namespace mod_three_methods
{
    class Program
    {
        static void Main(string[] args)
        {
Sum(20, 40);
        }

        
// Sum() method that takes two integer arguments and sums them
// The method returns no value which is why we use void
// We also need to use static in the method signature because Main is static
// and you cannot call a non-static method from a static method

            static void Sum(int first, int second)
            {
                int sum = first + second;
                Console.WriteLine($"Th sum of {first} and {second} is {sum}");
            }
    }
}
