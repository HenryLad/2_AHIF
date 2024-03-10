namespace Main;
using Coin.Checker;
using Change.Calulator;

public class CoinHandlingConsole()
{
    public virtual void WriteLine(string s) => Console.WriteLine(s);

    public virtual string ReadLine() => Console.ReadLine()!;

    public double HandleCoins()
    {


        System.Console.WriteLine("Enter Price Of Product");
        string input = ReadLine();
        var change = new ChangeCalculator();
        var coins = new Coins();
        string Input = "0";
        for (int i = 0; i < input.Length; i++)
        {
            if (char.IsDigit(input[i])) { Input += input[i]; }
        }

        do
        {
            WriteLine("Enter Coins : ");
            string cointInput = ReadLine();
            coins.Parse(cointInput);
            change.AddCoin(cointInput);
            WriteLine($"Current Count : {change.TotalAmount} E");



        } while (change.IsEnoughMoneySetter(Input) == false);

        return change.GetChange(Input);
    }

}