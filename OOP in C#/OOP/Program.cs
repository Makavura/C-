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
            public string Make { get; set; }
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



        }

        // PARIAL CLASSES
        // split definition of the class across multiple source files
        // combined during compilation

        // usefule when:
        // team needs to work on same class at the same time
        // work with automatically generated source code
        // example
        // structs and interfaces can also be split
        public partial class DrinksMachine
        {

            public void MakeCappuccino()
            {
                // Method logic goes here.
            }
        }

        public partial class DrinksMachine
        {

            public void MakeEspresso()
            {
                // Method logic goes here.
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
