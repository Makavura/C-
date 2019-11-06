using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod_one_lab_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

// Create variables of differemt data types
// Initialize with a default value

string firstName = "";
string lastName = "";
int age = 0;
string street = "";
string city ="";
string country = "";
string birthDate = "";


//  Assign some values
firstName ="Tom";
lastName ="Thumb";
age = 18;
street = "123 Fourth Street ";
city="AnyTown";
birthDate = ("1932, 6, 1");
DateTime bD;

// ERROR SOURCE - Cannot implicitly convert type 'string' to 'System.DateTime'
// birthDate = new DateTime(1932, 6, 1);
// FIX - https://stackoverflow.com/questions/4498206/cannot-implicitly-convert-type-string-to-system-datetime
if ( DateTime.TryParseExact(birthDate, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture,
System.Globalization.DateTimeStyles.None, out bD)){
    Console.WriteLine(bD);
}
// Console.WriteLine(birthDate.ToString());
// output to the console window

// use simple output with just variable name

Console.WriteLine(firstName);
Console.WriteLine(lastName);

// use placeholder style
Console.WriteLine("{0} years old.", age);

// use string concatenation
Console.WriteLine(street + "," + city + "," + country);

// use string interpolation
Console.WriteLine($"Born on {bD}");
            
        }
    }
}
