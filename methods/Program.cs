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
        }
    }
}
