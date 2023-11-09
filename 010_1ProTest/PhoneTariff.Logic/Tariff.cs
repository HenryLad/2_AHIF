namespace PhoneTariff.Logic;

public abstract class Tariff
{
   public abstract decimal CalulateFee(double MegabyteUsage);
}
