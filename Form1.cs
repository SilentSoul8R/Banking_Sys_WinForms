using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;


namespace WinFormsBankingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using var connection = new SqlConnection(DbHelper.connectionString);
            connection.Open();

            using var getFormMoney = new SqlCommand("SELECT SUM(Balance) FROM tblAccounts;", connection);
            int total = (int)getFormMoney.ExecuteScalar();

            using var getTotalUser = new SqlCommand("SELECT COUNT(AccNum)\r\nFROM tblAccounts;", connection); // \r and \n dont affect working or result of SQL query
            int totalUsers = (int)getTotalUser.ExecuteScalar();


            label3Form1.Text = totalUsers + " Users trust us";

            string convertedamount = total.ToString("C0");
            label3Form1Balance.Text = @"Total Money in the Bank: " + convertedamount;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Withdrawal button
            Withdrawal withdrawal = new Withdrawal();
            withdrawal.ShowDialog();
        }


       

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayForm DisplayForm = new DisplayForm();
            DisplayForm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Deposit Button
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccountForm createAccountForm = new CreateAccountForm();
            createAccountForm.ShowDialog();


        }



       

        private void createAccountToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CreateAccountForm create = new CreateAccountForm();
            create.ShowDialog();
        }

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewAllAccountsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DisplayForm display = new DisplayForm();
            display.ShowDialog();
        }

        private void addMoneyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Deposit deposit = new Deposit();
            deposit.ShowDialog();
        }

        private void withdrawMoneyToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Withdrawal withdrawal = new Withdrawal();
            withdrawal.ShowDialog();
        }
    }
}
