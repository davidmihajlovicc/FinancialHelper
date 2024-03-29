using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinancialHelper
{
    public class Tax : IFinanceCalculator
    {
        public int Income {get; set;}

        public string Currency { get; set;}


        public Tax(int income, string currency)
        {
            Income = income;
            Currency = currency;
        }

        public double CalculatePayment()
        {
            
            if (Income <= 10000)
            {
                return 0;
            }
            else if (Income <= 50000)
            {
                return (Income - 10000) * 0.1;
            }
            else
            {
                return 40000 * 0.1 + (Income - 50000) * 0.2;
            }

        }
    }
}
