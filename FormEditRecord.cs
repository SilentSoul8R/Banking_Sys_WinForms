using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBankingApp
{
    public partial class FormEditRecord : Form
    {
        private readonly string accountNumber;
        private int balanceOld;

        public FormEditRecord()
        {
            InitializeComponent();
        }

        public FormEditRecord(String accNum, int balance)
        {
            accountNumber = accNum;
            balanceOld = balance;

            InitializeComponent();
        }

        private void btnBack_CreateAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAccYesEdit_Click(object sender, EventArgs e)
        {
            try
            {

                string balanceStr = textBoxCreateACCBalance.Text;


                if (balanceStr == "")
                {
                    MessageBox.Show("Enter some Balance");
                    return;
                }

                if (textBoxTakeAccountTitleEdit.Text == "")
                {
                    MessageBox.Show("Enter the account title");
                }

                if (textBoxTakeCnicEdit.Text == "")
                {
                    MessageBox.Show("Enter the Cnic");
                }

                using var connection = new SqlConnection(DbHelper.connectionString);
                connection.Open();

                using var queryEditAccount = new SqlCommand("UPDATE tblAccounts SET Balance = @Balance, AccTitle = @title, Cnic = @cnic WHERE AccNum = @acc;", connection);
                queryEditAccount.Parameters.AddWithValue(@"Balance", balanceStr);
                queryEditAccount.Parameters.AddWithValue(@"title", textBoxTakeAccountTitleEdit.Text);
                queryEditAccount.Parameters.AddWithValue(@"cnic", textBoxTakeCnicEdit.Text);
                queryEditAccount.Parameters.AddWithValue(@"acc", accountNumber);
                queryEditAccount.ExecuteNonQuery();

                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBoxCreateACCBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEditRecord_Load(object sender, EventArgs e)
        {
            textBoxAccNumEdit.Text = accountNumber;
            textBoxAccNumEdit.Enabled = false;

            label2.Text = "Enter the Balance:                              (Old Balance: " + balanceOld.ToString("C0") + ")";
           
        }
    }
}
