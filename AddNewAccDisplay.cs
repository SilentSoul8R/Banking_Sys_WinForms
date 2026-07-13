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
            try
            {
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
}
