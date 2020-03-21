using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VogtPayroll5
{
    class FileSystem
    {
        public static void WriteEmployeeListTotalsAndCountToFile(List<Employee> empList)
        {
            //write all employee's pay statement and the final payroll summary into a text file
            StreamWriter st = File.AppendText(@"C:\Users\Gabriel\source\repos\VogtPayroll5\EmployeeList.txt");
            Payroll payroll = new Payroll();

            foreach (var employee in empList)
            {
                Console.WriteLine(" ");
                st.WriteLine($"Employee ID: {employee.EmpID}");
                st.WriteLine($"Employee name: {employee.EmpName}");
                st.WriteLine($"Employee hours worked: {employee.HoursWorked}");
                st.WriteLine($"Employee hourly payrate: {employee.HourlyPayRate:C2}");
                st.WriteLine($"Employee gross pay: {employee.CalculateGrossPay():C2}");

            }

            st.WriteLine();
            st.WriteLine($"Employee count: {empList.Count}");
            st.WriteLine($"Employee total of hours worked {payroll.GetTotalHoursWorked()}");
            st.WriteLine($"Employee total of gross pay {Payroll.totalGrossPay:C2}");

            st.Close();

        }
    }
}
