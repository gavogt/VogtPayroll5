using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll5
{
    class Employee
    {
        public int EmpID { get; }
        public string EmpName { get; }

        public int HoursWorked { get;}

        public decimal HourlyPayRate { get; }

        public Employee(int empID, string empName, int hoursWorked, decimal hourlyPayRate)
        {
            EmpID = empID;
            EmpName = empName;
            HoursWorked = hoursWorked;
            HourlyPayRate = hourlyPayRate;
        }

        #region CalculateGrossPay
        /// <summary>
        /// Calculates gross pay
        /// </summary>
        /// <returns>Gross pay</returns>
        public decimal CalculateGrossPay()
        {

            if (HoursWorked > 40)
            {
                int baseHours = 40;

                return HourlyPayRate * 40 + ((1.5m * HourlyPayRate)*(HoursWorked-baseHours));
            }
            else
            {
                return HoursWorked * HourlyPayRate;
            }
        }
        #endregion

        #region DisplayPayStatement
        /// <summary>
        /// Displays employee pay information
        /// </summary>
        public void DisplayPayStatement()
        {
            Console.WriteLine($"Employee ID: {EmpID}");
            Console.WriteLine($"Employee name: {EmpName}");
            Console.WriteLine($"Employee hours worked: {HoursWorked}");
            Console.WriteLine($"Employee hourly payrate: {HourlyPayRate:C2}");
            Console.WriteLine($"Employee gross pay: {CalculateGrossPay():C2}");
        }
        #endregion
    }
}
