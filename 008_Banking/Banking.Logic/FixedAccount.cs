namespace Banking.Logic;

public class FixxedAccount : Account
{
    public override bool IsAllowed(Transaction transaction)
    {
        // Convert ClosingDate & openingDate to DateTime
        DateTime CloseDate = new DateTime(ClosingDate.Year, ClosingDate.Month, ClosingDate.Day);
        DateTime OpenDate = new DateTime(openingdate.Year, openingdate.Month, openingdate.Day);

        // Check if the transaction is within the opening and closing date
        if (transaction.TimeStamp > CloseDate || transaction.TimeStamp == OpenDate)
        {
            if (InitalBalance - transaction.Amount < 0 || InitalBalance + transaction.Amount > 10_000_000)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        else
        {
            return false;
        }
    }
}