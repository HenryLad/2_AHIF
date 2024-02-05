using Stirnreihe.Data;
string Choice = "";
LineOfPeople l = new LineOfPeople();
Person p;
System.Console.WriteLine("Welcome to the Stirnreihe World Record App! What do you want to do?");
System.Console.WriteLine("1) Add person to the Line");
System.Console.WriteLine("2) Print the Line");
System.Console.WriteLine("3) Clear the Line");
System.Console.WriteLine("4) Exit the Record App");

do
{
   System.Console.Write("Your Choice : ");
   Choice = Console.ReadLine()!;
   switch (Choice)
   {
      case "1":
         System.Console.Write("Enter person firstname : ");
         string firstname = Console.ReadLine()!;
         System.Console.Write("Enter person lastname : ");
         string lastname = Console.ReadLine()!;
         System.Console.Write("Enter ur Height : ");
         int.TryParse(Console.ReadLine(), out int Height);
         p = new Person(firstname,lastname,Height);
         l.AddToFront(p);
         break;
      case "1b":
      
      break;
      case "2":
         if(l.Head == null) {System.Console.WriteLine("The Line is empty");} 
         var current = l.Head;
         do
         {
            System.Console.WriteLine(current?.person?.ToString());
            current = current?.Next;
         }while(current != null);
         break;
      case "3":
      l.Clear();
      break;
   }


} while (Choice != "4");


