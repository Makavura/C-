using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
//Accessing Data by Index
 int[] oldNumbers = { 1, 2, 3, 4, 5 };
//number will contain the value 3
int _number = oldNumbers[2];

Console.WriteLine(_number);

//Iterating Over an Array
 int[] _oldNumbers = { 1, 2, 3, 4, 5 };
 for (int i = 0; i < oldNumbers.Length; i++)
 {
     int number = _oldNumbers[i];
    //  ...
 }

 // Create an array that is 10 long(rows) by 10 wide(columns)
int[ , ] arrayName = new int[10,10];
// In order to access elements in a multidimensional array, you must include all indices as in the example code here.

// Access the element in the first row and first column
int value = arrayName[0,0];
Console.WriteLine(value);
//Access the element in the first row and second column
int value2 = arrayName[0, 1];
Console.WriteLine(value2);
//Access the element in the second row and first column
int value3 = arrayName[1, 0];
Console.WriteLine(value3);

// int[] ooop = new int[];
// Console.WriteLine(ooop);

char[] charArray = {'S', 't', 'r', 'i', 'n', 'g'};

// You execute this line of code:

char myChar = charArray[3];
Console.WriteLine(myChar);

 char[,] multiArray = new char[3, 2] { { 'a', 'b' }, {'c', 'd' }, {'e', 'f' }};
    Console.WriteLine(multiArray[2,1]);
        }
    }
}
