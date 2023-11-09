using System.Threading.Tasks.Dataflow;

namespace Banking.Logic;

public class SavingsAccount : Account
{
    public override bool IsAllowed(Transaction transaction)
    {
        if(InitalBalance - transaction.Amount < 0 || InitalBalance + transaction.Amount > 1000000 ){return false;}
        else {return true;}
    }
}