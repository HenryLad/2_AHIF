using Queue.Logic;
int choice;
System.Console.WriteLine("What do you want to do ?");
System.Console.WriteLine("1) Add a customer to the queue");
System.Console.WriteLine("2) Seat the next customer");
System.Console.WriteLine("3) Display the queue");
System.Console.WriteLine("4) Exit the programm");

do
{System.Console.Write("Your choice : ");
int.TryParse(Console.ReadLine()!, out choice);


}while(choice != 4);
