using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialHelper
{
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = guna2TrackBar1.Value.ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            BankServices savings = new Savings(int.Parse(guna2TextBox1.Text), double.Parse(guna2TextBox2.Text)/100, FinanceUtilities.ChooseCurrency(radioButton1.Checked), guna2TrackBar1.Value);
            IFinanceCalculator savingsCalculator = (IFinanceCalculator)savings;
            MessageBox.Show($"Your savings will be {Math.Round(savingsCalculator.CalculatePayment(),2)} {savings.Currency}");
        }
    }
}
