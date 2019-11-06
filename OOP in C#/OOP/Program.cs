using System;

namespace OOP
{
    class Program
    {
        public class DrinksMachine
        {
            //  classes are a programming construct 
            // enable you to encapsulate behaviours and characteristics 
            // of a logical entity in a reusable and extensible way

            //  a class is a blueprint of a type
            // class defines behaviours and characteristics | class members
            // which are sahred by all instances of the class
            // these behaviours are represented by methods, fields, 
            // properties and events inside the class

            // created by class keyword precedeed by an access modifier
            // 4 access modifiers
            // private - accessible only inside a class or a structure
            // public  - accessible anywhere inside project
            // protected - object is accessible inside the class and in all classes that
            //  derive from that class
            // internal - object is accessible only inside its own assembly but not 
            // in another assemblies
            // protected internal - can access the protected internal member only in the
            //  same assembly or in a derived class in other assemblies
            // private protected - can access members inside containing clas sor in a class that
            // derives from a comtaining class, but only in same assembly / project


            // Methods, fields, propertiies and events here
            // use fileds and properties to define characteristics
            // use methods to represent the things that the object can do
            // define events to represent actions that might require attention


            private string _location;
            // define a property with a pruvate field
            public string Location
            {
                get
                {
                    return _location;
                }
                set
                {
                    if (value != null)
                        -_location = value;
                }
            }
            // define properties
            public int Age
            {
                get
                {
                    return Age;
                }
                set
                {
                    Age = value;
                }
            }
            public string Make
            {
                get
                {
                    return make;
                }
                set
                {
                    Make = value;
                }
            }
            // auto-implemented property
            public string Model { get; set; }
            // define methods
            public void MakeCappuccino()
            {
                // method logic
            }
            public void MakeEspresso()
            {
                // method logic
            }

            // define event
            // delegate definition not shown
            public event OutOfBeansHandler OutOfBeans;
            // Program.cs(68,26): error CS0246: The type or namespace name 'OutOfBeansHandler' could not be found (are you missing a using directive or an assembly reference?) [/home/makavura/.senior/Learning/C#/OOP in C#/OOP/OOP.csproj]

        }
        // Constructors
        public DrinksMachine(int Age)
        {
            this.Age = Age;
        }


        public DrinksMachine(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }


        public DrinksMachine(int age, string make, string model)
        {
            this.Age = age;
            this.Make = make;
            this.Model = model;
        }
        // PARIAL CLASSES
        // split definition of the class across multiple source files
        // combined during compilation

        // usefule when:
        // team needs to work on same class at the same time
        // work with automatically generated source code
        // example
        // structs and interfaces can also be split
        public partial class ShotsMachine
        {

            public void MakeKamikaze()
            {
                // Method logic goes here.
            }
        }

        public partial class ShotsMachine
        {

            public void AlabamaSlammer()
            {
                // Method logic goes here.
            }
        }

        // INSTANTIATING A CLASS
        // a class is a blueprint for a type
        // to use its behaviours and characteristics, you need to instantiate the class
        //  an instance of a class is an object

        DrinksMachine dm = new DrinksMachine();
        // create an object in memory based on DrinksMachine type
        // create an object reference named dm that refers to new DrinksMachine object
        // type inference
        // -allow compiler to deduce object type at compile time
        // to use type inference use var keyword, like so

        // ENCAPSULATION
        // -used to descirbe accessibility of members inside a class
        // -also defined as act of including all data and behaviour required of a class
        // within a class definition

        // Access modifier	Description
        // public	The type is available to code running in any assembly that references the assembly in which the class is contained.
        // internal	The type is available to any code within the same assembly, but not available to code in another assembly.
        // private	The type is only available to code within the class that contains it. You can only use the private access modifier with nested classes. This is the default value if you do not specify an access modifier.
        // protected	The type is only accessible within its class and by derived class instances.

        // properties can be a part of encapsulation
        // permit users oof a class a means of getting and setting values
        // for the private member fields within class
        // setting members private is known as a form of hiding

        // hide implementation or verification code
        // Properties also present an "interface" to your class by exposing a way to get or 
        // set the members of the class that the user can trust. In other words, if you have
        //  a property called public Birthdate(date birth), that accepts a birthdate from a user,
        //  you can implement the validation code in anyway you see fit, such as using 
        // regular expressions to validate or perhaps some custom logic to verify the date
        //  range, and then later change that validation logic without impacting the use of 
        // the property. Users still just pass in a birthdate in date format.

        // two basic property types of properties in a class
        // read-only or read-write
        // a get property accessor is used to return the property value
        // a set accessor is used to assign a new value, ommission makes it read only
        // a value keyword is used to define value being assigned to set accessor
        // for simple properties that require no custom accessor code, consider the
        // option of using auto-implemented properties

        // auto-implemented properties
        public double TotalPurchases { get; set; }
        public string Name { get; set; }
        public int CustomerID { get; set; }

        // CONSTRUCTORS
        public class DrinksMachine
        {
            public int Age
            {
                get;
                set;
            }
            public DrinksMachine()
            {
                Age = 0;
            }
        }

        // adding Multiple constructors
        public class DrinksMachine
        {
            public int Age { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public DrinksMachine(int age)
            {
                this.Age = age;
            }
            public DrinksMachine(string make, string model)
            {
                this.Make = make;
                this.Model = model;
            }
            public DrinksMachine(int age, string make, string model)
            {
                this.Age = age;
                this.Make = make;
                this.Model = model;
            }
        }

        // Calling Constructors
        var dm1 = new DrinksMachine(2);
        var dm2 = new DrinksMachine("Fourth Coffee", "BeanCrusher 3000");
        var dm3 = new DrinksMachine(3, "Fourth Coffee", "BeanToaster turbo");

        static void Main(string[] args)
        {
            var dm = new DrinksMachine();
            // causes no change in application runtime, simply a shortcut to avoid
            // typing the class name twice
            // after instantiating object, you can use any of the members that 
            // are defined in class
            // dot notation
            dm.Make = "Fourth Coffee";
            dm.Model = "BeanCrusher 3000";
            dm.MakeEspresso();
        }
    }
}
