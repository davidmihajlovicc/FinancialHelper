using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialHelper
{
    public class BankServices
    {
        public int Amount { get; set; }
        public double Interest { get; set;}
        public string Currency {  get; set; }

        public int Duration { get; set; }


        public BankServices(int amount, double interest, string currency, int duration)
        {
            Amount = amount;
            Interest = interest;
            Currency = currency;
            Duration = duration;
        }

       
    }
}
