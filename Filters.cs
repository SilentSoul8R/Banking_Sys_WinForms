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
    public partial class Filters : Form
    {
        bool accNumCheck;
        bool accTitleCheck;
        bool cnicCheck;
        bool balanceCheck;
        public static List<string> filters;


        public Filters()
        {
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accNumCheck = checkBoxAccNum.Checked;
            accTitleCheck = checkBoxAccTitle.Checked;
            cnicCheck = checkBoxCnic.Checked;
            balanceCheck = checkBoxBalance.Checked;

            filters = new List<string>();
            

            string accNum = accNumCheck.ToString();
            string accTitle = accTitleCheck.ToString();
            string cnic = cnicCheck.ToString();
            string balance = balanceCheck.ToString();
            // MessageBox.Show(cnic);

            filters.Add(accNum);
            filters.Add(accTitle);
            filters.Add(cnic);
            filters.Add(balance);

            DisplayForm.setFilter(filters);


        }

    }
}
