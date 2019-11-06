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

        public class Employee
        {
            public int Empnumber;
            string FirstName;
            string LastName;
            string Address;

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
        }

        // inherit from  a base class , append derived class name with a colon and the name of the base class
        class manager : Employee
        {
            private char payRateindicator;
            private Employee[] emps;
        }

        // abstract classes cannot be instantiated
        static void Main(string[] args)
        {

        }
    }
}
