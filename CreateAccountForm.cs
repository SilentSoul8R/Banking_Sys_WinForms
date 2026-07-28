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

        private void textBoxCreateACCBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreateAccYes_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (textBoxCreateACCBalance.Text == "")
                {
                    MessageBox.Show("Balance missing:\nDefaulting to 0");
                    textBoxCreateACCBalance.Text = "0";
                }

                if (textBoxTakeAccountTitle.Text == "")
                {
                    MessageBox.Show("Account Title missing");
                    return;
                }

                if(textBoxTakeCnicCreate.Text == "")
                {
                    MessageBox.Show("CNIC is missing");
                    return;
                }


                int tempBalanceCreateAcc = Convert.ToInt32(textBoxCreateACCBalance.Text);                    // kept insdie the try-catch block as non numeric will give error when converting.
                

                Banking.Create(textBoxGetACCNUM.Text, textBoxTakeAccountTitle.Text, textBoxTakeCnicCreate.Text, tempBalanceCreateAcc);                                 // default is private, in C#, so add public in front of functions we are gonna use in another file.

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
