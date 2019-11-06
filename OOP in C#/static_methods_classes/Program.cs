using System;

namespace static_methods_classes
{
     class Program
    {

// in the case of a need to create a class purely to encapsulate useful functionality rather 
// than to represemt an instance of anything
// eg methods that convert imperial weights and measure to metric weights and measures and vice versa

// in scenarios like this, a static class has the best use case
// a static class is a class that cannot be instantiated
// use static keyword
// any members within must also use static keyword


        public static class Conversion
        {
            public static double PoundsToKilos(double pounds)
            {
                double kilos = pounds * 0.4536;
                return kilos;
            }
            public static double KilosToPounds(double kilos)
            {
                double pounds = kilos * 2.205;
                return pounds;
            }
        }
        static void Main(string[] args)
        {
            double weightInKilos = 80;
            double weightInPounds = Conversion.KilosToPounds(weightInKilos);
            Console.WriteLine(weightInPounds);

        }
    
        
    }
}
