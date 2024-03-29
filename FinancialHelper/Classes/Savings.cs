using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialHelper
{
    public class Savings : BankServices, IFinanceCalculator
    {
       public int RentPayment { get; set; }
        public Savings(int amount,  double interest, string currency, int duration) :
            base(amount, interest, currency, duration) 
        {}

        public double CalculatePayment()
        {
            return Amount * (Math.Pow((1+Interest/12), Duration/12));
        }
    }
}
