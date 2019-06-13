using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2_Classes
    //Name: Anya Webb
    //Student ID: 9946386
{
    class Program //Payroll System to get employees details and calculate net salary.
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Rotorua Thermal Holiday Park"); //Introduction
            Console.WriteLine("-------Payroll System-------\n");

            Employee employee1 = new Employee(); //New employee created
            Console.WriteLine("Please enter employee details below\n");
            Console.Write("Employee name: "); //Asking user to enter details
            employee1.EmployeeName = Console.ReadLine(); //Assigning the name to the employee.1 class
            Console.Write("Gross salary: ");
            employee1.Salary = double.Parse(Console.ReadLine()); //Assigning the salary to the employee.1 class
            Console.Write("Tax rate: ");
            employee1.Tax = double.Parse(Console.ReadLine()); //Assigning the tax rate to the employee.1 class
            Console.Clear(); //Clearing the screen

            Console.WriteLine("Rotorua Thermal Holiday Park"); //Re-entering introduction to make it look pretty
            Console.WriteLine("-------Payroll System-------\n");
            Console.WriteLine("Details entered into Payroll System:"); //Displaying details back to the employee
            Console.WriteLine($"Employee: {employee1.EmployeeName}"); 
            Console.WriteLine($"Gross Salary: ${employee1.Salary}");
            Console.WriteLine($"Tax rate: {employee1.Tax}%");
            Console.WriteLine($"Net Salary: ${employee1.CalcNet()}"); //Calling the method to calculate the net salary

            Console.WriteLine("\n--------------Thank you---------------");
            Console.WriteLine("Please press enter to exit the program");
            Console.ReadLine();
        }
    }

    class Employee //Employee class
    {
        //Attributes
        static string employeeName;
        static double grossSalary;
        static double tax;

        //Getters and setters
        public string EmployeeName { get { return employeeName; } set { employeeName = value; } }
        public double Salary { get { return grossSalary; } set { grossSalary = value; } }
        public double Tax { get { return tax; } set { tax = value; } }

        //Method to calculate the net salary using the gross salary and tax amount entered by user
        public double CalcNet()
        {
            return Math.Round(grossSalary * (1 - tax /100) ,2); //Using Math.Round to round the number to 2 decimal places             
        }

        //Constructor
        public Employee()
        {
            Console.WriteLine("Employee record created\n"); //Message to show when new employee is created         
        }


        
        
    }
        
}
