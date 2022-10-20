using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_14_TotalWage_quried_company
{
    internal class UC
    {
            static void Main(string[] args)
            {
            Console.WriteLine("Please Enter Company Name:");
            string company = Console.ReadLine();

            Console.WriteLine("Please Enter Employee Rate Per Hour :");
            int empRatePerHr = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Number Of Working Days :");
            int numOfWorkingDays = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please Enter Maximum Hours Per Month :");
            int maxHoursPerMonth = Convert.ToInt32(Console.ReadLine());

            CompanyEmpWage tcs = new CompanyEmpWage(company, empRatePerHr, numOfWorkingDays, maxHoursPerMonth);
            
        }
    }
}

