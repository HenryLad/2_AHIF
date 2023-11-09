using System.Reflection.Metadata.Ecma335;

namespace Banking.Logic;

public abstract class Account
{
   public string AccountNumber = "";
   public string AccountHolder = "";

   public decimal InitalBalance;
   public string TransactionNumber = "";

   public abstract bool IsAllowed(Transaction transaction);
   public DateOnly openingdate;
   public DateOnly ClosingDate; 
   

   public bool TryExeucte(Transaction transaction)
   {
      if(AccountNumber !=  TransactionNumber){return false;}
      else if(!IsAllowed(transaction)){return false;}
      else{InitalBalance += transaction.Amount; return true; }
   }
}