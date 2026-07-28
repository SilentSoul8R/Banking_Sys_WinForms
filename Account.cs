namespace WinFormsBankingApp { 
class Account
{
        public string accountNumber { get; set; }

        public string accountTitle { get; set; }

        public string cnic { get; set; }
        public int balance { get; set; }

        public Account(String accountNumberp, String accountTitlep, String cnicp, int Initial)
        {
            accountNumber = accountNumberp;
            accountTitle = accountTitlep;
            cnic = cnicp;
            balance = Initial;
        }


    public String Convert_To_Str()
    {
        string str = accountNumber;
        return str;
    }

    // no need for these getter methods, it just made it easier to get this info when adding to the file.



    public int GetBalance()
    {
        return balance;
    }

    public string GetNumber()
    {
        return accountNumber;
    }
}
}