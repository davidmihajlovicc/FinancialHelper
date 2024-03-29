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

    }
}
