using System;

namespace mod_three_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Sum(20, 40);
            Console.WriteLine($"The sum of 20 and 40 is {result}");

            int result3 = Sum(10, 50, 80);
            Console.WriteLine($"The sum of 10, 50 and 80 is {result3}");

            double dblResult = Sum(21.7, 30.87);
            Console.WriteLine($"The sum of 21.7 and 30.87 is {dblResult}");
        }


        // Sum() method that takes two integer arguments and sums them
        // The method returns no value which is why we use void
        // We also need to use static in the method signature because Main is static
        // and you cannot call a non-static method from a static method

        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;

        }
        // overloading
        // compiler will know which method to call based on argument data types
        static int Sum(int first, int second, int third)
        {
            int sum = first + second + third;
            return sum;
        }
        // overloading again
        static double Sum(double first, double second)
        {
            double result = first + second;
            return result;
        }


    }
}
