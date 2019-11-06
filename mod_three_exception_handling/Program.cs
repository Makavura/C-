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

int result = Divide(2, 0);

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
