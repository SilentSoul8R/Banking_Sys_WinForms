
using Microsoft.Data.SqlClient;
using System.Net.Http.Headers;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;


namespace WinFormsBankingApp
{
    
    class Banking
    {

        public static string querySearch = "";
        //Class BankAccount
        //Variable name firstName
        //First_Name
        //FIRSTNAME
        //parameter camelCasing
        //Local variables camelCasin
        //Function names Pascal Casing

        public static List<Account> accounts = new List<Account>();
        
        static String accFilePath = @"C:\Users\Muhammad.Abdullah.S\source\repos\WinFormsBankingApp\WinFormsBankingApp\AccFile.txt";


        public static void Create(string accNumber, string accTitle, String cnic, int balance)
        {
            // so basically, now we have to convert all this to SQL based working, so basically when we search all accounts, we are just looking at select * to display all and check whether a app exists. Same we can give new record as insert in with values we have
            if (balance < 0)
            {
                MessageBox.Show("Negative balance is not allowed");
                return;
            }

            // since we check this before opening anything, we open database after this
            using var connection = new SqlConnection(DbHelper.connectionString);
            connection.Open();


            using var check = new SqlCommand("SELECT COUNT(*) FROM tblAccounts WHERE AccNum = @value;", connection);                 //first we made a query, then we gave it parameters, now we are gonna run it
            check.Parameters.AddWithValue(@"value", accNumber);
            int exist = (int) check.ExecuteScalar();                         // we execute the query here
            
            if (exist >  0)
            {
                MessageBox.Show("The account already exists");
                return;
            }

            using var querytoInsertAcc = new SqlCommand("INSERT INTO tblAccounts (AccNum, AccTitle, Cnic, Balance) VALUES (@accNum, @accTitle, @cnic, @balance);", connection);
            querytoInsertAcc.Parameters.AddWithValue(@"accNum", accNumber);
            querytoInsertAcc.Parameters.AddWithValue(@"accTitle", accTitle);
            querytoInsertAcc.Parameters.AddWithValue(@"cnic", cnic);
            querytoInsertAcc.Parameters.AddWithValue(@"balance", balance);
            querytoInsertAcc.ExecuteNonQuery();

            MessageBox.Show("===========================\nAdding Accountr:\nAccount: " + accNumber + "\nAccount Title:" + accTitle + "\nCnic:" + cnic + "\nBalance: " + balance + "\n \n \nThank You For Using Our Service!\n==========================="); ;
            


        }

        public static void Deposit(string numb, string title, string cnic, int bal)
        {
            // negatiove balance check is made in form

            using var connection = new SqlConnection(DbHelper.connectionString);
            connection.Open();

            using var checkExist = new SqlCommand("SELECT COUNT(*) FROM tblAccounts WHERE AccNum = @AccNum;", connection);
            checkExist.Parameters.AddWithValue(@"AccNum", numb);
            int count = (int) checkExist.ExecuteScalar();

      
                                                                             
            if (count == 0)
            {
                throw new Exception("This Account does not Exist!");         // using throw instead of readline for this, as form can catch exception
                return;
            }

            using var updateBalanceQuery = new SqlCommand("UPDATE tblAccounts SET Balance = Balance + @deposit WHERE AccNum = @accnumb AND AccTitle = @title AND Cnic = @cnic;", connection);
            updateBalanceQuery.Parameters.AddWithValue(@"accnumb", numb);
            updateBalanceQuery.Parameters.AddWithValue(@"accTitle", title);
            updateBalanceQuery.Parameters.AddWithValue(@"cnic", cnic);
            updateBalanceQuery.Parameters.AddWithValue(@"deposit", bal);
            updateBalanceQuery.ExecuteNonQuery();

            MessageBox.Show("===========================\nDeposit:\nAccount: " + numb + "\nAccount Title:" + title + "\nCnic:" + cnic + "\nBalance: " + bal + "\n \n \nThank You For Using Our Service!\n===========================");


        }

        public static void Withdrawal(string numb, string title, string cnic, int amt)
        {
            using var connection = new  SqlConnection(DbHelper.connectionString);
            connection.Open();

            using var checkExist = new SqlCommand("SELECT COUNT(*) FROM tblAccounts WHERE AccNum = @AccNum;", connection);
            checkExist.Parameters.AddWithValue(@"AccNum", numb);
            int count = (int)checkExist.ExecuteScalar();
                                                                                                                  //basically if count of accounts with that number is 0, then no accounts exist.
            if (count == 0)
            {
                throw new Exception("Account not found");
                return;
            }

            using var getBalance = new SqlCommand("SELECT Balance FROM tblAccounts WHERE AccNum = @acc;", connection);
            getBalance.Parameters.AddWithValue(@"acc", numb);
            int balanceDB = (int) getBalance.ExecuteScalar();

            try
            {
                if (amt > balanceDB)
                {
 
                    MessageBox.Show("Not Enought Money in the Account");
                    return;
                }
                else
                {
                    using var queryWithdrawCash = new SqlCommand("UPDATE tblAccounts SET Balance = Balance - @amt WhERE AccNum = @numb AND AccTitle = @title AND Cnic = @cnic;", connection);
                    queryWithdrawCash.Parameters.AddWithValue(@"amt", amt);
                    queryWithdrawCash.Parameters.AddWithValue(@"title", title);
                    queryWithdrawCash.Parameters.AddWithValue(@"cnic", cnic);
                    queryWithdrawCash.Parameters.AddWithValue(@"numb", numb);
                    queryWithdrawCash.ExecuteNonQuery();


                    MessageBox.Show("===========================\nWithdrawal:\nAccount: " + numb + "\nAccount Title:" + title + "\nAmount: " + amt + "\n \n \nThank You For Using Our Service!\n===========================");

                    


                }
            }
            catch (Exception x)     // i have given the custom message in the previous line, hence it will use that one here, because the exception is the same
                                    // as soon as a error happens in try, we will be sent here, where we will use that message
            {
                // removed the messages here as they are gonna be implemented in the Form
            }
            finally
            {

            }

        }

        //public static void Remove(string accnumb, string title, string cnic)
        public static void Remove(string accnumb)
        {
            using var connection = new SqlConnection(DbHelper.connectionString);
            connection.Open();

            // simply just use the query to delete the account, no more needed, for my satisfation, i will make a check to see if it actually exists or not.

            using var checkExist = new SqlCommand("SELECT COUNT(*) FROM tblAccounts WHERE AccNum = @AccNum;", connection);        //if the count is zero, that means that account doesn't exist
            checkExist.Parameters.AddWithValue(@"AccNum", accnumb);                                                       
            int count = (int)checkExist.ExecuteScalar();

            if (count == 0)
            {
                MessageBox.Show("No Account with this Acc-Number"); 
                return;
            }

            using var deleteAccountQuery = new SqlCommand("DELETE FROM tblAccounts WHERE AccNum = @accNum;", connection);          //Deletion is happening here
            deleteAccountQuery.Parameters.AddWithValue(@"accNum", accnumb);
            deleteAccountQuery.ExecuteNonQuery();

        }

        

       //  public static List<Account> LoadAccountsIntoList(string search = "")  //search for filtering         //implemented this funciton still as the program still relies on list to run, eg displaying data to the grid.
       //  {
       //      var accounts = new List<Account>();
       //
       //      using var connection = new SqlConnection(DbHelper.connectionString);
       //      connection.Open();
       //      
       //      if (search == "")
       //      {
       //          querySearch = "SELECT AccNum, AccTitle, Cnic, Balance  FROM tblAccounts;";   //the normal string 
       //         
       //                                                       
       //      }
       //      else if (search != "")
       //      {
       //          querySearch = "SELECT AccNum, AccTitle, Cnic, Balance  FROM tblAccounts WHERE AccNum LIKE @search;";  // the one that can be used for filtering
       //
       //          
       //      }
       //
       //     using var select = new SqlCommand(querySearch, connection);
       //     if (search != "")
       //     {
       //         select.Parameters.AddWithValue("@search", "%" + search + "%");   // this worked becuase we are assigning a value to an thing made outside this scope, if it was not outside and inside, then asgining parameters outside aws not possible
       //     }
       //
       //    using var reader = select.ExecuteReader();
       //
       //     while (reader.Read())                                                                           /*The condition being evaluated in while (reader.Read()) is the return value of reader.Read() itself — Read() is a method that returns a bool.
       //                                                                                                       Every time you call reader.Read():
       //                                                                                                       -It moves the reader's internal cursor forward to the next row in the result set
       //                                                                                                       -It returns true if there was a next row to move to
       //                                                                                                      -It returns false if there were no more rows left */
       //         {
       //            accounts.Add(new Account(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
       //         }
       //     return accounts;
       //
       //
       // }
       //
       // public static void FilteredLoadIntoList() { 
       // }
    }
}