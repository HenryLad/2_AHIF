namespace PhoneTariff.Logic
{
    public class PayasyouGo : Tariff
    {
        public double PricePerMegaByte { get; set; }
        public PayasyouGo(double PricePerMegaByteParameters)
        {
            PricePerMegaByte = PricePerMegaByteParameters;
        }
        

        public override decimal CalulateFee(double MegabyteUsage)
        {
            return (decimal)MegabyteUsage * (decimal)PricePerMegaByte;
        }

    }
}