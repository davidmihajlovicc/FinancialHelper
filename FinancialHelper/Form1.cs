namespace FinancialHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(userControl);
            userControl.BringToFront();

        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            UserControl1 credit_calc = new UserControl1();
            AddUserControl(credit_calc);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UserControl2 savings_calc = new UserControl2();
            AddUserControl(savings_calc);

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UserControl3 tax_calc = new UserControl3();
            AddUserControl(tax_calc);

        }
    }
}
