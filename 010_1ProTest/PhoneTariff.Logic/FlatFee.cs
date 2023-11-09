namespace PhoneTariff.Logic;

public class FlatFee : TariffWithBaseFee
{
   public override decimal MonthlyFee{get; set;}
   
    public override decimal CalulateFee(double MegabyteUsage)
    {
        return MonthlyFee;
    }
}