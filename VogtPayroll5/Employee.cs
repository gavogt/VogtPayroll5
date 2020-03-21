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


        public void DisplayPayStatement(int empID, string empName, int hoursWorked, decimal hourlyPayRate, decimal grossPay)
        {
            Console.WriteLine($"Employee ID: {empID}");
            Console.WriteLine($"Employee name: {empName}");
            Console.WriteLine($"Employee hours worked: {hoursWorked}");
            Console.WriteLine($"Employee hourly payrate: {hourlyPayRate:C2}");
            Console.WriteLine($"Employee gross pay: {CalculateGrossPay():C2}");
        }
    }
}
