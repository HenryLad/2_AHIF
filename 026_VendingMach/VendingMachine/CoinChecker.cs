namespace Coin.Checker
{
   


public class Coins(string input)
{

   public void Parse()
   {
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
      
   }



}
}