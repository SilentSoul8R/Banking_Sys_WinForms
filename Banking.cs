
namespace WinFormsBankingApp
{
    class Banking
    {
        public static List<Account> accounts = new List<Account>();
        //  static String Acc_File_Path = Path.Combine(Application.StartupPath, "Acc-File.txt");
        //static String Acc_File_Path = @"C:\Users\Muhammad.Abdullah.S\source\repos\WinFormsBankingApp";
        static String Acc_File_Path = @"C:\Users\Muhammad.Abdullah.S\source\repos\WinFormsBankingApp\WinFormsBankingApp\AccFile.txt";


        public static void Create(string Number1, int Balance)
        {

            if (accounts.Any(a => a.Numbera == Number1))
            {
                MessageBox.Show("The account already exists");
                return;
            }
            if (Balance < 0)
            {
                MessageBox.Show("Negative balance is not allowed");
                return;
            }

            accounts.Add(new Account(Number1, Balance));
            String FileACC = Number1 + "," + Balance + "\n";
            File.AppendAllText(Acc_File_Path, FileACC);
            MessageBox.Show("===========================\nAdding Accountr:\nAccount: " + Number1 + "\nBalance: " + Balance + "\n \n \nThank You For Using Our Service!\n==========================="); ;
            ExitWithSave();


        }

        public static void Deposit(string numb, int Bal)
        {

            var acc = accounts.FirstOrDefault(a => a.Numbera == numb);           // part of Language Integrated Query, LINQ, The firstordefault and ANy is part of it.
                                                                                 // Line inside the Brackets is a Lambda Function, 
            if (acc == null)
            {
                throw new Exception("This Account does not Exist!");         // using throw instead of readline for this, as form can catch exception
                return;
            }

            acc.Balance += Bal;
            MessageBox.Show("===========================\nDeposit:\nAccount: " + numb + "\nAmount: " + Bal + "\n \n \nThank You For Using Our Service!\n===========================");

            Banking.ExitWithSave();

        }

        public static void Withdrawal(string numb, int Bal)
        {

            var acc = accounts.FirstOrDefault(a => a.Numbera == numb);
            if (acc == null)
            {
                throw new Exception("Account not found");
                return;
            }

            try
            {
                if (Bal > acc.Balance)
                {
 
                    MessageBox.Show("Not Enought Money in the Account");
                    return;
                }
                else
                {
                    acc.Balance -= Bal;
                    MessageBox.Show("===========================\nWithdrawal:\nAccount: " + numb + "\nAmount: " + Bal + "\n \n \nThank You For Using Our Service!\n===========================");

                    Banking.ExitWithSave();


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
        public static List<string> DisplayAll()   // instead of looping, we have to make a List of the accounts, that can be shown in a ListBox
        {
            List<string> AllAccounts = new List<string>();

            if (accounts.Count == 0)
            {

            }
            else
            {
                foreach (var a in accounts)
                {
                    string accstr = a.Numbera + "," + a.Balance;
                    AllAccounts.Add(accstr);

                }
            }

            return AllAccounts;
        }

        public static void Remove(string Accnumb)
        {

            try
            {
               foreach (var x in accounts)
                {
                    if (x.Numbera == Accnumb)
                    {
                        accounts.Remove(x);  //That specific message — "Collection was modified; enumeration operation may not execute" — always means the same thing: somewhere, a foreach loop is actively going through a list, and while it's still looping, some other code adds or removes an item from that exact same list. foreach doesn't tolerate that; it throws rather than risk skipping/reprocessing items.
                    }
                }                                    // now since it exists, we can remove that index from the list.
                                                                                              // Console.WriteLine("The following account was removed: " + acc1);              // -1 at index because 3rd acount points to 2nd index.
            }
            catch (ArgumentOutOfRangeException x)   //changed to ArgumentOutOfRangeException from IndexOutOfRangeException as it will not catch the one sent, which was actullay the Argument one. i was calling the wroing one.
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                ExitWithSave();

            }



        }

        public static void ExitWithSave()
        {
            List<String> Accounts_To_File = new List<String>();
            foreach (var x in accounts)                               // var tells the compiler: "figure out the type yourself, based on what's on the right side.",
                                                                      // and since we have decalred var, the compiler knows what that means
            {
                String AccNumero = x.GetNumber();
                int AccBalance = x.GetBalance();
                String Balance_For_File = Convert.ToString(AccBalance);
                String To_Add = AccNumero + ',' + Balance_For_File;
                Accounts_To_File.Add(To_Add);

            }

            File.WriteAllLines(Acc_File_Path, Accounts_To_File);


        }

        public static void LoadAccounts()
        {
            if (File.Exists(Acc_File_Path))         // This is only checking, no handle is opened in the disk so no close needed, and method that return a filestream uses a lock, and we must close it
            {                                                                               // all other functions specifically say that they close the file after each call
                                                                                            // Console.WriteLine("File already Exists");
                String[] Lines = File.ReadAllLines(Acc_File_Path);
                // Console.WriteLine("The size of the Lines is = " + Lines.Count());
                foreach (string line in Lines)
                {
                    String[] Line_in_parts = line.Split(',');                         // each line read is in a array, and spliting them also makes an array in parts
                    string Numero = Line_in_parts[0];                                 // Now the rest of the program will use the data in the array, that was populated through files
                    int balance = Convert.ToInt32(Line_in_parts[1]);
                    accounts.Add(new Account(Numero, balance));                       // we are data to the array again to use in the program
                }

            }
            else
            {
                FileStream AccountsFile = File.Create(Acc_File_Path);                  // please remember to close the file here, as the Create gives a open filestream with a lock
                AccountsFile.Close();                                                  // since there is a lock, no other process can use it, even our own. wihtout close, lock exists 
                                                                                       // through out the program run time. remember this.
            }
        }

        public static List<Account> LoadAccountsIntoList()
        {
            try
            {
                List<Account> Temp_List = new List<Account>(); 
                if (File.Exists(Acc_File_Path))         // This is only checking, no handle is opened in the disk so no close needed, and method that return a filestream uses a lock, and we must close it
                {                                                                               // all other functions specifically say that they close the file after each call
                                                                                               // Console.WriteLine("File already Exists");
                    String[] Lines = File.ReadAllLines(Acc_File_Path);
                    // Console.WriteLine("The size of the Lines is = " + Lines.Count());
                    foreach (string line in Lines)
                    {
                        String[] Line_in_parts = line.Split(',');                         // each line read is in a array, and spliting them also makes an array in parts
                        string Numero = Line_in_parts[0];                                 // Now the rest of the program will use the data in the array, that was populated through files
                        int balance = Convert.ToInt32(Line_in_parts[1]);
                        Temp_List.Add(new Account(Numero, balance));                       // we are data to the array again to use in the program
                    }
                    return Temp_List;

                }
                else
                {
                    return new List<Account>();
                }
            }
            catch (Exception ax)
            {
                MessageBox.Show(ax.Message);
                return new List<Account>();
            }

           
        }
    }
}