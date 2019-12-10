using System;
using System.Collections;
using System.Collections.Generic;

namespace Generics {

    class BasicCollection<T> : IEnumerable<T> {
        private List<T> data = new List<T> ();
        public void FillList (params T[] items) {
            foreach (var datum in items)
                data.Add (datum);
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator () {
            foreach (var datum in data) {
                yield return datum;
            }
        }
        IEnumerator IEnumerable.GetEnumerator () {
            throw new NotImplementedException ();
        }
    }

    // The following example shows a custom collection class that implements a default enumerator, together with an alternative enumerator 
    // that enumerates the collection in reverse order:

    // Default and Alternative Enumerators
    // class CustomCollection<T> : IEnumerable<T> {
    //     public IEnumerator<T> Backwards () {
    //         // This method returns an alternative enumerator.
    //         // The implementation details are not shown.
    //     }
    //     #region IEnumerable<T> Members
    //     public IEnumerator<T> GetEnumerator () {
    //         // This method returns the default enumerator.
    //         // The implementation details are not shown.
    //     }
    //     #endregion
    //     #region IEnumerable Members
    //     IEnumerator IEnumerable.GetEnumerator () {
    //         // This method is required because IEnumerable<T> inherits from IEnumerable
    //         throw new NotImplementedException ();
    //     }
    //     #endregion
    // }

    class Program {

        static void Main (string[] args) {

            // Using the List<T> Class
            string s1 = "Latte";
            string s2 = "Espresso";
            string s3 = "Americano";
            string s4 = "Cappuccino";
            string s5 = "Mocha";
            // Add the items to a strongly-typed collection.
            var coffeeBeverages = new List<String> ();
            coffeeBeverages.Add (s1);
            coffeeBeverages.Add (s2);
            coffeeBeverages.Add (s3);
            coffeeBeverages.Add (s4);
            coffeeBeverages.Add (s5);
            // Sort the items using the default comparer. 
            // For objects of type String, the default comparer sorts the items alphabetically.
            coffeeBeverages.Sort ();
            // Write the collection to a console window.
            foreach (String coffeeBeverage in coffeeBeverages) {
                Console.WriteLine (coffeeBeverage);
            }

            // Using the Dictionary<TKey, TValue> Class
            // Create a new dictionary of strings with string keys.
            var coffeeCodes = new Dictionary<String, String> ();
            // Add some entries to the dictionary.
            coffeeCodes.Add ("CAL", "Café Au Lait");
            coffeeCodes.Add ("CSM", "Cinammon Spice Mocha");
            coffeeCodes.Add ("ER", "Espresso Romano");
            coffeeCodes.Add ("RM", "Raspberry Mocha");
            coffeeCodes.Add ("IC", "Iced Coffee");
            // This statement would result in an ArgumentException because the key already exists.
            // coffeeCodes.Add("IC", "Instant Coffee");
            // To retrieve the value associated with a key, you can use the indexer.
            // This will throw a KeyNotFoundException if the key does not exist.
            Console.WriteLine ("The value associated with the key \"CAL\" is {0}", coffeeCodes["CAL"]);
            // Alternatively, you can use the TryGetValue method.
            // This returns true if the key exists and false if the key does not exist.
            string csmValue = "";
            if (coffeeCodes.TryGetValue ("CSM", out csmValue)) {
                Console.WriteLine ("The value associated with the key \"CSM\" is {0}", csmValue);
            } else {
                Console.WriteLine ("The key \"CSM\" was not found");
            }
            // You can also use the indexer to change the value associated with a key.
            coffeeCodes["IC"] = "Instant Coffee";

            // The following example shows how you can use a default enumerator or an alternative enumerator to iterate through a collection:

            // Enumerating a Collection
            // CustomCollection<Int32> numbers = new CustomCollection<Int32> ();
            // Add some items to the collection.
            // Use the default enumerator to iterate through the collection:
            // foreach (int number in numbers) {
                // …
            // }
            // Use the alternative enumerator to iterate through the collection:
            // foreach (int number in numbers.Backwards ()) {
                // …
            // }
        }

    }
}