using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll5
{
    class Employee
    {
        public int EmpID { get; set; }
        public string EmpName { get; set; }

        public int HoursWorked { get; set; }

        public decimal HourlyPayRate { get; set; }

        public decimal CalculateGrossPay(int hours, decimal rate)
        {

            if (hours > 40)
            {

                return hours * (rate * 1.5m);
            }
            else
            {
                return hours * rate;
            }
        }

        public decimal CalculateOvertimePay(int hours, decimal rate)
        {
            int baseHours = 40;

            if (hours >= 40)
                hours = hours - baseHours;
            else
                return 0;

            return hours * rate;
        }

        public void DisplayPayStatement(int empID, string empName, int hoursWorked, decimal hourlyPayRate, decimal grossPay)
        {
            Console.WriteLine($"Employee ID: {empID}");
            Console.WriteLine($"Employee name: {empName}");
            Console.WriteLine($"Employee hours worked: {hoursWorked}");
            Console.WriteLine($"Employee hourly payrate: {hourlyPayRate:C2}");
            Console.WriteLine($"Employee gross pay: {CalculateGrossPay(hoursWorked, hourlyPayRate) + CalculateOvertimePay(hoursWorked, hourlyPayRate):C2}");
        }
    }
}
