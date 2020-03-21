using System;
using System.Collections.Generic;
using System.IO;

namespace VogtPayroll5
{
    class Program
    {
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();

            Run();
        }

        public static void Run()
        {
            PayrollConsoleReader payrollConsoleReader = new PayrollConsoleReader();
            Payroll payroll = new Payroll();
            bool run = false;
            Employee emp = default;
            List<Employee> empList = new List<Employee>();

            do
            {
                Console.Clear();
                emp = payrollConsoleReader.GetEmployeeInfo();
                run = payrollConsoleReader.ReadTrueOrFalseFromConsole();

                empList.Add(emp);
                payroll.AddEmployees(empList);
            } while (run == true);

            payroll.LoopThroughEmployeeInfo(emp.CalculateGrossPay());

            payroll.DisplayTotalEmployeesHoursWorkedAndGrossPay();

            //FileSystem.WriteEmployeeListTotalsAndCountToFile(empList);

            //File.Copy(@"C:\Users\Gabriel\source\repos\VogtPayroll5\EmployeeList.txt", @"C:\Users\Gabriel\source\repos\VogtPayroll5\EmployeeListBackup.txt");
        }

    }
}
