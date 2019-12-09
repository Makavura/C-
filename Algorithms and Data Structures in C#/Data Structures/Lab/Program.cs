using System;

namespace Lab {

    public struct Student {

        // public Student(int grade, int AdmNo);

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

            Student[] arr = new Student[5];

            arr[0].grade = 5;
            arr[0].AdmNo = 7717;

            Console.WriteLine (arr[0].grade);
                        Console.WriteLine (arr[0].AdmNo);

arr[0].Study();

            for (int i = 0; i < 5; i++) {
                Console.WriteLine ("FIRST LOOP");
                string _grade;
                _grade = Console.ReadLine ();
                arr[i].grade = System.Convert.ToInt32 (_grade);
                string _AdmNo;
                _AdmNo = Console.ReadLine ();
                arr[i].AdmNo = System.Convert.ToInt32 (_AdmNo);

            }

Console.WriteLine("NEXT LOOP");
            for (int _i = 0; _i < 5; _i++) {
                Console.WriteLine ("SECOND LOOP");
                // arr[_i].AdmNo = int.parse(Console.ReadLine());
                // arr[_i].grade = Console.ReadLine();
                Console.WriteLine (arr[_i].grade);
                Console.WriteLine (arr[_i].AdmNo);
            }
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
