using Garage.Logic;
int selectedOption;
do{
Console.WriteLine("What do you want to do : ");
System.Console.WriteLine("1) Enter a car entry ");
System.Console.WriteLine("2) Enter a car exit ");
System.Console.WriteLine("3) Genrate a report ");
System.Console.WriteLine("4) Exit ");
selectedOption = int.Parse(System.Console.ReadLine()!);
GarageSpot garage = new GarageSpot();
switch(selectedOption)
{
   case 1:
         System.Console.Write("Enter parking spot number : ");
         int parkingSpotNumber = int.Parse(System.Console.ReadLine()!);
         if(garage.IsOcuppied(parkingSpotNumber)){System.Console.WriteLine("The spot is occupied"); continue; }
         System.Console.Write("Enter license plate : ");
         string licensePlate = System.Console.ReadLine()!;   
         System.Console.Write("Enter entry time : ");
         DateTime entryTime = DateTime.Parse(System.Console.ReadLine()!);
         garage.TryOccupy(parkingSpotNumber, licensePlate, entryTime);
   break;
}
}while(selectedOption != 4);
