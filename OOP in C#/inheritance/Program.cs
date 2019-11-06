using System;

namespace inheritance
{
    class Program
    {
        // INHERITANCE

        // use inheritance as an aspect of code reuse
        // define common classes that will contain common features and have relationships with one another
        // inheritamce allows one to create a base class containing the core, shared attributes
        // each object would inherit these attributes while extending them for their own needs
        // derived class/subclass - class that inherits from base class
        // base class sometimes referred to as super class

        // C# does not support mulitple inheritance directly
        // multiple inheritance - a single subclass can inherit multiple base classes
        // 

        abstract class Employee
        {
            public int empnumber;
            string firstName;
            string lastName;
            string address;

            public string EmpNumber
            {
                get
                {
                    return empNumber;
                }
                set
                {
                    empNumber = value;
                }
            }

            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }

            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }

            public string Address
            {
                get
                {
                    return address;
                }
                set
                {
                    address = value;
                }
            }

            public virtual void Login()
            {

            }
            public virtual void LogOff()
            {

            }
            public abstract EatLunch();
        }

        // inherit from  a base class , append derived class name with a colon and the name of the base class
        class manager : Employee
        {
            private char payRateindicator;
            private Employee[] emps;
        }

        // abstract classes cannot be instantiated
        // abstract classes require that the subclass to implement some or all of the functionality

        // create by prepending keyword abstract to class
        // sets up some requirements
        // decide which methods "must" be implemented and which "can" be implemented or overriden in the subclass

        //  any nethod declared in abstract class that will contain some implementation in abstract class, 
        //  but that cna be overriden in subclass is decorated with virtual keyword

        // one can write implementation code in abstract class whose implememtation the sub classes are free to override
        // or accept as inherited

        //  An abstract method cannot exist in non-abstract class
        // An abstract method is not permitted to have any implementation, including curly braces
        // An abstract method signature must end in a semi-colon
        // An abstract method MUST be implemented in any sub class. Failure to do so will generate a compiler warning in C#.        
        static void Main(string[] args)
        {

        }
    }
}
