namespace Change.Calulator;

public class ChangeCalculator()
{
   
   public double TotalAmount { get; private set; } = 0;

   public bool IsEnoughMoney { get; private set; } = false;

   public void AddCoin(string cents)
   {
      string Input = "0";
      for(int i = 0; i < cents.Length; i++)
      {
         if(char.IsDigit(cents[i])){Input += cents[i];}
      }
      if(cents.Contains('C')){TotalAmount += checked(int.Parse(Input) / 100);}
      else{TotalAmount += checked(int.Parse(Input));}
   }

   public double GetChange(string input)
   {
      string Input = "0";
      for(int i = 0; i < input.Length; i++)
      {
         if(char.IsDigit(input[i])){Input += input[i];}
      }
      if (TotalAmount - int.Parse(Input) < 0)
      {
         throw new InvalidOperationException("You have not entered engouh money to get change");
      }
      else
      {
         return TotalAmount - int.Parse(Input);
      }
   }

}
