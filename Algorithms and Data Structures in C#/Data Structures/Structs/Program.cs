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

    enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

    class Program
    {
        static void Main(string[] args)
        {
// ENUM

int x = (int)Days.Sun;
int y = (int)Days.Fri;

Console.WriteLine("Sun = {0}", x);
Console.WriteLine("Fri = {0}", y);
Console.WriteLine(Days.Thu);



// STRUCTS
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
