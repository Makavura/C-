using System;

namespace mod_tut_lab_one
{
    class Program
    {

        // practice creating and instantiating classes. You'll be creating an application that could be
        //  used at a car dealership to organize and store information about an inventory of cars. 
        // First, you will declare a Car() Class, then instantiate objects of the Car() Class with 
        // varying properties.

        // The following code you will enter is going to create a new class called Car() that we will use later as a blueprint to create objects of this class. Within this class, you are also going add properties to define the characteristics of a car such as: the color of the car (color), the year it was built (year), and how many miles the car has been driven (mileage).
        // Declaring the Car() Class
        // This class has 3 properties: Color, Year, and Mileage
        public class Car
        {
            // Defining properties
            public string Color { get; set; }
            public int Year { get; set; }
            public int Mileage { get; set; }
        }


        // This code assigned("set") the properties of "White", 2010, and 11000 miles to the Car1 object.

        // Next, you want to ensure that you have properly constructed your class and instantiated it, so lets access("get") these values and print them to the console.Keep your cursor placed inside of the Main() and enter the following code:


        static void Main(string[] args)
        {

            // After we have declared our Car() Class with its properties, we are going to create an instance of this class. Enter the following code inside of Main(). This code will instantiate an object called "Car1" - which will be a white car built in 2010 with 11,000 miles on it.
            // Instantiating an object of Car() Class by using Type Inference called Car1
            var Car1 = new Car();

            // Using dot notation to call members on Car1
            Car1.Color = "White";
            Car1.Year = 2010;
            Car1.Mileage = 11000;

            // Output to the console window
            Console.WriteLine($"This car is painted {Car1.Color}, was built in {Car1.Year}, and has {Car1.Mileage} miles on it.");
            // You should see the following message: "This car is painted White, was built in 2010, and has 11000 miles on it."

        }
    }
}
