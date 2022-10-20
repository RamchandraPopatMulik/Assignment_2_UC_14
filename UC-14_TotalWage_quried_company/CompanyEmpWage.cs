using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_14_TotalWage_quried_company
{
        public class CompanyEmpWage
        {
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHourPerMonth;
            public int totalEmpWage;
            public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHourPerMonth = maxHourPerMonth;
                this.totalEmpWage = 0;
            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }
            public string toString()
            {
                return "Total Emp Wage for company: " + this.company + "is:" + this.totalEmpWage;
            }
        }
}
