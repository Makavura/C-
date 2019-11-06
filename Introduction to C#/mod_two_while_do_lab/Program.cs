using System;

namespace mod_two_while_do_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            // WHILE LOOP
            int n = 1;
            while (n < 6)
            {
                Console.WriteLine($"Current value of n is {n}");
                n++;
            }

            // DO LOOP
            int x = 0;
            do{
                Console.WriteLine(x);
                x++;
            } while ( x<5);
        }
    }
}
