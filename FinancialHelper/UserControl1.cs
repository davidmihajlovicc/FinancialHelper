using Guna.UI2.WinForms;
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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

       
        
        

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label4.Text = guna2TrackBar1.Value.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            BankServices credit = new Credit(int.Parse(guna2TextBox1.Text), double.Parse(guna2TextBox2.Text)/100, FinanceUtilities.ChooseCurrency(radioButton1.Checked), guna2TrackBar1.Value);
            IFinanceCalculator calculator = (IFinanceCalculator)credit;
            MessageBox.Show($"Your monthly payment is: {calculator.CalculatePayment()} {credit.Currency}");
            
            
        }

       
    }
}
