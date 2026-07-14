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
        public FormEditRecord()
        {
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
                
                String Accnumero = textBoxGetACCNUM.Text;
                string BalanceStr = textBoxCreateACCBalance.Text;
                int BalanceFR = Convert.ToInt32(BalanceStr);
                int Index = Banking.accounts.FindIndex(a => a.Numbera == Accnumero);
                Banking.accounts[Index].Balance = BalanceFR;
                Banking.accounts[Index].Numbera = Accnumero;
                Banking.ExitWithSave();


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
    }
}
