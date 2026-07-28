using Microsoft.Data.SqlClient;
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

        public string accNum = "";
        public string accTitle = "";
        public string accCnic = "";

        public string queryFirstHalf = "Select * From tblAccounts";
        public string querySecondHalf = "";
        public string queryFinal = "";

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

            dataGridView1.DataSource = FilteredLoadIntoGrid();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FilteredLoadIntoGrid();

            //  RefreshGrid(textBoxSearch.Text);                   // i created this method, because originally i was calling two lines, with the same parameters. that was useless, i didnt need the first line, a method made it easier to change
        }

        private void Filters_Click(object sender, EventArgs e)
        {
            Filters filter = new Filters();
            filter.ShowDialog();
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

        //public List<Account> FilteredLoadIntoGrid()
        //{
        //  accNum = textBoxAccNum.Text;
        //  accTitle = textBoxAccTitle.Text;
        //  accCnic = textBoxAccCnic.Text;

            //  if (accNum != "" && querySecondHalf.Length == 0)
            //  {
            //      querySecondHalf = "AccNum LIKE @accnum";
            //  }

            //   if (accNum != "" && querySecondHalf != "")
            //   {
            //       querySecondHalf = querySecondHalf + " AND AccNum LIKE @accnum";
            //   }

            //  if (accTitle != "" && querySecondHalf != "")
            //  {
            //     querySecondHalf = querySecondHalf + " AND AccTitle LIKE @acctitle";
            //  }

            //  if (accTitle != "" && querySecondHalf.Length == 0)
            //  {
            //      querySecondHalf = "AccTitle LIKE @acctitle";
            //  }


            //  if (accCnic != "" && querySecondHalf != "")
            //  {
            //      querySecondHalf = querySecondHalf + " AND Cnic LIKE @acccnic";
            //  }

            //  if (accCnic != "" && querySecondHalf.Length == 0)
            //  {
            //      querySecondHalf = "Cnic LIKE @acccnic";
            //  }



            //  if (querySecondHalf == "")
            //  {
            //      queryFinal = queryFirstHalf + " ;";
            //      MessageBox.Show(queryFinal);
            //  }
            //  else
            //  {
            //      queryFinal = queryFirstHalf + " WHERE " + querySecondHalf + " ;";
            //      MessageBox.Show(queryFinal);

            //  }
            //  }
        
        public List<Account> FilteredLoadIntoGrid()
        {
            string accNum = textBoxAccNum.Text;
            string accTitle = textBoxAccTitle.Text;
            string accCnic = textBoxAccCnic.Text;

            var conditions = new List<string>();          // starts fresh every call so we can make the string again and again
 
            if (accNum != "")                             // these will make it so that we dont have to individualy make em, we can just pick those we have gotten, and just add these. with add comes separators
            {
                conditions.Add("AccNum LIKE @accnum");    // we can add all these to a list, then add them in the end, by AND as separator
            }

            if (accTitle != "")
            {
                conditions.Add("AccTitle LIKE @acctitle");        
            }

            if (accCnic != "")
            {
                conditions.Add("Cnic LIKE @acccnic");
            }

            string queryFirstHalf = "SELECT * FROM tblAccounts";  // better to handle ";" inside the string builder
            string queryFinal; 

            if (conditions.Count == 0)              // if no conditions, a vanila search
            {
                queryFinal = queryFirstHalf + ";"; 
            }
            else
            {
                queryFinal = queryFirstHalf + " WHERE " + string.Join(" AND ", conditions) + ";";
            }

            var accounts = new List<Account>();

            using var connection = new SqlConnection(DbHelper.connectionString);     // normal setting a connection
            connection.Open();

            using var command = new SqlCommand(queryFinal, connection);  // command is the search query here

            if (accNum != "")  // 
                command.Parameters.AddWithValue("@accnum", "%" + accNum + "%");

            if (accTitle != "")
                command.Parameters.AddWithValue("@acctitle", "%" + accTitle + "%");

            if (accCnic != "")
                command.Parameters.AddWithValue("@acccnic", "%" + accCnic + "%");

            using var reader = command.ExecuteReader();
            while (reader.Read())
            {
                accounts.Add(new Account(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));  // here is the filtered search
            }

            return accounts;
        }
    }

    }

    


 