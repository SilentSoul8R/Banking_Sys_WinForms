using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsBankingApp
{
    public partial class AddNewAccDisplay : Form
    {
        public AddNewAccDisplay()
        {
            InitializeComponent();
        }

        private void btnBack_CreateAcc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAccYesDisplay_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Your account is created successfully";
            return;
            try
            {
                //Camel Casing, Pascal Casing, what is it?
                //Local variables, method arguments, camelCasing
                //Class Name, Namespace name, Method Name

                string firstName = "";
                if (textBoxGetACCNUM.Text == "")
                {
                    MessageBox.Show("Please enter account number");
                    return;
                }

                String Accnumero = textBoxGetACCNUM.Text;
                string BalanceStr = textBoxCreateACCBalance.Text;
                int BalanceFR = Convert.ToInt32(BalanceStr);
                Banking.Create(Accnumero, BalanceFR);
                
                
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    class Person
    {
        public string SayHello(string name, string message)
        {
            string result = "Hello " + name + ", " + message;
            return result;
        }
    }
}
