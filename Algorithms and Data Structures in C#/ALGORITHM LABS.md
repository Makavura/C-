# SELF ASSESMENT LABS

## Self-Assessment Labs Introduction
In this lab you will notice some self-assessment labs that require you to think about problems on your own.  The labs that contain an editor for you to enter code, are real-time, code testing and scoring engines.   They are intended to allow you to test your code and thought processes around the problems presented.   They draw from material you will have covered in the Introduction to C#, Object Oriented Programming in C#, and this course, all on edX.org.

A special note on the grader labs.  The example input and output are intended to be used as an example of what you might expect.  Your algorithm needs to be correct for the required scenario and the grader will compile and execute your code on our servers to ensure your algorithm is performing the task correctly.   Do not assume that your code is correct ONLY if you get the same output as the examples given.   Test your code for all inputs.

Also, please note that you do not need to code your own inputs in the grader.  The testing engine for the grader will supply inputs using test cases we have developed.   You only need to focus on the logic in your algorithm in the method provided.   Feel free to try the code on your own computer first before submitting it to the grader questions.

Also, there is no reason to click any submit button for these code grader assessments.  The grader will evaluate your logic and return a result to you in the grader window.

## In this tutorial lab you will create a simple C# struct to gain a better understanding of how to implement them in your own code. Using Visual Studio, or an IDE of your choice, follow the below steps to practice creating a simple struct in C#.

Creating a struct to store information about a car. Think of the attributes you might include when considering a car. Mark those attributes down.
Create a new console-based application in C#
Inside the namespace of your code, but outside of the Class Program curly braces, create a new struct called Car.
Give Car three public attributes, of type string, to represent Make, Model, and Color.
Give Car a public method call Accelerate() that prints a message "Vroom".
struct Car
    {
        public string Make;
        public string Model;
        public string Color;

        public void Accelerate()
        {
            Console.WriteLine("Vroom");
        }
    }

Inside Main(), create a new instance of your Car struct called myCar
Assign values to the three variables that represent your car or a car you would like to own
Using Console.WriteLine() methods, output a description of your car in the following format, "My car is a Chevy Silverado that is gray in color."
Call the Accelerate() method on your Car struct.

static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Chevy";
            myCar.Model = "Silverado";
            myCar.Color = "Gray";
            Console.WriteLine($"My car is a {myCar.Make} {myCar.Model} that is {myCar.Color} in color.");
            Console.WriteLine();
            myCar.Accelerate();
        }

Close the solution in preparation for the next tutorial lab.

## n this lab you will create and use an enumeration for days of the week.

Open Visual Studio or the IDE of your choice and follow these steps
Create a new C# Console application
After the opening brace for class Program and just before the Main() method, enter the following code to create an enum called Days, that represents days of the week
enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };

Inside Main() add the following code.
int x = (int)Days.Sun;
int y = (int)Days.Fri;
Console.WriteLine("Sun = {0}", x);
Console.WriteLine("Fri = {0}", y);
Console.WriteLine(Days.Thu);

This code shows the use of enumerations in two aspects. First, you are using Intellisense when you type in Days.Sun or Days.Fri. Second, the internal representation of these enumeration values are numeric so you can convert them to int data types and display them as such.
The last line simply outputs the value Thu, which is the enumerated text value for that day.
Run the program by pressing CTRL+F5 to see the output

## In this lab you will create and use a simple array, iterate over that array, and sum up the numbers. This will give you some practice creating and working with arrays. You'll start by creating an empty array so that you can learn how to add values to that array in subsequent steps.

Open Visual Studio or the IDE of your choice and follow these steps
Create a new C# Console application
Inside the Main() method, create a new array of type int, with a size of 5, and name it numbers, using the following code:
int[] numbers = new int[5];

Using the following code, add values to the array by using an index position for the insertion.
numbers[0] = 2;
numbers[1] = 5;
numbers[2] = 9;
numbers[3] = 6;
numbers[4] = 7;

Now that you array has values, print out some of the values to practice accessing the values in an array. Use the following codeL
Console.WriteLine(numbers[0]);
Console.WriteLine(numbers[3]);
Console.WriteLine(numbers[2]);

Let's now look at how to iterate over an array by setting up a for loop and using a loop counter, summing the values and adding the sum to a total variable. Enter the following code after your last set of Console.WriteLine methods.
int total = 0;
for(int i = 0; i < numbers.Length; i++)
{
    total = total + numbers[i];
}
Console.WriteLine(total.ToString());

Let's look at a more concise way or iterating over an array. Enter the following code that uses a foreach loop to perform the same summation as listed in step 6.
int forEachTotal = 0;
foreach(int num in numbers)
{
    forEachTotal = forEachTotal + num;
}
Console.WriteLine(forEachTotal);


## MODULE 2 ASSESSMENT LAB
Prior to object oriented considerations and class files, programmers created structs in languages such as C.  Some programmers still use structs for storing related information, although the trend is more towards class files.  Because there may still be occasions where a struct makes sense in your code, you're going to create some structs in this assignment.

For this assignment, complete the following tasks. Just include member variables and at least one method in each struct. For example, a student could have a method called Study while a teacher could have a method called GradeAssignment. Use simple Console.WriteLine methods inside the Study and GradeAssigment methods to output text indicating the task, such as "Student is studying".

Create a struct to represent a student
Create a struct to represent a teacher
Create an array to hold 5 student structs.
Assign values to the fields in at least one of the student structs in the array
Using a series of Console.WriteLine() statements, output the values for the student struct that you assigned in the previous step
Finally, expand on the struct array steps to complete the following:

Use an appropriate looping structure to add values to the remaining student structs in the array.
Once completed, create another loop to iterate over the array and write the values to the console window

# STANDARD COLLECTIONS TUTORIAL LAB #1
Recall that an array is a data structure that is considered immutable. In other words, once we create an array of a certain size, we cannot easily increase or decrease its size. We can add values to existing array index positions, but we cannot expand the array by adding more values at the end, beyond the last index position. In this tutorial lab, you will focus on creating a new type of array that C# supports, known as the ArrayList, which is more flexible that the typical array class.

Open Visual Studio or your IDE of choice
Create a new C# console application.
Inside the Main() method, add the following code to create a new ArrayList called myArrList.
ArrayList myArrList = new ArrayList();

For a standard C# console application template, you may need to add a using statement to bring in the Collections namespace because the ArrayList exists in that namespace. If using Visual Studio, use the Quick Actions light bulb to have VS insert the using statement for you. If you are using another IDE, place the following using statement at the top of the code file along with the other using statements:
using System.Collections;
You may notice that we haven't specified a size for our ArrayList. This is one of the many advantages of using this collection type as compared to a simple array. Let's add some values to our ArrayList. Enter the following code after your ArrayList declaration:
myArrList.Add("First Item");
myArrList.Add(3);
myArrList.Add(4.5);

foreach(object obj in myArrList)
{
    Console.WriteLine(obj.ToString());
}

Wait a minute, what did we just do? We added a string value, an integer, and a float. Recall that an array must have a type specified so that the compiler knows how much memory needs to be requested. Part of the reason is that an array is actually stored on a special memory location called the stack. But our ArrayList allows us to use different types. The ArrayList stores the values as Objects. That is, a standard .NET Object type that all types in .NET derive from. As a result, the ArrayList is stored in another special memory location known as the Heap. For an explanation of these two memory locations, refer to the Object-Oriented Programming in C# course.
Run the code by pressing CTRL+F5 to see the output.
Close the application so we can explore some more aspects of the ArrayList class.
Change your code to look like this:
ArrayList myArrList = new ArrayList();
myArrList.Add("First Item");
myArrList.Add("Third Item");
myArrList.Add("Second Item");

myArrList.Sort();
int itemIndex = myArrList.IndexOf("Third Item");

foreach(object obj in myArrList)
{
    Console.WriteLine(obj.ToString());
}
Console.WriteLine();
Console.WriteLine($"Third Item is at index {itemIndex}.");

What we have done here is to change the ArrayList to hold only string values. Then, we called the Sort() method. Can you determine how the values were sorted? If you think it is alphabetically, you are correct.
Next, we used a method on the ArrayList object known as IndexOf(). This is a search method for that object that will return the index of an item, if found. So why did we teach you search algorithms in Lesson 1 if objects like ArrayList have built in search functionality? So that you can use them on simple arrays or other data structures that are not classes in a programming language library.
You can experiment with some of the other methods on the ArrayList class if you would like. Use MSDN to research the methods, what they do, and how to use them
As a quick challenge, try to change Add() methods back to their original values of a string, integer, and float value and then call the Sort() method. What happened? You should have received an unhandled exception message in the console window.
Stop the application and leave Visual Studio open for the next exercise.
NOTE: It's important to understand why step 13 generated that unhandled exception. While it is a more advanced OOP topic, it has a relatively simple explanation. If you want to sort integers, you can do that easily because they are the same type. Likewise, an ArrayList of strings are of the same type, String. But recall from step 6 above, the ArrayList stores the items as Objects. That means they are stored as an object, derived from the class Object. But why can they not be sorted?

Think of it this way, which is less, a car or an animal? You cannot determine if a car is less than or greater than an animal. They are not the same type so there is no way to determine a sorting order. Likewise with strings, integers, and floats. They cannot be adequately compared for sorting.

The complicated part of this is solved through the use of OOP and using interfaces such as IComparable etc. where they programmer creating the objects, needs to implement functionality in the objects to provide a mechanism to compare against other objects. Again, this is an advanced topic and one that we don't teach here, but it was put in place for your awareness.

# TUTORIAL LAB 2, DICTIONARIES AKA HASTABLES
In this lab you will create and use what C# refers to as a hashtable but is also known as a dictionary. Or it at least behaves like a dictionary.

As you read in the course material, a Hasthable (dictionary) stores a collection of key/value pairs and the methods needed to work with the items. Let's create a Hashtable and try out some functionality.

Open Visual Studio, or the IDE of your choice.
Create a new C# Console application
Ensure that you have the using System.Collections; namespace directive at the top of your code file
Enter the following code in the Main() method:

        // Create a new hash table.
        //
        Hashtable openWith = new Hashtable();
        
        // Add some elements to the hash table. There are no 
        // duplicate keys, but some of the values are duplicates.
        openWith.Add("txt", "notepad.exe");
        openWith.Add("bmp", "paint.exe");
        openWith.Add("dib", "paint.exe");
        openWith.Add("rtf", "wordpad.exe");
We create a new Hashtable object and call it openWith. This example is designed to create a hashtable that lays out the application that will be used to open a file with the extension given. The extension serves as the key while the application name serves as the value. There is your key/value pair for a hashtable.
We then add four entries into our hashtable with a note that there are no duplicate keys, which are not permitted in a hashtable but we can, and do have, duplicate values. Think about why duplicate keys are not permitted. They need to be unique for the purposes of searching.

A hashtable cannot contain two keys with the same value, enter the following code. The try..catch block demonstrates the fact that an exception will be thrown if you attempt to add a duplicate key.
        // The Add method throws an exception if the new key is 
        // already in the hash table.
        try
        {
            openWith.Add("txt", "winword.exe");
        }
        catch
        {
            Console.WriteLine("An element with Key = \"txt\" already exists.");
        }
Let's now enter some code to access the values in our hashtable. Note that in the output for the rtf key, we use the name of the hashtable and square brackets, similar to accessing an item using an index in an array, openWith["rtf"]. This doesn't return the key but it does return the value associated with that key.
        // The Item property is the default property, so you 
        // can omit its name when accessing elements. 
        Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);
What if we want to update or change a value in our hashtable? Enter the following code to demonstrate this.
        // The default Item property can be used to change the value
        // associated with a key.
        openWith["rtf"] = "winword.exe";
        Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);
Using openWith["rtf"] = "winword.exe" is an example of updating, or changing, the value that is associated with that key. Much like you might use myArray[1] = "text"; to change the value in an array.

Enter this code to see how to add a key/value pair without using the Add() method.
        // If a key does not exist, setting the default Item property
        // for that key adds a new key/value pair.
        openWith["doc"] = "winword.exe";
Using ContainsKey() is a great way to check for the existence of a key in the hashtable before you attempt to add a new entry. This can prevent an unhandled exception in your code. Enter the following code segment to implement this.

        // ContainsKey can be used to test keys before inserting 
        // them.
        if (!openWith.ContainsKey("ht"))
        {
            openWith.Add("ht", "hypertrm.exe");
            Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
        }
Finally, we use a foreach loop to iterate over the hashtable and output the values to the console window. Note that we are using a DictionaryEntry type in the foreach loop and not a Hashtable type. The reason is that the whole class is a hashtable but the items in the hashtable are known as dictionary entries.

        // When you use foreach to enumerate hash table elements,
        // the elements are retrieved as KeyValuePair objects.
        Console.WriteLine();
        foreach( DictionaryEntry de in openWith )
        {
            Console.WriteLine("Key = {0}, Value = {1}", de.Key, de.Value);
        }

# MODULE 3 ASSESSMENT LAB
For this assignment, you will make use of the skills you learned in the tutorial labs but you also must spend some time looking at the other collection types that were covered in the course material and use http://msdn.microsoft.com to reference the methods and properties of the collections that you will implement. This is a real-world developer scenario that is common in software development tasks. You may not have always implemented a data structure prior but now need to use your existing knowledge plus acquire some new knowledge through research.

For this assignment, complete the following tasks. The assessment questions will evaluate your tasks in this lab.

Create a new C# Console application for this lab.
Create a Student class in your project with common properties
Create an ArrayList to hold student objects
Create a Stack object inside the Student object, called Grades, to store test scores.
Create 3 student objects.
Add 5 grades to the the Stack in the each Student object. (this does not have to be inside the constructor because you may not have grades for a student when you create a new student.)
Add the three Student objects to the Students ArrayList.
Using a foreach loop, iterate over the Students in the ArrayList and output their first and last names to the console window. (For this exercise you MUST cast the returned object from the ArrayList to a Student object. Also, place each student name on its own line)


# TUTORIAL LAB 1, GENERIC LIST<T>
In the previous module's assessment lab, you created an ArrayList of Student objects. At one point in the lab, you were told that you needed to cast the objects in the ArrayList back to a Student object when you pulled them out for use. This was noted as a shortcoming to non-Generic collections in the course content.

In this tutorial lab, you will change that ArrayList to a Generic list collection that is strongly typed, allowing you to retrieve the values without casting, but also adding some type safety to your code.

Open Visual Studio, or your favorite IDE
Create a new C# Console application
Ensure that the using System.Collections.Generic; directive is at the top of the code file. It is adde automatically by Visual Studio when creating a C# project but it's always good to verify.
Create a Student class in your project with the following attributes:
First Name
Last Name
Age
Program (this is used to represent a university program they are enrolled in such as Computer Science, or Business)
Sample Student Object:

class Student
{
    public Student(string first, string last, int age, string prog)
    {
        this.FirstName = first;
        this.LastName = last;
        this.Age = age;
        this.Program = prog;
    }

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Program { get; set; }
}
Inside the Main() method in Program.cs, create a new Generic List of type Student using the following code
// Create a Generic List of type Student
List<Student> students = new List<Student>();

Now let's create at least three student objects that we can use in our code.
Student stud1 = new Student("Tom", "Thumb", 12, "Computer Science");
Student stud2 = new Student("Fred", "Flintstone", 45, "Geology");
Student stud3 = new Student("Mickey", "Mouse", 35, "Animation");

Add the student objects to your new List.
students.Add(stud1);
students.Add(stud2);
students.Add(stud3);

Now that we have students in our list, let's see how to interact with them. Let's use a foreach loop to print out the first names of each student in the list. Note that in the foreach loop, we are using the type Student to access the objects in the list. Because our list is a Generic List, it is strongly typed and no casting is required.
foreach(Student stud in students)
{
    Console.WriteLine(stud.FirstName);
}

Run your code to validate the output shows Tom, Fred, and Mickey on separate lines.
Stop the application and go back to Visual Studio
What if we want to check on the existence of a student object in our list? Perhaps we are adding students and we want to verify that we have a specific student in the list. Enter the following code to check for the existence of stud1 in the list.
bool exists = students.Contains<Student>(stud1);
Console.WriteLine(exists.ToString());

Run the application and verify the results.
Close the application and go back to Visual Studio
What if you need to delete a student from the list? List provides the Remove method to handle this. Enter the following to delete Mickey from the list.
students.Remove(stud3);
Console.WriteLine(students.Count());

Run the code and verify that the count is now 2.
You can also run the previous Contains method to check and see if stud3 is indeed removed.
Close the application


