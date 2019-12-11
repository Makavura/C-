using System;
using System.Collections.Generic;

namespace SALAB01 {

    public class Student {

        public string Name { get; set; }
        public string admNo { get; set; }

        public Student (string name, string admno) {
            Name = name;
            admNo = admno;
        }
    }

    public class Teacher {
        public string Name { get; set; }
        public string TSCNo { get; set; }

        public Teacher (string name, string tscno) {
            Name = name;
            TSCNo = tscno;
        }
    }

    public class UProgram {
        public string UName { get; set; }
        public string Uabbrv { get; set; }

        public UProgram (string uname, string uabbrv) {
            UName = uname;
            Uabbrv = uabbrv;
        }

        public class Degree {
            public string DName { get; set; }
            public string DCode { get; set; }

            public Degree (string dname, string dcode) {
                DName = dname;
                DCode = dcode;
            }

            public class Course {
                public string CName { get; set; }
                public string CCode { get; set; }

                public List<Teacher> _courseTeachers = new List<Teacher> ();

                public List<Teacher> addTeacherToCourse (string tName, string tNo) {

                    Teacher teacherToAddToCourse = new Teacher (tName, tNo);
                    _courseTeachers.Add (teacherToAddToCourse);

                    foreach (Teacher aMwalimu in _courseTeachers) {
                        Console.WriteLine (aMwalimu);
                    }

                    return _courseTeachers;
                }

                public Course (string cname, string ccode) {
                    CName = cname;
                    CCode = ccode;
                }
            }

        }

    }

    class Program {
        static void Main (string[] args) {
            Student _studenti = new Student ("Marcus Hopsin", "FV007");
            Console.WriteLine ("Student Name = {0} Number = {1}", _studenti.Name, _studenti.admNo);

            Student _studentii = new Student ("Kendrick Lamar", "TDE");
            Console.WriteLine ("Student Name = {0} Number = {1}", _studentii.Name, _studentii.admNo);

            Student _studentiii = new Student ("Logic", "DefJam");
            Console.WriteLine ("Student Name = {0} Number = {1}", _studentiii.Name, _studentiii.admNo);

            Teacher _teacheri = new Teacher ("Shady", "SR");
            Console.WriteLine ("Teacher = {0} TSCNUMBER = {1}", _teacheri.Name, _teacheri.TSCNo);

            var _CourseIinstance = new UProgram.Degree.Course ("Rap", "Flow101");
            var _CourseIIinstance = new UProgram.Degree.Course ("Programming with C#", "C#101");

            Console.WriteLine(ToString(_CourseIinstance), ToString(_CourseIIinstance));

        }
    }
}