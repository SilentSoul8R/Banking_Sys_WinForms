using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsBankingApp
{
    public partial class DisplayForm : Form
    {

        public static string queryDynamicSearch = "";
        public static string queryHalfAccNum = "";
        public static string queryHalfAccTitle = "";
        public static string queryHalfAccCnic = "";
        public static string queryHalfAccBalance = "";
        public static List<string> queryList;

        public DisplayForm()
        {
            InitializeComponent();

        }

        //  private void listBox_DisplayALL_SelectedIndexChanged(object sender, EventArgs e)
        //  {
        //      List<Account> temp_listbox = Banking.LoadAccountsIntoList();
        //      foreach (var y in temp_listbox)
        //      {
        //          listBox_DisplayALL.Items.Add(y.Numbera + "," + y.Balance);
        //      }
        //
        //  }

        private void btn_Menu_DisplayAll_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {

            RefreshGrid(textBoxSearch.Text);
            // LoadAllIntoGrid();
            // Banking.LoadAccountsIntoList();
            // dataGridView1.DataSource = Banking.LoadAccountsIntoList();
            // dataGridView1.Columns["Numbera"].HeaderText = "Account Number";
            // dataGridView1.Columns["Numbera"].Width = 170;
            // dataGridView1.Columns["Balance"].Width = 170;
            dataGridView1.Columns["Balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["Balance"].DefaultCellStyle.Format = "C0";

        }

        private void BtnAddRecord_Click(object sender, EventArgs e)
        {
            CreateAccountForm add = new CreateAccountForm();
            add.ShowDialog();

            RefreshGrid(textBoxSearch.Text);

            // Banking.LoadAccountsIntoList();
            // dataGridView1.DataSource = Banking.LoadAccountsIntoList();

            //   Banking.LoadAccountsIntoList();
            //   LoadAllIntoGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            string rowClicked = dataGridView1.Rows[e.RowIndex].Cells["AccountNumber"].Value.ToString();
            string balanceCurrently = dataGridView1.Rows[e.RowIndex].Cells["Balance"].Value.ToString();
            // MessageBox.Show(balanceCurrently);

            // MessageBox.Show(rowClicked);
            int balanceCurrently2 = Convert.ToInt32(balanceCurrently);
            //  MessageBox.Show(Convert.ToString(balanceCurrently2));

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Column2")
            {

                var answer = MessageBox.Show("You sure you want to delete " + rowClicked, "Delete Account", MessageBoxButtons.YesNo);
                if (DialogResult.No == answer)
                {
                    return;
                }


                Banking.Remove(rowClicked);

                RefreshGrid(textBoxSearch.Text);

                //  Banking.LoadAccountsIntoList();
                //  dataGridView1.DataSource = Banking.LoadAccountsIntoList();

                //    Banking.LoadAccountsIntoList();
                //    LoadAllIntoGrid();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                FormEditRecord record = new FormEditRecord(rowClicked, balanceCurrently2);
                record.ShowDialog();
                RefreshGrid(textBoxSearch.Text);

                // Banking.LoadAccountsIntoList();
                // dataGridView1.DataSource = Banking.LoadAccountsIntoList();

                //  Banking.LoadAccountsIntoList();
                //  LoadAllIntoGrid();
            }
        }
        private void RefreshGrid(string search = "")
        {

            dataGridView1.DataSource = Banking.LoadAccountsIntoList(search);

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search Button was Clicked");
            RefreshGrid(textBoxSearch.Text);                   // i created this method, because originally i was calling two lines, with the same parameters. that was useless, i didnt need the first line, a method made it easier to change
        }

        private void Filters_Click(object sender, EventArgs e)
        {
            Filters filter = new Filters();
            filter.ShowDialog();
        }

        private void btnSearch_KeyDown(object sender, KeyEventArgs e)
        {
            

        }

        private void textBoxSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)               // this whether the pressed key was enter or not.
            {
                e.SuppressKeyPress = true; // stops the "ding" sound, this sound is played by default
                btnSearch_Click(sender, e);
            }
        }

        //  private void LoadAllIntoGrid()
        //  {
        //      dataGridView1.Rows.Clear();                     //to ensure we dont add data again and again 
        //      List<Account> accounts = Banking.LoadAccountsIntoList();
        //      foreach (var Acc in accounts)
        //      {
        //          dataGridView1.Rows.Add(Acc.Numbera, Acc.Balance);
        //      }
        //      dataGridView1.Columns["Balance"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        //      dataGridView1.Columns["Balance"].DefaultCellStyle.Format = "C0";


        //  }

        public static void setFilter(List<string> filters)
        {
            string accNum = filters[0];
            string accTitle = filters[1];
            string accCnic = filters[2];
            string accBalance = filters[3];

            if (accNum == "True")
            {
                queryHalfAccNum = "AccNum = @search";
                queryList.Add(queryHalfAccNum);
            }

            if (accTitle == "True")
            {
                queryHalfAccTitle = "AccTitle = @search";
                queryList.Add(queryHalfAccTitle);
            }

            if (accCnic == "True") 
            {
                queryHalfAccCnic = "Cnic = @search";
                queryList.Add (queryHalfAccCnic);
            }

            if (accBalance == "True") 
            {
                queryHalfAccBalance = "Balance = @search";
                queryList.Add(queryHalfAccBalance);
            }

            foreach (var x in queryList) 
            {
                MessageBox.Show(x);
            }

            
           

        }

    }
}
