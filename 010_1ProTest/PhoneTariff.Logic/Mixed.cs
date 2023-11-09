namespace PhoneTariff.Logic;

public class Mixed : TariffWithBaseFee
{
   public override decimal MonthlyFee{get; set;}
   public double IncludedMB{get; set;}
   public double PricePerMegaByte{get; set;}

   public Mixed(decimal MonthlyFeeCtor, double IncludedMBCtor, double PricePerMegaByteCtor)
   {
      MonthlyFee = MonthlyFeeCtor;
      IncludedMB = IncludedMBCtor;
      PricePerMegaByte = PricePerMegaByteCtor;
   }

    public override decimal CalulateFee(double MegabyteUsage)
    {
        if(IncludedMB < MegabyteUsage){return MonthlyFee + (((decimal)MegabyteUsage - (decimal)IncludedMB) * (decimal)PricePerMegaByte);}
        else return MonthlyFee;
        
    }
}