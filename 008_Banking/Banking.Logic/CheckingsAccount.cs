using Banking.Logic;

public class CheckingAccount : Account
{
    public override bool IsAllowed(Transaction transaction)
    {
        if(transaction.Amount > 10_000 || InitalBalance - transaction.Amount < -10000 || InitalBalance + transaction.Amount > 10_000_00){return false;}
        else{return true;}
    }
}