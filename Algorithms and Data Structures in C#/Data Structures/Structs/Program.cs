using System;

namespace Structs
{


    public struct  car
    {
        public string Make;
        public string Model;
        public string Color;

        public void Accelerate(){
            Console.WriteLine("Vrooooooom!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

car myCar = new car();

myCar.Make = "Chevy";
myCar.Model = "Silverado";
myCar.Color = "Gray";

Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} that is {myCar.Color} in color");
            Console.WriteLine();
            myCar.Accelerate();
        }
    }
}
