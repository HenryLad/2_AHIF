using System.Text;
using Banking.Logic;

System.Console.Write("Enter Account type of account [c]hecking, [b]usiness, [s]avings or [f]ixed Account: ");
var accountType = System.Console.ReadLine() ?? string.Empty;
System.Console.Write("Enter Account Number : ");
string accountNumber = Console.ReadLine() ?? string.Empty;
System.Console.Write("Enter Account Holder : ");
string AccountHolder = Console.ReadLine() ?? string.Empty;
System.Console.Write("Enter Inital Balance  :  " );
decimal amount = decimal.Parse(Console.ReadLine() ?? string.Empty);
if(accountType.ToLower() == "f")
{
    System.Console.WriteLine("Enter OpeningDate : ");
    DateOnly OpeningDate = DateOnly.Parse(Console.ReadLine()?? string.Empty);
    System.Console.WriteLine("Enter Fixed Until Date :");
    DateOnly FixedUntilDate = DateOnly.Parse(Console.ReadLine() ?? string.Empty);
}
System.Console.WriteLine("Enter Transactin Account Number :");
string transactionNumber = Console.ReadLine() ?? string.Empty;
System.Console.Write("Enter Transaction Description : ");
string description = Console.ReadLine() ?? string.Empty;
System.Console.Write("Enter Transaction Amount : ");
decimal transactionAmount = decimal.Parse(Console.ReadLine() ?? string.Empty);
System.Console.Write("Enter Transaction Date : ");
DateTime transactionDate = DateTime.Parse(Console.ReadLine() ?? string.Empty);

Account account = accountType.ToLower() switch
{
    "c" => new CheckingAccount(),
    "b" => new BusinessAccount(),
    "s" => new SavingsAccount(),
    "f" => new FixxedAccount(),
    _ => throw new ArgumentException("Invalid account type", nameof(accountType))
};
Transaction transaction = new Transaction();
transaction.Amount = transactionAmount;
transaction.AccountNumber = transactionNumber;
transaction.Description = description;
transaction.TimeStamp = transactionDate;
account.AccountNumber = accountNumber;
account.InitalBalance = amount;
account.AccountHolder = AccountHolder;
account.TransactionNumber = transactionNumber;

if(account.TryExeucte(transaction)){System.Console.WriteLine($"The transaction was succesfull. Your new Balance is {account.InitalBalance}");}
else{System.Console.WriteLine("The Transaction was not sucessful.");}



