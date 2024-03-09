using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace Coin.Checker
{
   


public class Coins()
{
   
   public double Parse(string input)
   {
      string cointInput = input;
      double cointCount = 0;
         if (input.IndexOf('.') != input.LastIndexOf('.'))
         {
            throw new FormatException("There must not be more than 1 Points");
         }
         if (!input.Contains('C') && !input.Contains('E'))
         {
            throw new FormatException("There must be a Unit given by");
         }
         if (input != "2E" && input != "1E" && input != "50C" && input != "20C" && input != "10C")
         {
            throw new Exception("Invalid coin value");
         }
   if(cointInput.Contains('E')){cointCount += double.Parse(cointInput.TrimEnd('E'));}
   else{cointCount += double.Parse(cointInput.TrimEnd('C')) / 100;}

   return (cointCount * 100);
      
   }
}
}