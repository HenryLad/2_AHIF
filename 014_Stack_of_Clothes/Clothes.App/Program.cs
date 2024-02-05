using System.Runtime.Intrinsics.X86;
using Clothes.Logic;
using System.IO;
using System;


var Order = new string[] { };

Order = File.ReadAllLines(@"C:\Users\henry\Dropbox\Htl_Leonding\2_Klasse\Programmieren\014_Stack_of_Clothes\operations_short.txt");

 System.Console.WriteLine("MAIN STACK      TEMP STACK");
System.Console.WriteLine("--------------------------");
var c = new ClothesStack();
for (int i = 0; i < Order.Length; i++)
{
   if (Order[i].Split(' ')[0].ToLower() == "incoming")
   {
      c.Push(Order[i].Split(' ')[1]);
   }
   else if (Order[i].Split(' ')[0].ToLower() == "shipping")
   {
       c.Pop();
       c.TempStack(Order[i].Split(' ')[0]);
   }
}
System.Console.WriteLine(c.Top?.Content      );
