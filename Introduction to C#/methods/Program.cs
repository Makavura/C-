using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int upTime = 2000;
            bool shutdownAutomatically = true;

            StartService(upTime, shutdownAutomatically);

            void StartService(int upTime, bool shutdownAutomatically)
            {
                Console.WriteLine("Your system will shutdown in " + upTime + " seconds");
            }

            // ReturnMultiOut(out first, out sValue);
            // Console.WriteLine($"{first.ToString}, {sValue} ");

            // static void ReturnMultiOut(out int i, out string s)
            // {
            //     i = 25;
            //     s = "using out";
            // }

            // Using ref requires that the variables be initialized first
            string sValue = "";
            int first = 0;
            ReturnMultiRef(ref first, ref sValue);
            Console.WriteLine($"{first.ToString()}, {sValue}");

            void ReturnMultiRef(ref int i, ref string s)
            {
                i = 50;
                s = "using ref";
            }
            //             When you define a method, you might realize that it requires different sets of information in different circumstances. You can define overloaded methods to create multiple methods with the same functionality that accept different parameters depending on the context in which they are called.

            // Overloaded methods have the same name as each other to emphasize their common intent. However, each overloaded method must have a unique signature, to differentiate it from the other overloaded versions of the method in the class.

            // The signature of a method includes its name and its parameter list. The return type is not part of the signature. Therefore, you cannot define overloaded methods that differ only in their return type. You can also not define overloaded methods that differ in position of the parameters.

            // The following code example shows three versions of the StopService method, all with a unique signature.

            void StopService()
            {
                // This method accepts no arguments
            }

            void StopService(string serviceName)
            {
                // This method overload accepts a single string argument
            }

            void StopService(int serviceId)
            {
                // This method overload accepts a single integer argument
            }
            // When you invoke the StopService method, you have choice of which overloaded version you use. You simply provide the relevant arguments to satisfy a particular overload, and then the compiler works out which version to invoke based on the arguments that you passed.

            // As noted above, you cannot create an overloaded method by just using the position of the arguments nor the return type. The below code shows an example of improper attempts at overloading methods.

            // void StopService(string serviceName, int seconds)
            {
                // This method overload accepts a string argument
                // and an integer argument
            }

            void StopService(int seconds, string serviceName)
            {
                // This method overload accepts an integer argument
                // and a string argument.  It appears different than
                // the preceding method because the arguments are 
                // passed in differently, however, it is still not
                // a valid overload
            }

            bool StopService(string serviceName, int seconds)
            {
                // This method overload accepts a string argument
                // and an integer argument but returns a boolean
                // result.  The difference between this method and
                // the others is the return type.  This is still not
                // a valid overload based on overloading rules.
            }

            // The mechanism used to denote an optional parameter is the inclusion of a default value.


            void StopService(bool forceStop, string serviceName = null, int serviceId = 1)
            {
                // code here that will stop the service
            }
            //             Named Parameters

            // Traditionally, when calling a method, the order and position of arguments in the method call corresponds to the order of parameters in the method signature. If the arguments are misaligned and the types mismatched, you receive a compile error.

            // In Visual C#, you can specify parameters by name, and therefore supply arguments in a sequence that differs from that defined in the method signature. To use named arguments, you supply the parameter name and corresponding value separated by a colon.

            // The following code example shows how to invoke the StopService method by using named arguments to pass the serviceID parameter.

            // StopService(true, serviceID: 1);
            // When using named arguments in conjunction with optional parameters, you can easily omit parameters. Any optional parameters will receive their default value. However, if you omit any mandatory parameters, your code will not compile.

            // You can mix positional and named arguments. However, you must specify all positional arguments before any named arguments.

        }
    }
}
