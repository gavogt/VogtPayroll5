using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll5
{
    class PayrollConsoleReader
    {
        #region GetEmployeeInfo
        /// <summary>
        /// Gets employee info
        /// </summary>
        /// <returns>An employee</returns>
        public Employee GetEmployeeInfo()
        {

            Console.WriteLine("What is employee's ID?");
            var empID = int.Parse(Console.ReadLine());

            Console.WriteLine("What is employee's name?");
            var empName = Console.ReadLine();

            Console.WriteLine("What is the number of hours the employee worked?");
            var hoursWorked = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the payrate of the employee?");
            var hourlyPayRate = decimal.Parse(Console.ReadLine());

            return new Employee(empID, empName, hoursWorked, hourlyPayRate);

        }
        #endregion

        #region ReadTrueOrFalseFromConsole
        /// <summary>
        /// Read true or false from console for input loop
        /// </summary>
        /// <returns>True or False</returns>
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
        #endregion
    }
}
