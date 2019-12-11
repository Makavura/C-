using System;

namespace SALAB01 {

    public class Student {

        public string Name { get; set; }
        public string admNo { get; set; }

        public Student(string name, string admno)
        {
            Name = name;
            admNo = admno;
        }
    }

    public class Teacher {
        public string Name { get; set; }
        public string TSCNo { get; set; }

        public Student(string name, string tscno)
        {
            Name = name;
            TSCNo = tscno;
        }
    }

    public class UProgram {


    }

    public class Degree {

    }

    public class Course {

    }

    class Program {
        static void Main (string[] args) {

        }
    }
}