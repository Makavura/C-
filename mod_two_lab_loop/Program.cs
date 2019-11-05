using System;

namespace mod_two_lab_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop that displays values of counter

            for(int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"Counter is at: {counter}");
            }

            //  nested for loop
            //  find prime numbers less than 100
            int outer;
            int inner;

            for ( outer = 2; outer < 100; outer++)
            {
                for (inner = 2; inner <= (outer/inner); inner++ )
                
                    if((outer % inner) == 0) break;
                if (inner > (outer/inner))
                    Console.WriteLine("{0} is prime", outer);
                
            }
        }
    }
}
