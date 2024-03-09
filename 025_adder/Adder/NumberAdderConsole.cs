namespace Adder;

public class NumberAdderConsole
{
   public virtual void WriteLine(string s ) => Console.WriteLine(s);
   public virtual string ReadLine() => Console.ReadLine()!;
   public int  AggregateEnteredNumbers()
   {
      WriteLine("Enter numbers : ");
      var adder = new NumberAdder();
      while(true)
      {
         var input = ReadLine();
         if(input == "q"){ break; }
         
         try{
         adder.Add(int.Parse(input));
         WriteLine($"The current sum is {adder.Sum}");
         }
         catch(OverflowException)
         {
            WriteLine("The number you enterd is too large ");
         }
         catch(FormatException)
         {
            WriteLine("The number you enterd is not valid.");
         }
                 
      }
      return adder.Sum;
   }
}