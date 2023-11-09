using PhoneTariff.Logic;

System.Console.WriteLine("Enter which Tarif you want [F]latFee, [M]ixed, [P]ayasyouGo :");
char.TryParse(Console.ReadLine()!.ToLower(), out char Type);
Tariff t;

double MegabyteUsage; decimal MonthlyFee; double IncluedMB; double PricePerMB;
switch(Type)
{
   case 'f':
   System.Console.WriteLine("Enter your Flat Fee : ");
   MonthlyFee = decimal.Parse(Console.ReadLine()!);
   System.Console.WriteLine("Enter you MB Usage : ");
   MegabyteUsage = double.Parse(Console.ReadLine()!);
   t = new FlatFee() {MonthlyFee = MonthlyFee};
   break;
   case 'm':
   System.Console.WriteLine("Enter your included MB Amount :");
   IncluedMB = double.Parse(Console.ReadLine()!);
   System.Console.WriteLine("Enter your MB Usage : ");
   MegabyteUsage = double.Parse(Console.ReadLine()!);
   System.Console.WriteLine("Enter your Flat Fee : ");
   MonthlyFee = decimal.Parse(Console.ReadLine()!);
   System.Console.WriteLine("Enter your Price per MB : ");
   PricePerMB = double.Parse(Console.ReadLine()!);
   t = new Mixed(MonthlyFee, IncluedMB, PricePerMB) {MonthlyFee = MonthlyFee};
   break;
   case 'p':
   System.Console.WriteLine("Enter your Price per MB : ");
   PricePerMB = double.Parse(Console.ReadLine()!);
   System.Console.WriteLine("Enter your MB Usage : ");
   MegabyteUsage = double.Parse(Console.ReadLine()!);
   t = new PayasyouGo(PricePerMB);
   break;

   default:
   System.Console.WriteLine("Not a valid Tarif Type !!");
   return;
}
System.Console.WriteLine("Your Tarif costs : " + t.CalulateFee(MegabyteUsage) + " Euro");