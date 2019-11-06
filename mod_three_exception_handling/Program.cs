using System;

namespace mod_three_exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
// practice exception handling techniques
// exceptions will happen in code
// planning for and coding properly
// make your application behave in a professional manner

int first = 9;
int second = 0;
Console.WriteLine("Enter your first number: ");
first = System.Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter your second number: ");
second = System.Int32.Parse(Console.ReadLine());

int result = Divide(first, second);
Console.WriteLine($"the result of dividing {first} by {second} is {result}");

        }

        // method divide() has no validation and with no input invalidation or error catching
// the application will crash

static int Divide(int first, int second)
{
    int result = 0;
    
    try
    {
result = first /second;
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Cannot divide by zero, please provide a non-zero  value for your second value");
    }
    return result;
}

    }
}
