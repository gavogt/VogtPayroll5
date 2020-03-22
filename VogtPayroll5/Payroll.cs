using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace VogtPayroll5
{
    class Payroll
    {
        private List<Employee> _empList = new List<Employee>();

        #region DisplayTotalEmployeesHoursWorkedAndGrossPay
        /// <summary>
        /// Display list count, total hours worked and total gross pay
        /// </summary>
        public void DisplayTotalEmployeesHoursWorkedAndGrossPay()
        {
            Console.WriteLine();
            Console.WriteLine($"Employee count: {_empList.Count}");
            Console.WriteLine($"Employee total of hours worked {GetTotalHoursWorked()}");
            Console.WriteLine($"Employee total of gross pay {GetTotalGrossPay():C2}");

        }
        #endregion

        #region LoopThroughEmployeeInfo
        /// <summary>
        /// Loops through employee info
        /// </summary>
        /// <param name="grossPay">gross pay to pass in</param>
        public void LoopThroughEmployeeInfo()
        {
            Console.Clear();
            foreach (var employee in _empList)
            {
                Console.WriteLine();

                employee.DisplayPayStatement();

            }
        }
        #endregion

        #region AddEmployees
        /// <summary>
        /// Add employees from list to a private list
        /// </summary>
        /// <param name="employees">Employee list to pass in</param>
        public void AddEmployees(List<Employee> employees)
        {
            _empList.AddRange(employees);
        }
        #endregion

        #region GetTotalHoursWorked
        /// <summary>
        /// Gets total hours worked
        /// </summary>
        /// <returns>Total hours worked</returns>
        public int GetTotalHoursWorked()
        {
            var totalHoursWorked = 0;
            foreach (var employee in _empList)
            {
                totalHoursWorked += employee.HoursWorked;
            }
            
            return totalHoursWorked;

        }
        #endregion

        #region GetTotalGrossPay
        /// <summary>
        /// Gets total gross pay
        /// </summary>
        /// <returns>Total gross pay</returns>
        public decimal GetTotalGrossPay()
        {
            var grossPay = 0.0m;
            foreach (var employee in _empList)
            {
                grossPay += employee.CalculateGrossPay();
            }

            return grossPay;

        }
        #endregion 
    }
}
