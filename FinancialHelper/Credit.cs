using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialHelper
{
    public class Credit : BankServices, IFinanceCalculator
    {
        
        public Credit(int amount, double interest, string currency, int duration):
            base(amount, interest, currency, duration) { }

        public double CalculatePayment() {
            double monthlyInterestRate = Interest / 12;
            return (Amount*monthlyInterestRate)/(Math.Pow(1+monthlyInterestRate, Duration)-1);
        }
    }
}
