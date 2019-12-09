using System;
using System.Collections;

namespace Lab {
    class Program {
        static void Main (string[] args) {

            ArrayList myArrList = new ArrayList ();
            myArrList.Add ("First Item");
            myArrList.Add (3);
            myArrList.Add (4.5);

            foreach (object obj in myArrList) {
                Console.WriteLine (obj.ToString ());
            }

        }
    }
}
