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

            Banking.ExitWithSave();
            this.Close();
        }

        private void btnCreateAccYes_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Missing Account Number\nRETRY");
                    return;
                }
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Missing Amount\nRETRY");
                    return;

                }
                String Accnumero = textBox1.Text;
                string deposit = textBox2.Text;
                int depositFR = Convert.ToInt32(textBox2.Text);


                if (depositFR < 0)
                {
                    MessageBox.Show("Negative Amount Not Allowed");
                    return;
                }

                Banking.Deposit(Accnumero, depositFR);

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
