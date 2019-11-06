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

        // Static Members in Non-static Classes

        //  This is useful when some behaviors and characteristics relate to the instance 
        // (instance members), while some behaviors and characteristics relate to the type itself 
        // (static members). Methods, fields, properties, and events can all be declared static. 
        // Static properties are often used to return data that is common to all instances, or to keep 
        // track of how many instances of a class have been created. Static methods are often used to 
        // provide utilities that relate to the type in some way, such as comparison functions.

        // To declare a static member you use the static keyword before the return type of the member, 
        // as shown by the following example:


        public class DrinksMachine
        {
            public int Age { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public static int CountDrinksMachines()
            {
                // Add method logic here.
            }
        }
        // Regardless of how many instances of your class exist, there is only ever one instance of a 
        // static member.You do not need to instantiate the class in order to use static members.
        // You access static members through the class name rather than the instance name, as shown by
        //  the following example:

        // Access Static Members
        int drinksMachineCount = DrinksMachine.CountDrinksMachines();
        static void Main(string[] args)
        {
            double weightInKilos = 80;
            double weightInPounds = Conversion.KilosToPounds(weightInKilos);
            Console.WriteLine(weightInPounds);

        }


    }
}
