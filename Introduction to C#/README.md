
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

## C# IF STATEMENTS

In C#, if statements are concerned with Boolean logic. If the statement is true, the block of code associated with the if statement is executed. If the statement is false, control either falls through to the line after the if statement, or after the closing curly brace of an if statement block.

The following code sample demonstrates an if statement to determine if a response contains a value of yes.

//if statement

string response = "Yes";
if (response == "Yes")
{
    // statements that will execute if the value of the response variable is
    // yes, will be placed here.
}
Note the use of curly braces in the code sample. You can eliminate the curly braces if your statement to execute is a single line statement. C# understands that if no curly braces are used, the line immediately after the if(condition) will be executed if the condition is true. Otherwise, it is not. To avoid confusion as to which lines will execute for a true condition, a recommended practice is to always use curly braces for your if statement.

In C#, if statements can also have associated else clauses. The else clause executes when the if statement is false.

The following code example shows how to use an if else statement to execute code when a condition is false.

//if else Statements

string response;
if (response == "connection_failed")
{
    // Block of code executes if the value of the response variable is "connection_failed".
}
else
{
    // Block of code executes if the value of the response variable is not "connection_failed".
}
if statements can also have associated else if clauses. The clauses are tested in the order that they appear in the code after the if statement. If any of the clauses returns true, the block of code associated with that statement is executed and control leaves the block of code associated with the entire if construct.

The following code example shows how to use an if statement with an else if clause.

//else if Statements

string response;
if (response == "connection_failed")
{
    // Block of code executes if the value of the response variable is "connection_failed".
}
else if (response == "connection_error")
{
    // Block of code executes if the value of the response variable is "connection_error".
}
else
{
    // Block of code executes if the value of the response variable is neither above responses.
}
You can create as many else if blocks as necessary for your logic, or until you become completely lost from too many else if clauses. If you require any more than five else if clauses, you might want to consider the switch statement, presented next.

## THE SWITCH STATEMENT
If there are too many else if statements, code can become messy and difficult to follow. In this scenario, a better solution is to use a switch statement. The switch statement simply replaces multiple else if statements.

The following sample shows how you can use a switch statement to replace a collection of else if clauses.

//switch Statement

string response;
switch (response)
{
   case "connection_failed":
      // Block of code executes if the value of response is "connection_failed".
      break;
   case "connection_success":
      // Block of code executes if the value of response is "connection_success".
      break;
   case "connection_error":
      // Block of code executes if the value of response is "connection_error".
      break;
   default:
      // Block executes if none of the above conditions are met.
      break;
}
Notice that there is a block labeled default:. This block of code will execute when none of the other blocks match.

In each case statement, notice the break keyword. This causes control to jump to the end of the switch after processing the block of code. If you omit the break keyword, your code will not compile. If you want to handle multiple cases with the same code segment, you can use a fall-through setup similar to this sample code.

string response;
switch (response)
{
   case "connection_success":
      // Block of code executes if the value of response is "connection_success".
      break;
   case "connection_failed":
   case "connection_error":
      // Block of code executes if the value of response is "connection_failed"
      // or "connection_error;
      break;
   default:
      // Block executes if none of the above conditions are met.
      break;
}
If you are coming from another programming language, such as C, that also uses the switch statement, you might notice that in the C# language, you can use string values in your switch statements and don't have to use integers or enumerated types. C# switch statements support the following data types as expressions:

sbyte
byte
short
ushort
int
uint
long
ulong
char
string
enumerations

## INTRODUCING REPETITION
Repetition is essentially the concept of doing something in a repeating manner. In programming, you will typically use repetition to iterate over items in a collection or to perform the same task over and over again to produce the desired effect in your program.

Visual C# provides a number of standard constructs known as loops that you can use to implement iteration logic. If you are coming from other programming languages, you might recognize for loops, while loops, and do loops. C# supports all three of these iteration statements.

## INTRODUCING REPETITION
Repetition is essentially the concept of doing something in a repeating manner. In programming, you will typically use repetition to iterate over items in a collection or to perform the same task over and over again to produce the desired effect in your program.

Visual C# provides a number of standard constructs known as loops that you can use to implement iteration logic. If you are coming from other programming languages, you might recognize for loops, while loops, and do loops. C# supports all three of these iteration statements.

## THE FOR LOOPS
The for loop executes a block of code repeatedly until the specified expression evaluates to false. You can define a for loop as follows.

for ([initializers]; [condition]; [iterator])
{
   // code to repeat goes here
}
The [initializers] portion is used to initialize a value as a counter for the loop. On each iteration, the loop checks that the value of the counter is within the range to execute the for loop, specified in the [condition] portion., and if so, execute the body of the loop. At then end of each loop iteration, the [iterator] section is responsible for incrementing the loop counter.

The following code example shows how to use a for loop to execute a code block 10 times.

//for Loop
for (int i = 0 ; i < 10; i++)
{
    // Code to execute.
}
In this example, i = 0; is the initializer, i < 10; is the condition, and i++ is the iterator.

For Each Loops
While a for loop is easy to use, it can present some challenges, depending on the situation. As an example, consider iterating over a collection or an array of values. You would need to know how many elements are in the collection or array. In many cases you will know this, but sometimes you may have collections or arrays that are dynamic and are not sized at compile-time. If the size of the collection or array changes during runtime, it might be a better option to use a foreach loop.

The following code example shows how to use a foreach loop to iterate a string array.

//foreach Loop

string[] names = new string[10];

// Process each name in the array.
foreach (string name in names)
{
    // Code to execute.
}
C# handles determining how many items are in the array and will stop executing the loop when the end is reached. The use of foreach loops can help prevent index out of bounds errors on arrays.

## THE WHILE LOOP
A while loop enables you to execute a block of code while a given condition is true. For example, you can use a while loop to process user input until the user indicates that they have no more data to enter. The loop can continue to prompt the user until they decide to end the interaction by entering a sentinel value. The sentinel value is responsible for ending the loop.

The following code example shows how to use a while loop.

//while Loop

string response = PromptUser();
while (response != "Quit")
{
    // Process the data.
    response = PromptUser();
}
It's imperative to include the response = PromptUser(); inside the loop braces. Failure to put this into the loop body will result in an infinite loop because the sentinel value can never be changed.

## THE DO LOOP
A do loop, sometimes also referred to as a do...while loop, is very similar to a while loop, with the exception that a do loop will always execute the body of the loop at least once. In a while loop, if the condition is false from the start, the body of the loop will never execute.

You might want to use a do loop if you know that the code will only execute in response to a user prompt for data. In this scenario, you know that the application will need to process at least one piece of data, and can therefore use a do loop.

The following code example shows the use of a do loop.

//do Loop

do
{
    // Process the data.
    response = PromptUser();
} while (response != "Quit");

# METHODS

## METHOD DECLARATIONS
The ability to define and call methods is a fundamental component of object-oriented programming, because methods enable you to encapsulate operations that protect data that is stored inside a type.

Typically, any application that you develop by using the Microsoft .NET Framework and Visual C# will have many methods, each with a specific purpose. Some methods are fundamental to the operation of an application. For example, all Visual C# desktop applications must have a method called Main that defines the entry point for the application. When the user runs a Visual C# application, the common language runtime (CLR) executes the Main method for that application.

Methods can be designed for internal use by a type, and as such are hidden from other types. Public methods may be designed to enable other types to request that an object performs an action, and are exposed outside of the type.

The .NET Framework itself is built from classes that expose methods that you can call from your applications to interact with the user and the computer.

Declaring Methods

A method is declared using a method signature and method body. The signature portion is responsible for providing the access modifier, method return type, the method name, and the list of parameters. The body contains the implementation for what the method is intended to do. Each method signature component is explained here:

Access modifier - this is used to control the accessibility of the method (from where it can be called)
private - most restrictive and allows access to the method only from within the containing class or struct
public - least restrictive, allowing access from any code in the application
protected - allows for access from within the containing class or from within derived classes
internal - accessible from files within the same assembly
static - indicates the method is a static member of the class rather than a member of an instance of a specific object
Return type - used to indicate what type the method will return. Use void if the method will not return a value or any supported data type
Method name - all methods need a name so you know what to call in code. Identifier rules apply to methods names as well
Parameter list - a comma separated list of parameters to accept arguments passed into the method
Sample method:


public Boolean StartService(string serviceName)
{
   // code to start the service
}
In the preceding example, public is the access modifier, Boolean is the return type, StartService is the name, and string serviceName is the parameter list. Note that the parameter list specifies a data type and a name for the parameter.

For more information , you can see: Microsoft .NET Framework 4.5: https://aka.ms/edx-dev204x-net01

## CALLING A METHOD
You call a method to run the code in that method from part of your application. You do not need to understand how the code in a method works. You may not even have access to the code, if it is in a class in an assembly for which you do not have the source, such as the .NET Framework class library.

To call a method, you specify the method name and provide any arguments that correspond to the method parameters in parentheses.

The following code example shows how to invoke the StartService method, passing int and Boolean variables to satisfy the parameter requirements of the method’s signature.


int upTime = 2000;
bool shutdownAutomatically = true;
StartService(upTime, shutdownAutomatically);  
     
// StartService method.
void StartService(int upTime, bool shutdownAutomatically)
{
   // Perform some processing here.
}

## RETURNING DATA FROM METHODS
If the method returns a value, you specify how to handle this value, typically by assigning it to a variable of the same type, in your calling code.

The following code example shows how to capture the return value of the GetServiceName method in a variable named serviceName.

string serviceName = GetServiceName(); string GetServiceName() { return "FourthCoffee.SalesService"; }

The above example shows returning a single value from the method, in this case, the string value "FourthCoffee.SalesService". This string value gets assigned to the serviceName variable after the call to the method.

There may be times when you would prefer to return multiple values from a method. There are three approaches that you can take to accomplish this:

Return an array or collection
Use the ref keyword
Use the out keyword
In this first code example, a call to the method ReturnMultiOut is made. The parameters for this method use the out keyword to indicate that values will be returned for these parameters. Note that we do not have to call this method with an assignment statement as in the previous method call to GetServiceName()

ReturnMultiOut(out first, out sValue);
Console.WriteLine($"{first.ToString}, {sValue}");

static void ReturnMultiOut(out int i, out string s)
{
    i = 25;
    s = "using out";
}
In this new code example, the keyword ref is used to return multiple values from the method. Typically the ref keyword requires that the variables being used are initialized first.

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

 ## METHOD OVERLOADING
When you define a method, you might realize that it requires different sets of information in different circumstances. You can define overloaded methods to create multiple methods with the same functionality that accept different parameters depending on the context in which they are called.

Overloaded methods have the same name as each other to emphasize their common intent. However, each overloaded method must have a unique signature, to differentiate it from the other overloaded versions of the method in the class.

The signature of a method includes its name and its parameter list. The return type is not part of the signature. Therefore, you cannot define overloaded methods that differ only in their return type. You can also not define overloaded methods that differ in position of the parameters.

The following code example shows three versions of the StopService method, all with a unique signature.

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
When you invoke the StopService method, you have choice of which overloaded version you use. You simply provide the relevant arguments to satisfy a particular overload, and then the compiler works out which version to invoke based on the arguments that you passed.

As noted above, you cannot create an overloaded method by just using the position of the arguments nor the return type. The below code shows an example of improper attempts at overloading methods.

void StopService(string serviceName, int seconds)
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

## USING OPTIONAL AND NAMED PARAMETERS
A key feature of Visual C# is the ability to interoperate with applications and components that are written by using other technologies. One of the principal technologies that Windows uses is the Component Object Model (COM). COM does not support overloaded methods, but instead uses methods that can take optional parameters. To make it easier to incorporate COM libraries and components into a Visual C# solution, Visual C# also supports optional parameters.

Optional Parameters

Optional parameters are also useful in other situations. They provide a compact and simple solution when it is not possible to use overloading because the types of the parameters do not vary sufficiently to enable the compiler to distinguish between implementations. When defining methods that will use optional parameters, it's important to note that you must specify all non-optional parameters first, and then list the optional parameters.

The following code example shows how to define a method that accepts one mandatory parameter (forceStop) and two optional parameters (serviceName, serviceID). Note that the mechanism used to denote an optional parameter is the inclusion of a default value.


void StopService(bool forceStop, string serviceName = null, int serviceId =1)
{
   // code here that will stop the service
}
You can call a method that takes optional parameters in the same way that you call any other method. You specify the method name and provide any necessary arguments. The difference with methods that take optional parameters is that you can omit the corresponding arguments, and the method will use the default value when the method runs.

Named Parameters

Traditionally, when calling a method, the order and position of arguments in the method call corresponds to the order of parameters in the method signature. If the arguments are misaligned and the types mismatched, you receive a compile error.

In Visual C#, you can specify parameters by name, and therefore supply arguments in a sequence that differs from that defined in the method signature. To use named arguments, you supply the parameter name and corresponding value separated by a colon.

The following code example shows how to invoke the StopService method by using named arguments to pass the serviceID parameter.

StopService(true, serviceID: 1);
When using named arguments in conjunction with optional parameters, you can easily omit parameters. Any optional parameters will receive their default value. However, if you omit any mandatory parameters, your code will not compile.

You can mix positional and named arguments. However, you must specify all positional arguments before any named arguments.

# EXCEPTION HANDLING

Traditionally, applications used the concept of a global error object. When a piece of code caused an error, it would set the data in this object to indicate the cause of the error and then return to the caller. It was the responsibility of the calling code to examine the error object and determine how to handle it. However, this approach is not robust, because it is too easy for a programmer to forget to handle errors appropriately.

The .NET Framework uses exceptions to help overcome these issues. An exception is an indication of an error or exceptional condition. A method can throw an exception when it detects that something unexpected has happened, for example, the application tries to open a file that does not exist.

## PROPAGATION

When a method throws an exception, the calling code must be prepared to detect and handle this exception. If the calling code does not detect the exception, the code is aborted and the exception is automatically propagated to the code that invoked the calling code. This process continues until a section of code takes responsibility for handling the exception. Execution continues in this section of code after the exception-handling logic has completed. If no code handles the exception, then the process will terminate and display a message to the user.

This is also sometimes referred to as passing the exception up the stack or up the calling stack.

## HANDLING EXCEPTIONS
The try/catch block is the key programming construct that enables you to implement structured exception handling in your applications written in C#.

You wrap code that may fail and cause an exception in a try block, and add one or more catch blocks to handle any exceptions that may occur. The recommended strategy to follow with catch blocks is to catch more specific exceptions first, and more general exceptions last.

For example, if you expect to run across an exception around file access, you would catch the FileNotFoundException in the first catch block and then perhaps create a second catch block that would watch for the generic Exception class to catch any other exception besides the FileNotFoundException.

If the FileNotFoundException is triggered, that catch block will have code to handle that exception. Otherwise, the other catch block(s) will contain code to handle other exceptions, or to throw the exception back up the stack to the calling application.

The following code example shows the syntax for defining a try/catch block.

try
{
    // Try block.
}
catch (FileNotFoundException fnfEx)
{
    // Catch block 1.
}
catch (Exception e)
{
    // Catch block n.
}

## USING FINALLY
Some methods may contain critical code that must always be run, even if an unhandled exception occurs. For example, a method may need to ensure that it closes a file that it was writing to, or releases some other resources before it terminates. A finally block enables you to handle this situation.

You specify a finally block after any catch handlers in a try/catch block. It specifies code that must be performed when the block finishes, irrespective of whether any exceptions, handled or unhandled, occur. If an exception is caught and handled, the exception handler in the catch block will run before the finally block.

You can also add a finally block to code that has no catch blocks. In this case, all exceptions are unhandled, but the finally block will always run.

The following code example shows how to implement a try/catch/finally block.

try
{
}
catch (NullReferenceException ex)
{
    // Catch all NullReferenceException exceptions.
}
catch (Exception ex)
{
    // Catch all other exceptions.
}
finally
{
   // Code that always runs to close files or release resources.
}

## THROWING EXCEPTIONS
You can create an instance of an Exception class in your code and throw the exception to indicate that an exception has occurred. When you throw an exception, execution of the current block of code terminates and the CLR passes control to the first available exception handler that catches the exception.

To throw an exception, you use the throw keyword and specify the exception object to throw.

The following code example shows how to create an instance of the NullReferenceException class and then throw the ex object.

var ex = new NullReferenceException("The 'Name' parameter is null.");
throw ex;
A common strategy is for a method or block of code to catch any exceptions and attempt to handle them. If the catch block for an exception cannot resolve the error, it can rethrow the exception to propagate it to the calling code.

The following code example shows how to rethrow an exception that has been caught in a catch block.

try
{
   // Code that could cause an exception
}
catch (NullReferenceException ex)
{
    // Catch all NullReferenceException exceptions.
}
catch (Exception ex)
{
    // Attempt to handle the exception
    ...
    // If this catch handler cannot resolve the exception, 
    // throw it to the calling code
    throw;
}

## 