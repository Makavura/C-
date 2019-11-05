
# C SHARP

## DATA TYPES

All applications store and manipulate data within the computer's memory. C# supports two kinds of data types used to represent real-world information, value types and reference types.

Value types are so-called because they contain the actual value of the data they store. For example, you might have an int type that stores the value 3. The literal value of 3 is stored in the variable that you declare to hold it.

With the exception of DateTime and string, in the below table,the data types listed are aliases for structs in .NET that represent the data types in the Microsoft .NET Framework. Anyplace you can use int you can also use System.Int32. We'll cover structs in the algorithms and data structures course on edX.

Reference types are also known as objects. Reference types are created from class files, which are covered in the Object-Oriented Programming in C# course.

A reference type stores a reference to the location in memory of the object. If you are familiar with C/C++ then you can think of a reference to the memory location to be the same as a pointer. C# does not require you to use pointers.

The following table shows the most commonly used value types.

Type	| Description	    | Size (bytes)	|  .NET Type |	Range
int	    |    Whole numbers	    4	        System.Int32	-2,147,483,648 to 2,147,483,647
long	|  Whole numbers (bigger range)	8	System.Int64	-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
float	| Floating-point numbers	4	System.Single	+/-3.4 x 10^38
double	| Double precision (more accurate) floating-point numbers	8	System.Double	+/-1.7 x 10^308
decimal	| Monetary values	16	System.Decimal	28 significant figures
char|	 Single character	2	System.Char	N/A
bool	Boolean	1	System.Boolean	True or false
DateTime	Moments in time	8	System.DateTime	0:00:00 on 01/01/0001 to 23:59:59 on 12/31/9999
string	Sequence of characters	2 per character	System.String	N/A
For more information , you can visit the MSDN web site, http://msdn.microsoft.com, for documentation in C# supported data types.

## STATEMENTS

In C#, a statement is considered a command. Statements perform some action in your code such as calling a method or performing calculations. Statements are also used to declare variables and assign values to them.

Statements are formed from tokens. These tokens can be keywords, identifiers (variables), operators, and the statement terminator which is the semicolon (;). All statements in C# must be terminated with a semicolon.

Example:

int myVariable = 2;

In this example, the tokens are:

int
myVariable
=
2
;
int is the data type used for the variable called myVariable.

The '=' is an assignment operator and is used to set the value of myVariable to 2.

The numeral 2 is known as a literal value. Literal simply means that it is, what it says it is. The numeral 2 cannot be anything but the numeral 2. You cannot assign a value to 2. You can assign the numeral 2 to a variable however, and that is what this C# statement is doing.

Finally, the statement ends with a semi-colon.

## IDENTIFIERS

In C#, an identifier is a name you give to the elements in your program. Elements in your program include;

Namespaces - the .NET Framework uses namespaces as a way to separate class files into related buckets or categories. it also helps avoid naming collisions in applications that may contain classes with the same name
Classes - classes are the blueprints for reference types. They specify the structure an object will take when you create instances of the class
Methods - covered a bit later in the course, they are discrete pieces of functionality in an application. They are analogous to functions in the non-object-oriented programming world
Variables - these are identifiers or names, that you create to hold values or references to objects in your code. A variable is essentially a named memory location
When you create a variable in C# you must give it a data type. The data type tells the compiler and syntax checker what kind of information you intend to store in that variable. If you try to assign data that is not of that type, warnings or errors will inform you of this. This is part of the type-safe nature of C#.

You can assign a value to the variable at the time you create it or later in your program code. C# will not allow you to use an unassigned variable to help prevent unwanted data from being used in your application. The following code sample demonstrates declaring a variable and assigning a value to it.

int myVar = 0;

C# has some restrictions around identifiers that you need to be aware of.

First off, identifiers are case-sensitive because C# is a case-sensitive language. That means that identifiers such as myVar, _myVar, and myvar, are considered different identifiers.

Identifiers can only contain letters (upper case or lowercase), digits, and the underscore character. You can only start an identifier with a letter or an underscore character. You cannot start the identifier with a digit. myVar and _myVar are legal but 2Vars is not.

C# has a set of reserved keywords that the language uses. You should not use these keywords as an identifier in your code. You may choose to take advantage of the case-sensitivity of C# and use Double as an identifier to distinguish it from the reserved keyword double, but that is not a recommended approach.

The following table contains the C# reserved keywords.

abstract

as

base

bool break

byte

case

catch char

checked

class

const continue

decimal

default

delegate do

double

else

enum event

explicit

extern

false finally

fixed

float

for foreach

goto

if

implicit in

in (generic modifier)

int

interface internal

is

lock

long namespace

new

null

object operator

out

out (generic modifier)

override params

private

protected

public readonly

ref

return

sbyte sealed

short

sizeof

stackalloc static

string

struct

switch this

throw

true

try typeof

uint

ulong

unchecked unsafe

ushort

using

virtual void

volatile

while

## OPERATORS

When writing C# code, you will often use operators. An operator is a token that applies to operations on one or more operands in an expression. An expression can be part of a statement, or the entire statement. Examples include:

3 + 4 – an expression that will result in the literal value 4 being added to the literal value 3

counter++ – an expression that will result in the variable (counter) being incremented by one

Not all operators are appropriate for all data types in C#. As an example, in the preceding list the + operator was used to sum two numbers. You can use the same operator to combine two strings into one such as:

“Tom” + “Sawyer” which will result in a new string TomSawyer

You cannot use the increment operator (++) on strings however. In other words, the following example would cause an error in C#.

“Tom”++

The following table lists the C# operators by type.

Type	Operators
Arithmetic

+, -, *, /, %

Increment, decrement

++, --

Comparison

==, !=, <, >, <=, >=, is

String concatenation

+

Logical/bitwise operations

&, |, ^, !, ~, &&, ||

Indexing (counting starts from element 0)

[ ]

Casting

( ), as

Assignment

=, +=, -=, =, /=, %=, &=, |=, ^=, <<=, >>=, ??

Bit shift

<<, >>

Type information

sizeof, typeof

Delegate concatenation and removal

+, -

Overflow exception control

checked, unchecked

Indirection and Address (unsafe code only)

*, ->, [ ], &

Conditional (ternary operator)

?:

## DATA CONVERSIONS

C# supports two inherent types of conversion (casting) for data types, implicit and explicit. C# will use implicit conversion where it can, mostly in the case when a conversion will not result in a loss of data or when the conversion is possible with a compatible data type. The following is an example of an implicit data conversion.

Converting from smaller to larger integral types:

int myInt = 2147483647;
long myLong= myInt;
The long type has a 64-bit size in memory while the int type uses 32-bits. Therefore, the long can easily accommodate any value stored in the int type. Going from a long to an int may result in data loss however and you should use explicit casting for that if you know what data will be lost and it doesn't impact your code.

Explicit casts are accomplished in one of two ways as demonstrated with the following code sample.

double myDouble = 1234.6;
int myInt;
// Cast double to int by placing the type modifier ahead of the type to be converted
// in parentheses
myInt = (int)myDouble;
The second option is to use the methods provided in the .NET Framework.

double myDouble = 1234.6;
int myInt;
// Cast double to int by using the Convert class and the ToInt32() method.
// This converts the double value to a 32-bit signed integer
myInt = Convert.ToInt32(myDouble);
You will find many other methods in the Convert class that cast to different integral data types such as ToBoolean(), ToByte(), ToChar(), etc.

The Convert.ToInt32() method can also be used to cast a string literal to a numeric data type. For example, you may have GUI-based application in which uses input data into text boxes. These values are string values when passed to the code in your application. Use of the above method to cast the string to numbers can help prevent exceptions in your code when trying to use the wrong data type in a specific area.

C# also provides another mechanism to deal with casting types. The use of the TryParse() method and Parse() methods can help with casting as well. These methods are attached to the types in C# rather than the Convert class. An example will help demonstrate.

// TryParse() example
bool result = Int32.TryParse(value, out number);

// Parse() example
int number = Int32.Parse(value);
In the TryParse() example, the method returns a Boolean result indicating if the conversion succeeded. In the Parse() example, if the conversion does not succeed, an exception will be thrown.