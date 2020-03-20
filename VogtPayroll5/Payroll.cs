using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll5
{
    class Payroll
    {
        //total number of hours worked by all employees, and total gross pay as well
        private static int countHours;
        private static decimal totalGrossPay;

        private List<Employee> _empList = new List<Employee>();

        public void Run()
        {
            PayrollConsoleReader payrollConsoleReader = new PayrollConsoleReader();
            Employee emp = new Employee();
            bool run = false;

            do
            {
                Console.Clear();
                emp = payrollConsoleReader.GetEmployeeInfo();
                run = payrollConsoleReader.ReturnTrueOrFalse();

                _empList.Add(emp);
            } while (run == true);

            LoopThroughEmployeeInfo(emp.CalculateGrossPay(emp.HoursWorked, emp.HourlyPayRate));

            DisplayTotalEmployeesHoursWorkedAndGrossPay();
        }

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

                employee.DisplayPayStatement(employee.EmpID, employee.EmpName, employee.HoursWorked, employee.HourlyPayRate, grossPay);

                countHours += employee.HoursWorked;
                totalGrossPay += grossPay;

            }
        }
    }
}
