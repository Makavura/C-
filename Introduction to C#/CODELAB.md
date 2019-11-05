# MODULE 3 TUTORIAL LAB 1 - CREATING AND USING METHODS

In this lab, you will practice creating and calling methods to perform some simple mathematical functions. You'll start by creating simple methods that accept arguments and return values and then you perform some method overloading practice.

Visual Studio Steps
Open Visual Studio
Select File, New, Project
From the Templates section, select Visual C#
Select Console App (.NET Framework if using VS 2017 or later)
Name your project, such as Mod3_Lab1
Choose a location to store the project
Click the OK button and Visual Studio will create a new C# Console application project for you and opens Program.cs for you in the editor window
Place your cursor immediately after the open curly brace in the Main method, then press enter to create a new line
Place your cursor after the closing curly brace of the static void Main(string[] args) function and press enter. We are doing this because you don't want to place methods/functions inside another function.
The following code you will enter is a new method called Sum() that will be used to add values passed into it. You will add to this method and overload it later in the lab. For now, enter the following code in your editor.
// Sum() method that takes two integer arguments and sums them
// The method returns no value which is why we use void
// We also need to use static in the method signature because Main is static
// and you cannot call a non-static method from a static method
static void Sum(int first, int second)
{
    int sum = first + second;
    Console.WriteLine($"The sum of {first} and {second} is: {sum}");
}
Now we can call this method from within Main to have it calculate the sum of two numbers. Enter the following code within the curly braces of Main():

Sum(20, 40);
Your complete code should look like the following:

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3_Lab1
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
            Console.WriteLine($"The sum of {first} and {second} is: {sum}");
        }
    }
}
Press CTRL + F5 or select Debug, Start Without Debugging to check the output and that the method call works.
The first instance you created calls a method that doesn't return a value. We will now modify that method so that it returns the result back to the calling method. We will need to modify the code in Main as well.
To modify the method, enter the following code.
// Sum() method that takes two integer arguments and sums them
        // The method returns an integer value which is why we use int in the signature
        // We also need to use static in the method signature because Main is static
        // and you cannot call a non-static method from a static method
        static int Sum(int first, int second)
        {
            int sum = first + second;
            return sum;
        }
Finally, we need to modify the code in Main() to take advantage of a method that returns a value. Here, we declare an integer variable to receive the return value. The return value and the variable used to hold it must match in terms of data type. We then print out the result to the console window.
static void Main(string[] args)
        {

            int result = Sum(20, 40);
            Console.WriteLine($"The sum of 20 and 40 is {result}");
        }
Run the application again and check the output. Both outputs should be the same. The only thing we changed, basically, was to have the method return the sum of the two numbers and where the output functionality resided.
Let's now look at overloading our Sum() method. We will create two additional methods. First, create a method that accepts three integers by entering the following code:
// Sum() method that takes three integer arguments and sums them
// and then returns the value
// This method uses the same name as the Sum() method that takes two integers
// but the parameters here indicate the method is expecting three integers as arguments
// The compiler knows which method to call based on the number of arguments passed in
static int Sum(int first, int second, int third)
{
    int sum = first + second + third;
    return sum;
}
Next, enter the following code that will create a Sum() method that accepts two doubles as arguments:
// Sum() method that takes two doubles as arguments
// This method uses the same name as the Sum() method that takes two integers
// but the parameters here indicate the method is expecting two doubles as arguments
// The compiler knows which method to call based on the arguments data types
static double Sum(double first, double second)
{
    double result = first + second;
    return result;
}
Finally, modify the code in Main() that calls the methods so that it looks like this:
static void Main(string[] args)
{

    int result = Sum(20, 40);
    Console.WriteLine($"Calling Sum() with two arguments, result is: {result}");

    int result3 = Sum(10, 50, 80);
    Console.WriteLine($"Calling Sum() with three arguments, result is: {result3}");

    double dblResult = Sum(20.5, 30.6);
    Console.WriteLine($"Calling Sum() that takes doubles result in: {dblResult}");
}
Run the application again and check the output. You should see the correct summed values displayed for each call of the three different methods. Even though they are all named Sum, the compiler works out the correct method to call based on the method signature. That is how method overloading works.