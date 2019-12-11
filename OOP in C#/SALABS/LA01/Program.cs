﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace LA01 {
    // In the Main() method of Program.cs
    // Instantiate a UProgram object called Information Technology.
    // Instantiate three Student objects.
    // Instantiate a Course object called Programming with C#.
    // Add your three students to this Course object.
    // Instantiate at least one Teacher object.
    // Add that Teacher object to your Course object.
    // Instantiate a Degree object, such as Bachelor.
    // Add your Course object to the Degree object.
    // Instantiate a UProgram object called Information Technology.
    // Add the Degree object to the UProgram object.
    // Using Console.WriteLine statements, output the following information to the console window:
    // The name of the program and the degree it contains
    // The name of the course in the degree
    // The count of the number of students in the course.

    class Program {
        #region enum
        public enum SchoolStatus {
            Student,
            Teacher,
            Other
        }

        #endregion

        #region interface

        public interface INameable {
            string Name { get; }
        }

        #endregion

        #region abstract

        public abstract class ANameable : INameable {
            public string Name { get; protected set; }

            protected ANameable (string name) {
                Name = name;
            }

            public override string ToString () {
                return Name;
            }
        }

        public abstract class APerson : ANameable {
            public string FirstName { get; protected set; }
            public string LastName { get; protected set; }
            public DateTime Birthdate { get; set; }
            public abstract SchoolStatus SchoolStatus { get; }

            protected APerson (string firstName, string lastName, DateTime birthdate) : base (firstName + " " + lastName) {
                FirstName = firstName;
                LastName = lastName;
                Birthdate = birthdate;
            }
        }

        #endregion

        #region class

        public class UProgram : ANameable {
            public Degree Degree { get; set; }

            public UProgram (string name) : base (name) { }

            public override string ToString () {
                return "The " + Name +
                    " program contains the " +
                    Degree.Name + " degree";
            }
        }

        public class Degree : ANameable {
            public Course Course { get; set; }

            public Degree (string name) : base (name) { }

            public override string ToString () {
                return "The " + Name +
                    " degree contains the course " +
                    Course.Name;
            }
        }

        //Modify your code to use the ArrayList collection as the replacement to the array.
        public class Students : ArrayList {
            //In other words, when you add a Student to the Course object, you will add it to the ArrayList and not an array.
            public override int Add (object value) {
                if (value is Student)
                    return base.Add (value);
                throw new InvalidOperationException ();
            }
        }

        public class Course : ANameable {
            //Delete the Student array in your Course object that you created in Module 5.
            //Create an ArrayList to replace the array and to hold students, inside the Course object.
            public Students Students { get; set; }

            private IEnumerable<Teacher> _teachers;
            public IEnumerable<Teacher> Teachers {
                get { return _teachers; }
                set {
                    if (!value.Any ())
                        throw new Exception ("Instantiate at least one Teacher object.");
                    _teachers = value;
                }
            }

            public Course (string name) : base (name) { }

            //Create a method inside the Course object called ListStudents() that contains the foreach loop.
            public void ListStudents () {
                //Using a foreach loop, iterate over the Students in the ArrayList and output their first and last names to the console window.
                //(For this exercise you MUST cast the returned object from the ArrayList to a Student object.  Also, place each student name on its own line)
                foreach (var student in Students.OfType<Student> ())
                    Console.WriteLine (student.ToString ());
            }

            public override string ToString () {
                return "The " + Name +
                    " course contains " + Students.Count +
                    " student<s>";
            }
        }

        public class Grade : ANameable {
            public int Score { get; private set; }

            public Grade (string name, int score) : base (name) {
                Score = score;
            }
        }

        public class Student : APerson {
            public override SchoolStatus SchoolStatus { get { return SchoolStatus.Student; } }

            //Create a Stack object inside the Student object, called Grades, to store test scores.
            public Stack<Grade> Grades { get; set; }

            public Student (string firstName, string lastName, DateTime birthdate) : base (firstName, lastName, birthdate) {
                Grades = new Stack<Grade> ();
            }

            public void TakeTest () {
                Console.WriteLine ("Student takes the test.");
            }
        }

        public class Teacher : APerson {
            public override SchoolStatus SchoolStatus { get { return SchoolStatus.Teacher; } }

            public Teacher (string firstName, string lastName, DateTime birthdate) : base (firstName, lastName, birthdate) { }

            public void GradeTest () {
                Console.WriteLine ("Teacher grades the test.");
            }
        }

        #endregion

        private static void Main () {
            try {
                //Create 3 student objects.
                var students = new Students {
                    new Student ("Harry", "Potter", new DateTime (1980, 7, 31)),
                    new Student ("Ron", "Weasley", new DateTime (1980, 3, 1)),
                    new Student ("Hermione", "Granger", new DateTime (1979, 9, 19))
                };

                //Add 5 grades to the the Stack in the each Student object.
                //This does not have to be inside the constructor because you may not have grades for a student when you create a new student.
                foreach (var obj in students)
                    for (var i = 0; i < 5; i++) {
                        var student = obj as Student;
                        if (student != null)
                            student.Grades.Push (new Grade ("Magic", 1));
                    }

                var uProgram = new UProgram ("Information Technology") {
                    Degree = new Degree ("Bachelor") {
                    Course = new Course ("Programming with C#") {
                    //Add the three Student objects to the Students ArrayList inside the Course object.
                    Students = students,
                    Teachers = new Collection<Teacher> { new Teacher ("Remus", "Lupin", new DateTime (1960, 3, 10)) }
                    }
                    }
                };

                //Call the ListStudents() method from Main().
                uProgram.Degree.Course.ListStudents ();

            } catch (Exception ex) {
                Console.WriteLine (ex.Message);
            } finally {
                Console.WriteLine ("Press any key to continue ...");
                Console.ReadLine ();
            }
        }
    }
}