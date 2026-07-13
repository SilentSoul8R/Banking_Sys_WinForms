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
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void textBoxGetACCNUM_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnaccnumyes_Click(object sender, EventArgs e)
        {
            string ans_acc_num = textBoxGetACCNUM.Text;
            MessageBox.Show("The Acc num is: " + ans_acc_num);
            if (ans_acc_num == "")
            {
                MessageBox.Show("No Acc Num Given");
                ans_acc_num = "";
                return;
            }
        }

        private void btn_createcc_balance_Click(object sender, EventArgs e)
        {
            string ans_acc_bal = textBoxCreateACCBalance.Text;
            MessageBox.Show("Balance Given is: " + ans_acc_bal);
            if (ans_acc_bal == "")
            {
                MessageBox.Show("No Balance Given");
                ans_acc_bal = "";
                return;
            }
        }

        private void textBoxCreateACCBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The account you are creating is: " + textBoxGetACCNUM.Text + "," + textBoxCreateACCBalance.Text);
            try
            {
                int temp_balance_create_acc = Convert.ToInt32(textBoxCreateACCBalance.Text);                    // kept insdie the try-catch block as non numeric will give error when converting.
                Banking.Create(textBoxGetACCNUM.Text, temp_balance_create_acc);                                 // default is private, in C#, so add public in front of functions we are gonna use in another file.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_CreateAcc_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
