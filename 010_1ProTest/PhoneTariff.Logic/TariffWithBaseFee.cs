namespace PhoneTariff.Logic;

public abstract class TariffWithBaseFee : Tariff
{
   public abstract decimal MonthlyFee{get; set;}

}