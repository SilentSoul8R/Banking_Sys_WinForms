using Microsoft.VisualBasic;


namespace WinFormsBankingApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Banking.LoadAccounts(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string accNum = Interaction.InputBox("Enter account number: \nPlease Enter the account Number Only (1 for Acc1): ", "Delete Account", "");
            MessageBox.Show("The account: " + accNum + " is going to be removed");
            int temp_accNum_Delete = Convert.ToInt32(accNum);
            Banking.Remove(temp_accNum_Delete);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayForm DisplayForm = new DisplayForm();    
            DisplayForm.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

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
