using System;
using System.Collections;
using System.Collections.Generic;

namespace SALab {

    public class Student {

        int id;
        int admNo;
        int age;

        public static void _student () {
            ArrayList _studentList = new ArrayList ();

            _studentList.Add ("_one");
            _studentList.Add ("_two");
            _studentList.Add ("_three");

            Console.WriteLine ("Count : " + _studentList.Count);
            Console.WriteLine ("Capacity : " + _studentList.Capacity);

            Stack _studentStack = new Stack ();
            _studentStack.Push (1);
            _studentStack.Push (2);
            _studentStack.Push (3);
            _studentStack.Push (4);
            _studentStack.Push (5);

            foreach (var item in _studentStack) {
                Console.WriteLine (item);
            }

        }

    }
    class Program {
        static void Main (string[] args) {

            Student._student ();
        }
    }
}