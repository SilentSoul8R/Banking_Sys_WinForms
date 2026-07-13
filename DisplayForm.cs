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
    public partial class DisplayForm : Form
    {

        public DisplayForm()
        {
            InitializeComponent();
        }

        private void listBox_DisplayALL_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Account> temp_listbox = Banking.LoadAccountsIntoList();
            foreach (var y in temp_listbox)
            {
                listBox_DisplayALL.Items.Add(y.Numbera + "," + y.Balance);
            }

        }

        private void btn_Menu_DisplayAll_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
