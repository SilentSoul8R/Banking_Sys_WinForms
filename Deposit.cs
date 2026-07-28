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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

                if (textBox2.Text == "")
                {
                    MessageBox.Show("Missing Amount\nRETRY");
                    return;

                }

                if (textBoxTakeAccountTitleDeposit.Text == "")
                {
                    MessageBox.Show("Missing Account Title\nRETRY");
                    return;

                }

                if (textBoxTakeCnicDeposit.Text == "")
                {
                    MessageBox.Show("Missing Cnic Number\nRETRY");
                    return;

                }

                String accNumber = accNum;
                string deposit = textBox2.Text;
                string accTitle = textBoxTakeAccountTitleDeposit.Text;
                string accCnic = textBoxTakeCnicDeposit.Text;
                int depositFR = Convert.ToInt32(textBox2.Text);


                if (depositFR < 0)
                {
                    MessageBox.Show("Negative Amount Not Allowed");
                    return;
                }

                Banking.Deposit(accNumber, accTitle, accCnic, depositFR);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Deposit_Load(object sender, EventArgs e)
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
