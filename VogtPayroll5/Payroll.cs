using System;
using System.Collections.Generic;
using System.Text;

namespace VogtPayroll5
{
    class Payroll
    {
        private List<Employee> _empList = new List<Employee>();
        public void Run()
        {
            List<Employee> empList = new List<Employee>();
            PayrollConsoleReader payrollConsoleReader = new PayrollConsoleReader();
            Employee emp = new Employee();
            bool run = false;

            do
            {
                emp = payrollConsoleReader.GetEmployeeInfo();
                _empList.Add(emp);
            } while (run == true);

            LoopThroughEmployeeInfo(emp.CalculateGrossPay(emp.HoursWorked, emp.HourlyPayRate));
        }

        public void LoopThroughEmployeeInfo(decimal grossPay)
        {
            foreach (var employee in _empList)
            {
                employee.DisplayPayStatement(employee.EmpID, employee.EmpName, employee.HoursWorked, employee.HourlyPayRate, grossPay);
            }
        }
    }
}
