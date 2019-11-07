using System;

namespace mod_tut_lab_one_inheritance
{
    class Program
    {
//          practice using inheritance to relate classes to one another. As a developer, being able to decide
//  which classes should extend, implement, or abstract particular pieces of code will maximize your code sharing.

// We will be creating a company structure, consisting of the following classes: employee, business employee, 
// and technical employee. The BusinessEmployee() and TechnicalEmployee() Classes will inherit from the Employee() Class.
//  The following is a table that explains each of the classes and their respective methods more in depth.

// EMPLOYEE
// Method header	Description
// public Employee(String name, double baseSalary)	Should construct a new employee object and take in two parameters, 
// one for the name of the user and one for their base salary
// public double getBaseSalary()	Should return the employee's current salary
// public String getName()	Should return the employee's current name
// public int getEmployeeID()	Should return the employee's ID. The ID should be issued on behalf of the employee at 
// the time they are constructed. The first ever employee should have an ID of "1", the second "2" and so on
// public String toString()	Should return a String representation of the employee that is a combination of their id 
// followed by their name. Example: "1 Kasey"
// public virtual String employeeStatus()	Should return a String representation of that Employee's current status and
//  state that they are in the company system. Example: "1 Kasey is in the company's system" Keep in mind that this method
//  will be different for each sub class of employee.
// TECHNICAL EMPLOYEE
// Method header	Description
// public TechnicalEmployee(String name)	Has a default base salary of 75000
// public override String employeeStatus()	Should return a String representation of this TechnicalEmployee that includes
//  their ID, name and how many successful check ins they have had. Example: "1 Kasey has 10 successful check ins"
// BUSINESS EMPLOYEE
// Method header	Description
// public BusinessEmployee(String name)	Has a default salary of 50000
// public override String employeeStatus()	Should return a String representation of this BusinessEmployee that includes their ID
// , name and the size of their currently managed budget. Example: "1 Kasey with a budget of 22500.0"

    public class Employee
    {
        private string employeeName;
        private double employeeBaseSalary;
        public int employeeId;


        public string name
        {
            get{
                return employeeName;
            }
            set{
                employeeName = value;
            }
        }
        public double baseSalary
        {
            get{
                return employeeBaseSalary;
            }
            set 
            {
                employeeBaseSalary = value;
            }
        }
        public int ID
        {
            get{
                return employeeId;
            }
            set{
                employeeId = value;
            }
        }
        private static int employeeCount = 1;

        public Employee(String name, double baseSalary, int ID)
        {
            this.Name = name;
            this.BaseSalary = baseSalary;
            this.ID = employeeCount++;
        }

        public double getBaseSalary()
        {
            return this.BaseSalary;
        }
        public string getName()
        {
            return this.Name;
        }
        public int getEmployeeID()
        {
            return this.ID;
        }
        // method also states that "this method will be different for
        //  each sub class of employee," meaning that this method will be overridden within sub classes.
        public virtual String toString()
        {
            return this.ID + " " + this.Name;
        }
    }

        static void Main(string[] args)
        {

        }
    }
}
