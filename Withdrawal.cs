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
                if (textBoxAccWithdrawal.Text == "")
                {
                    MessageBox.Show("Missing Account Number\nRETRY");
                    return;
                }
                if (textBoxWithdrawal.Text == "")
                {
                    MessageBox.Show("Missing Amount\nRETRY");
                    return;

                }

                String Accnumero = textBoxAccWithdrawal.Text;
                string amount = textBoxWithdrawal.Text;
                int Withdrawal = Convert.ToInt32(textBoxWithdrawal.Text);

                if (Withdrawal < 0)
                {
                    MessageBox.Show("Negative Amount Not Allowed");
                    return;
                }



                Banking.Withdrawal(Accnumero, Withdrawal);

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
          
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            Banking.ExitWithSave();
            this.Close();
        }
    }
}
