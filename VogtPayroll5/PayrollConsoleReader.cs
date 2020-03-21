using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll5
{
    class PayrollConsoleReader
    {
        public Employee GetEmployeeInfo()
        {
            int empID;
            string empName;
            int hoursWorked;
            decimal hourlyPayRate;


            Console.WriteLine("What is employee's ID?");
            empID = int.Parse(Console.ReadLine());

            Console.WriteLine("What is employee's name?");
            empName = Console.ReadLine();

            Console.WriteLine("What is the number of hours the employee worked?");
            hoursWorked = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the payrate of the employee?");
            hourlyPayRate = decimal.Parse(Console.ReadLine());

            return new Employee(empID, empName, hoursWorked, hourlyPayRate);
        }

        public bool ReadTrueOrFalseFromConsole()
        {

            Console.WriteLine("Would you like to add another employee? y/n");
            var temp = Console.ReadLine().ToLower();

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

                Console.WriteLine("Please enter 'y' or 'n'!");
                temp = Console.ReadLine().ToLower();

            } while (temp != "y" || temp == "n");

            return true;
        }
    }
}
