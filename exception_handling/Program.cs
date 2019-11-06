using System;

namespace exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
         
        // Exception handling
// what is an exception -- an event which occurs during the execution of a program
// that disrupts the normal flow of the program's iinstructions

// when an error occurs within a method, the method creates an object and hands
//  it off to the runtime systme 
        // try/catch the key programming construct to implement structured
        //  exception 

        //  global error object -- traditional;
        //  set data in code object to indicate cause of error and return to
        //  caller
    // EXCEPTION
        // an exception is an indication of an error or exceptional condition
        // a method can throw an exception when it detects that something 
        // unexpected has happened
    // EXCEPTION PROPAGATION
        // exception up the calling stack

        // try catch finally 
        try
        {
            // Try block 
        }
        catch (MissingFieldException fnfEx)
        {
            // catch block 1
        }
        catch (Exception e)
        {
            // catch block n
        }

        // some methods may contain code that must always be run,
        // even if an unhandled exception occurs
        // eg release some resources before it terminates 
        // or close a file it was writing to
        // a finally block handles this situation
        finally
        {
            // code that always has to run
        }

        // try catch throw
        // catch exception, attempt to handle, if catch block for exception cannot resolve
        // throw the exception to propagate the error

        var ex = new NullReferenceException("The 'name' parameter is null");
        throw ex;

        try
        {
// code that could cause exception
        }
        catch (NullReferenceException ex)
        {
// catch all NullReferenceException exceptions
        }
        catch ( Exception ex)
        {
// attempt to handle the exception
// ...
// if this catch cannot resolve the exception
// throw it to the calling code
        throw;
        }
        }
    }
}
