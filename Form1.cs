using Microsoft.VisualBasic;


namespace WinFormsBankingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Banking.LoadAccounts();
            int total = 0;
            total = Banking.accounts.Count;
            label3Form1.Text = total + " Users trust us";
            int totalmoney = 0;
            foreach(Account account in Banking.accounts)
            {
                totalmoney = totalmoney + account.Balance;
            }
            string convertedamount = totalmoney.ToString("C0");
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


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string accNum = Interaction.InputBox("Enter account number: \nPlease Enter the account Number: ", "Delete Account", "");
                if (accNum == "")
                {
                    MessageBox.Show("Missing Account Number\nRETRY");
                    return;
                }
                MessageBox.Show("The account: " + accNum + " is going to be removed");
                // int temp_accNum_Delete = Convert.ToInt32(accNum);
                Banking.Remove(accNum);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void button6_Click(object sender, EventArgs e)
        {
            Banking.ExitWithSave();
            this.Close();
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

        
    }
}
