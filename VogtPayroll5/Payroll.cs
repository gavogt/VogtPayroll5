using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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

            WriteEmployeeListTotalsAndCountToFile(_empList);
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

        public void WriteEmployeeListTotalsAndCountToFile(List<Employee> empList)
        {
            //write all employee's pay statement and the final payroll summary into a text file
            StreamWriter st = File.AppendText(@"C:\Users\Gabriel\source\repos\VogtPayroll5\EmployeeList.txt");


            foreach (var employee in empList)
            {
                Console.WriteLine(" ");
                st.WriteLine($"Employee ID: {employee.EmpID}");
                st.WriteLine($"Employee name: {employee.EmpName}");
                st.WriteLine($"Employee hours worked: {employee.HoursWorked}");
                st.WriteLine($"Employee hourly payrate: {employee.HourlyPayRate:C2}");
                st.WriteLine($"Employee gross pay: {employee.CalculateGrossPay(employee.HoursWorked, employee.HourlyPayRate):C2}");

            }

            st.WriteLine();
            st.WriteLine($"Employee count: {_empList.Count}");
            st.WriteLine($"Employee total of hours worked {countHours}");
            st.WriteLine($"Employee total of gross pay {totalGrossPay:C2}");

            st.Close();

        }
    }
}
