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



        public string queryFirstHalf = "Select * From tblAccounts";
        public string querySecondHalf = "";
        public string queryFinal = "";


        private int currentPage = 1;
        private int pageSize = 15;
        private int totalPages = 1;

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

            RefreshGrid();
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

            RefreshGrid();

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

                RefreshGrid();

                //  Banking.LoadAccountsIntoList();
                //  dataGridView1.DataSource = Banking.LoadAccountsIntoList();

                //    Banking.LoadAccountsIntoList();
                //    LoadAllIntoGrid();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Column1")
            {
                FormEditRecord record = new FormEditRecord(rowClicked, balanceCurrently2);
                record.ShowDialog();
                RefreshGrid();

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
            currentPage = 1;
            dataGridView1.DataSource = FilteredLoadIntoGrid();

            //  RefreshGrid(textBoxSearch.Text);                   // i created this method, because originally i was calling two lines, with the same parameters. that was useless, i didnt need the first line, a method made it easier to change
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
            string pageS = comboBoxPageNumSelect.Text;
            if (pageS == "")
            {
                pageSize = 10;       // this is for defualt when user chooses no option.
            }
            else
            {
                pageSize = Convert.ToInt32(pageS);   // combo box ka text will have our selected element. Which we will add to list.
            }


            string accNum = textBoxAccNum.Text;
            string accTitle = textBoxAccTitle.Text;
            string accCnic = textBoxAccCnic.Text;
            string rangeFrom = textBoxFromValue.Text;
            string rangeTo = textBoxToValue.Text;

            var conditions = new List<string>();


            if (rangeFrom != "" && rangeTo != "")
                conditions.Add("Balance BETWEEN @From AND @To");

            if (accNum != "")
                conditions.Add("AccNum LIKE @accnum");

            if (accTitle != "")
                conditions.Add("AccTitle LIKE @acctitle");

            if (accCnic != "")
                conditions.Add("Cnic LIKE @acccnic");


            string whereClause = conditions.Count == 0 ? "" : " WHERE " + string.Join(" AND ", conditions); // lambda function, for if count is zero, then empty where part. if it is not empty then make a WHERE part of the SQL query

            using var connection = new SqlConnection(DbHelper.connectionString);
            connection.Open();



                                                                                                            // total matching rows, using the SAME filter conditions
            string countQuery = "SELECT COUNT(*) FROM tblAccounts" + whereClause + ";";

            using var countCommand = new SqlCommand(countQuery, connection);

            AddFilterParameters(countCommand, accNum, accTitle, accCnic, rangeFrom, rangeTo);

            int totalRows = (int)countCommand.ExecuteScalar();
            totalPages = (int)Math.Ceiling(totalRows / (double)pageSize);


            if (totalPages == 0)
            {
                totalPages = 1;
            }

            if (currentPage > totalPages)
            {
                currentPage = totalPages;
            }

            if (currentPage < 1)
            {
                currentPage = 1;
            }

            

            int offset = (currentPage - 1) * pageSize; 


            string dataQuery = "SELECT AccNum, AccTitle, Cnic, Balance FROM tblAccounts" + whereClause + " ORDER BY AccNum OFFSET @Offset ROWS FETCH NEXT @PageSize ROWS ONLY;";

            using var command = new SqlCommand(dataQuery, connection);


            AddFilterParameters(command, accNum, accTitle, accCnic, rangeFrom, rangeTo);
            command.Parameters.AddWithValue("@Offset", offset);
            command.Parameters.AddWithValue("@PageSize", pageSize);


            var accounts = new List<Account>();
            using var reader = command.ExecuteReader();


            while (reader.Read())
            {
                accounts.Add(new Account(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
            }

            UpdatePageLabel();

            return accounts;
        }



        private void AddFilterParameters(SqlCommand command, string accNum, string accTitle, string accCnic, string rangeFrom, string rangeTo)  // separated the filtering of parameters to make this all cleaner then before.
        {
            if (accNum != "")
                command.Parameters.AddWithValue("@accnum", "%" + accNum + "%");

            if (accTitle != "")
                command.Parameters.AddWithValue("@acctitle", "%" + accTitle + "%");

            if (accCnic != "")
                command.Parameters.AddWithValue("@acccnic", "%" + accCnic + "%");

            if (rangeFrom != "" && rangeTo != "")
            {
                command.Parameters.AddWithValue("@From", Convert.ToInt32(rangeFrom));
                command.Parameters.AddWithValue("@To", Convert.ToInt32(rangeTo));
            }
        }



        private void UpdatePageLabel()
        {
            lblStatusLabelDisplayGrid.Text = "Page " + currentPage + " of " + totalPages;
        }


        private void btnSearch_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void textBoxAccNum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops the "ding" sound
                btnSearch_Click(sender, e);
            }
        }

        private void textBoxAccTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops the "ding" sound
                btnSearch_Click(sender, e);
            }
        }


        private void textBoxFromValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops the "ding" sound
                btnSearch_Click(sender, e);
            }
        }

        private void textBoxAccCnic_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops the "ding" sound
                btnSearch_Click(sender, e);
            }
        }

        private void textBoxToValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // stops the "ding" sound
                btnSearch_Click(sender, e);
            }
        }

        private void lblStatusLabelDisplayGrid_Click(object sender, EventArgs e)
        {

        }

        private void btnNextDisplayForm_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                RefreshGrid();
            }
        }

        private void btnPrevDisplayForm_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                RefreshGrid();
            }
        }

        private void comboBoxPageNumSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

    


 