using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialHelper
{
    public static class FinanceUtilities
    {

        public static string ChooseCurrency(bool firstCurrency) {
            if(firstCurrency) { return "Euro"; }
            return "Dollar";
        }

        public static string ChooseResidenceStatus(bool firstStatus, bool secondStatus) {
            if (firstStatus) { return "Resident for full year."; }
            else if(secondStatus) { return " Non - resident for full year"; }
            return "Part-year resident";

        }
    }
}
