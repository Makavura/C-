using System;

namespace interfaces_poymorphism
{
    class Program
    {

        // INTERFACES

        // an interface is a class without an implementation
        // specifies a set of charecteristics and behaviours by defining signatures methods, properties
        // evemts amd indexers without specifying how any of these members are implemented


        // classes implememt interfaces

        // by implementing the interface the class is guaranteeing that it will provide
        // the funcctionality provided by the interface

        // CREATING INTERFACES

        public interface IBeverage
        // Programming convention dictates that all interface names should begin with an "I".
        // default access modifier  - internal } available to any code witi=hin the same assembly
        // public - interface is available to any interface running in any assembly

        // interface members - define signature wihtouta ny implementation details
        // can include methods, events, properties and indexers

        {
            // method name and return type icnluding any parameters
            Int GetServingTemperature(bool includesMilk);

            // property name, type and process accessors
            bool isFairtrade { get; set; }

            //  event keyword, event handler delegate and name of event
            event EventHandler OnSoldOut;

            // indexer return type and accessors
            string this[ThreadStaticAttribute index] { get; set; }

        }

        public interface ILoyaltyCardHolder
        {
            // read only integer property named TotalPoints
            int TotalPoints { get; }

            // method named AddPoints that accepts a decimal argument
            int AddPoints(decimal transactionValue);
            // a method named reset points
            void ResetPoints();
            // methods do not include method bodies
            // properties indicate which accessors to include but no implementation details

            // interface simply states that the any implementing class must
            //  include and provide implementation or the three members
        }

        public class Customer : ILoyaltyCardHolder
        {
            private int totalPoints;
            public int TotalPoints
            {
                get { return totalpoints; }
            }

            public int AddPoints(decimal transactionValue)
            {
                int points = Decimal.ToInt32(transactionValue);
                totalPoints += points;
                return totalPoints;
            }
            public void ResetPoints()
            {
                totalPoints = 0;
            }
        }
        // details of implementation do not matter to calling classes

        // interfaces aid code modularization
        // one can change the way in which a class implements the interface a any point without having to
        // update any dependent consomer classes that rely on the interface implementation'



        // implicit and explicit implementation

// o implement an interface implicitly, you implement each interface member with a signature that matches 
// the member definition in the interface. To implement an interface
//  explicitly, you fully qualify each member name so that it is clear that the member belongs to a particular interface.


// The only scenario in which you must use explicit interface implementation is if you are implementing two
//  interfaces that share a member name. For example, if you implement interfaces named
//  IBeverage and IInventoryItem, and both interfaces declare a Boolean property named IsAvailable, 
// you would need to implement at least one of the IsAvailable members explicitly. In this scenario,
//  the compiler would be unable to resolve the IsAvailable reference without an explicit implementation
        // Implementing an Interface Explicitly
        public class Coffee : IBeverage
        {
            private int servingTempWithoutMilk { get; set; }
            private int servingTempWithMilk { get; set; }
            public int IBeverage.GetServingTemperature(bool includesMilk)
            {
                if (includesMilk)
                {
                    return servingTempWithMilk;
                }
                else
                {
                    return servingTempWithoutMilk;
                }
            }
            public bool IBeverage.IsFairTrade { get; set; }
            // Other non-interface members.
        }


    // INTERFACE POLYMORPHISM

//     For example, if the Coffee class implements the IBeverage interface, you can represent a new Coffee object as an instance of Coffee or an instance of IBeverage:

// // Representing an Object as an Interface Type
// Coffee coffee1 = new Coffee();
// IBeverage coffee2 = new Coffee();
// You can use an implicit cast to convert to an interface type, because you know that the class must include all the interface members.

// // Casting to an Interface Type
// IBeverage beverage = coffee1;
// You must use an explicit cast to convert from an interface type to a derived class type, as the class may include members that are not defined in the interface.

// // Casting an Interface Type to a Derived Class Type
// Coffee coffee3 = beverage as Coffee;
// // OR
// Coffee coffee4 = (Coffee)beverage;
// Implementing Multiple Interfaces
// In many cases, you will want to create classes that implement more than one interface. For example, you might want to:

// Implement the IDisposable interface to enable the .NET runtime to dispose of your class correctly.
// Implement the IComparable interface to enable collection classes to sort instances of your class.
// Implement your own custom interface to define the functionality of your class.
// To implement multiple interfaces, you add a comma-separated list of the interfaces that you want to implement to your class declaration. Your class must implement every member of every interface you add to your class declaration. The following example shows how to create a class that implements multiple interfaces:

// // Declaring a Class that Implements Multiple Interfaces
// public class Coffee: IBeverage, IInventoryItem
// {
// }

        static void Main(string[] args)
        {
        }
    }
}
