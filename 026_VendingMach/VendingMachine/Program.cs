﻿



using Coin.Checker;
System.Console.WriteLine("Enter Price Of Product");
string input = Console.ReadLine()!;

input = input.Substring(0, 1);
double cointCount = 0;

do
{
   System.Console.Write("Enter Coins : ");
   string cointInput = Console.ReadLine()!;
   var coins = new Coins(cointInput);
   coins.Parse();
   if(cointInput.Contains('E')){cointCount += double.Parse(cointInput.TrimEnd('E'));}
   else{cointCount += double.Parse(cointInput.TrimEnd('C')) / 100;}
   System.Console.WriteLine($"Current Count : {(double)cointCount} E");
   
   

} while ( int.Parse(input) > cointCount  );

System.Console.WriteLine($"Your exchange money is : {Math.Round((double)cointCount - double.Parse(input), 2)} E");



