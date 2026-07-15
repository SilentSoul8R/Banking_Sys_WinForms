using Microsoft.VisualBasic;
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

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            Banking.LoadAccountsIntoList();
            dataGridView1.DataSource = Banking.LoadAccountsIntoList();
            dataGridView1.Columns["Numbera"].HeaderText = "Account Number";
            dataGridView1.Columns["Numbera"].Width = 170;
            dataGridView1.Columns["Balance"].Width = 170;
            dataGridView1.Columns["Balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Balance"].DefaultCellStyle.Format = "C0";

        }

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            AddNewAccDisplay add = new AddNewAccDisplay();
            add.ShowDialog();
            Banking.LoadAccountsIntoList();
            dataGridView1.DataSource = Banking.LoadAccountsIntoList();
            dataGridView1.Columns["Numbera"].HeaderText = "Account Number";
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

            dataGridView1.Columns["Numbera"].DisplayIndex = 0;
            dataGridView1.Columns["Balance"].DisplayIndex = 1;
            dataGridView1.Columns["Column1"].DisplayIndex = 2;
            dataGridView1.Columns["Column2"].DisplayIndex = 3;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column2")
            {

                string accNum = Interaction.InputBox("Enter account number (acc1 == 1):", "Delete Account", "");
                int accNumero = Convert.ToInt32(accNum);
                Banking.Remove(accNum);
                Banking.LoadAccountsIntoList();
                dataGridView1.DataSource = Banking.LoadAccountsIntoList();
                dataGridView1.Columns["Numbera"].HeaderText = "Account Number";
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                FormEditRecord record = new FormEditRecord();
                record.ShowDialog();
                Banking.LoadAccountsIntoList();
                dataGridView1.DataSource = Banking.LoadAccountsIntoList();
                dataGridView1.Columns["Numbera"].HeaderText = "Account Number";
            }
        }

   
    }
}
