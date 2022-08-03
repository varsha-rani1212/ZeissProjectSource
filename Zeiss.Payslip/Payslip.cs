using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zeiss.BL;

namespace Zeiss.Payslip
{
    internal class Payslip
    {
        string EmpID;
        string EmpFirstName;
        string EmpLastName;
        string Department;
        DateTime DOJ;
        short Month;
        short Year;
        int BasicPay;
        int DA;
        int HRA;
        int LTA;
        int PF;
        int ProfTax;
        int IncomeTax;
        int Loan;

        public void PrintPaySlip(string EmpID, short Month, short Year)
        {
            Console.WriteLine("PaySlip for " + Year.ToString() + "-" + Month.ToString());

            EmployeeBL empBL = new EmployeeBL();
            empBL = empBL.GetEmployeeDetails("M100232");
            Console.WriteLine(empBL.empID + "  " + empBL.FirstName + "  " + empBL.LastName);
            Console.WriteLine("Date of Joining: " + empBL.DOJ);
        }
    }
}
