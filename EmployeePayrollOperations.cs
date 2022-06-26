using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRollThreading
{
    public class EmployeePayrollOperations
    {
        List<EmployeeDetails> employeePayrollDetailList= new List<EmployeeDetails>();
        //UC1
        public void addEmployeeToPayroll(List<EmployeeDetails> employeePayrollDataList)
        {
            employeePayrollDataList.ForEach(employeeData =>
            {
                Console.WriteLine("Employee being added: " + employeeData.EmployeeName);
                this.addEmployeePayroll(employeeData);
                Console.WriteLine("Employee added: " + employeeData.EmployeeName);

            });
            Console.WriteLine(this.employeePayrollDetailList.ToString());
        }
        public void addEmployeePayroll(EmployeeDetails emp)
        {
            employeePayrollDetailList.Add(emp); 
        }
    }
}
