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
    public partial class Withdrawal : Form
    {
        public Withdrawal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccYes_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxAddMoney.SelectedItem == null)
                {
                    MessageBox.Show("Please select an account");
                    return;
                }

                string accNum = comboBoxAddMoney.SelectedItem.ToString();

                if (textBoxWithdrawal.Text == "")
                {
                    MessageBox.Show("Missing Amount\nRETRY");
                    return;

                }

                if (textBoxTakeAccountTitleWithdraw.Text == "")
                {
                    MessageBox.Show("Missing Account Title\nRETRY");
                    return;

                }

                if (textBoxTakeCnicWithdraw.Text == "")
                {
                    MessageBox.Show("Missing Cnic Number\nRETRY");
                    return;

                }

                String accNumber = accNum;                          // added above by the drop down box
                string accTitle = textBoxTakeAccountTitleWithdraw.Text;
                string accCnic = textBoxTakeCnicWithdraw.Text;
                string amount = textBoxWithdrawal.Text;
                int Withdrawal = Convert.ToInt32(textBoxWithdrawal.Text);

                if (Withdrawal < 0)
                {
                    MessageBox.Show("Negative Amount Not Allowed");
                    return;
                }



                Banking.Withdrawal(accNumber, accTitle, accCnic, Withdrawal);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Withdrawal_Load(object sender, EventArgs e)
        {
            LoadIntoDropBox();
        }

        private void LoadIntoDropBox()
        {
            comboBoxAddMoney.Items.Clear();

            using var connection = new SqlConnection(DbHelper.connectionString);
            connection.Open();

            using var command = new SqlCommand(
                "SELECT AccNum FROM tblAccounts;",        // this sql command gives us the list, but sorted
                connection);
            using var reader = command.ExecuteReader();

            while (reader.Read())
            {
                comboBoxAddMoney.Items.Add(reader.GetString(0));

            }
        }
    }
}
