using System;

namespace Lab {

    public struct Student {

        public int grade;
        public int AdmNo;

        public void Study () {
            Console.WriteLine ("Read");
        }

    }

    public struct Teacher {

        public int isHOD;
        public int TSCNO;

        public void gradeAssignments () {
            Console.WriteLine ("Do not be a sadist, mwalimu");
        }
    }
    class Program {

        static void Main (string[] args) {

            int _students[] = {

                _student = new
            }

        }
    }

    class arrayS {
        public void manualArrayWork () {
            int[] numbers = new int[5];

            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;

            Console.WriteLine (numbers[0]);
            Console.WriteLine (numbers[3]);
            Console.WriteLine (numbers[2]);

            int total = 0;
            for (int i = 0; i < numbers.Length; i++) {
                total = total + numbers[i];
            }
            Console.WriteLine (total.ToString ());

            int forEachTotal = 0;
            foreach (int num in numbers) {
                forEachTotal = forEachTotal + num;
            }
            Console.WriteLine (forEachTotal);
        }
    }
