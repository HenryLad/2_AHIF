namespace Banking.Logic;

public class BusinessAccount : Account
{
    public override bool IsAllowed(Transaction transaction)
    {
        if(transaction.Amount > 100_000 || InitalBalance - transaction.Amount < -1_000_000 || InitalBalance + transaction.Amount > 100_000_000){return false;}
        else{return true;}
    }
}