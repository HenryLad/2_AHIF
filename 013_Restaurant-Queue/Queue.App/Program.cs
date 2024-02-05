using Microsoft.VisualBasic;
using Queue.Logic;
int choice;
var Qutput = new string[] {};
CustomerInQueue? first = null;
CustomerInQueue? last = null;
System.Console.WriteLine("What do you want to do ?");
System.Console.WriteLine("1) Add a customer to the queue");
System.Console.WriteLine("2) Seat the next customer");
System.Console.WriteLine("3) Display the queue");
System.Console.WriteLine("4) Write the Queue in a .txt File");
System.Console.WriteLine("5) Print the Queue in a .txt File");
System.Console.WriteLine("6) Exit the programm");

do
{
   System.Console.Write("Your choice : ");
   int.TryParse(Console.ReadLine()!, out choice);
   switch (choice)
   {
      case 1:
         System.Console.Write("Enter Customer Name : ");
         string CustomerName = Console.ReadLine()!;
         System.Console.Write("Enter Coustomer Phone :");
         string CustomerPhoneNumber = Console.ReadLine()!;
         AddCoustomer(CustomerName, CustomerPhoneNumber);
         break;
      case 2:
         SubtractCustomer();
         break;
      case 3:
         PrintCustomer();
         break;
      case 4:
         WriteTheQueue();
         break;
      case 5:	
         PrintTheQueue();
         break;
   }

} while (choice != 4);
void AddCoustomer(string CustomerName, string CustomerPhoneNumber)
{
   var q = new CustomerInQueue(CustomerName, CustomerPhoneNumber, null);
   if (first == null) { first = q; last = q; }
   else
   {
      last!.Next = q;
      last = q;
   }

}
void SubtractCustomer()
{
   if (first == null) { System.Console.WriteLine("The queue is empty"); }
   else
   {
      var customerToSeat = first;
      first = first.Next;
      if (first != null) { System.Console.WriteLine($"Seating {first.Name} {first.PhoneNumber}"); }
      else { System.Console.WriteLine($"Seated {customerToSeat.Name} {customerToSeat.PhoneNumber}. The queue is now empty."); }
   }
}
void PrintCustomer()
{
   while (first != null)
   {
      int i = 0;
      System.Console.WriteLine($"{i++}{first!.Name} ({first.PhoneNumber})");
      first = first.Next;

   }
}
void WriteTheQueue()
{
   var current = first;
   string text = "";
   while (current != null)
   {
      text += $"{current.Name} ({current.PhoneNumber})\n";
      File.WriteAllText(@"C:\Users\henry\Dropbox\Htl_Leonding\2_Klasse\Programmieren\013_Restaurant-Queue\Queue.App\Costumer.txt", text);
      current = current.Next;

   }
}
void PrintTheQueue()
{
   Qutput = File.ReadAllLines(@"C:\Users\henry\Dropbox\Htl_Leonding\2_Klasse\Programmieren\013_Restaurant-Queue\Queue.App\Costumer.txt");
   for(int i = 0; i < Qutput.Length; i++)
   {
      System.Console.WriteLine(Qutput[i]);
      
   }
}
