namespace WinFormsBankingApp { 
class Account
{
    public String Numbera;
    public int Balance;

    public Account(String Numberp, int Initial)
    {
        Numbera = Numberp;
        Balance = Initial;
    }


    public String Convert_To_Str()
    {
        string str = Numbera;
        return str;
    }

    // no need for these getter methods, it just made it easier to get this info when adding to the file.

    public int GetBalance()
    {
        return Balance;
    }

    public string GetNumber()
    {
        return Numbera;
    }
}
}