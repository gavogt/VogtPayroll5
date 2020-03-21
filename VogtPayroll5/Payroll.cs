using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VogtPayroll5
{
    class Payroll
    {
        //total number of hours worked by all employees, and total gross pay as well
        public int countHours;
        public static decimal totalGrossPay;

        private List<Employee> _empList = new List<Employee>();


        public void DisplayTotalEmployeesHoursWorkedAndGrossPay()
        {
            Console.WriteLine();
            Console.WriteLine($"Employee count: {_empList.Count}");
            Console.WriteLine($"Employee total of hours worked {countHours}");
            Console.WriteLine($"Employee total of gross pay {totalGrossPay:C2}");

        }

        public void LoopThroughEmployeeInfo(decimal grossPay)
        {
            Console.Clear();
            foreach (var employee in _empList)
            {
                Console.WriteLine();

                employee.DisplayPayStatement();

                countHours += employee.HoursWorked;
                totalGrossPay += grossPay;

            }
        }

        public void AddEmployees(List<Employee> employees)
        {
            _empList.AddRange(employees);
        }

        public int GetTotalHoursWorked()
        {
            var totalHoursWorked = 0;
            foreach (var employee in _empList)
            {
                totalHoursWorked += employee.HoursWorked;
            }
            return totalHoursWorked;

        }
    }
}
