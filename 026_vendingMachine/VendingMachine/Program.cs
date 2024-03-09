
using Coin.Checker;
using Change.Calulator;
System.Console.WriteLine("Enter Price Of Product");
string input = Console.ReadLine()!;
var change = new ChangeCalculator();
var coins = new Coins();
string Input = "0";
for (int i = 0; i < input.Length; i++)
{
   if (char.IsDigit(input[i])) { Input += input[i]; }
}

do
{
   System.Console.Write("Enter Coins : ");
   string cointInput = Console.ReadLine()!;
   coins.Parse(cointInput);
   change.AddCoin(cointInput);
   System.Console.WriteLine($"Current Count : {change.TotalAmount } E");



} while (change.IsEnoughMoneySetter(Input) == false);

System.Console.WriteLine($"Your exchange money is :  E");



