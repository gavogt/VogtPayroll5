using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll5
{
    class PayrollConsoleReader
    {
        public Employee GetEmployeeInfo()
        {
            Employee emp = new Employee();

            Console.WriteLine("What is employee's ID?");
            emp.EmpID = int.Parse(Console.ReadLine());

            Console.WriteLine("What is employee's name?");
            emp.EmpName = Console.ReadLine();

            Console.WriteLine("What is the number of hours the employee worked?");
            emp.HoursWorked = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the payrate of the employee?");
            emp.HourlyPayRate = decimal.Parse(Console.ReadLine());

            return emp;
        }

        public bool ReturnTrueOrFalse()
        {
            string temp;
            Console.WriteLine("Would you like to add another employee? y/n");
            temp = Console.ReadLine().ToLower();

            do
            {
                if (temp == "y")
                {
                    return true;
                }
                else if (temp == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Please enter 'y' or 'n'!");
                    temp = Console.ReadLine().ToLower();
                }
            } while (temp != "y" || temp == "n");

            return true;
        }
    }
}
