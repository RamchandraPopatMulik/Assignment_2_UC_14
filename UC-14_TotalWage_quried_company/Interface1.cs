using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC_14_TotalWage_quried_company
{
    public interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth);
       
        public void computeEmpWage();

        public int getTotalEmpWage(string company);

        public int computeEmpWage(CompanyEmpWage companyEmpWage);
    }
}
