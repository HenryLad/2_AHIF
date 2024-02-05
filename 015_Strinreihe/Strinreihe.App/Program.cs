using Strinreihe.Logic;
var Line = new LineOfPeople();
Person p;
int[] PersonInList = new int[] { };
string Choice;

System.Console.WriteLine("Welcome to the Stirnreihe World Record App! What do you want to do?");
System.Console.WriteLine("1) Add person to Line");
System.Console.WriteLine("1b) Add sorted person to Line");
System.Console.WriteLine("2) Print the Line");
System.Console.WriteLine("3) Clear the Line");
System.Console.WriteLine("4) Exit");
do
{

   System.Console.Write("Your Choice :");
   Choice = Console.ReadLine()!;

   switch (Choice)
   {
      case "1":
         System.Console.Write("Enter first Name : ");
         string FirstName = Console.ReadLine()!;
         System.Console.Write("Enter Last Name : ");
         string LastName = Console.ReadLine()!;
         System.Console.Write("Enter Height : ");
         int Height = int.Parse(Console.ReadLine()!);
         p = new Person(FirstName, LastName, Height);
         Line.AddToFront(p);
         break;
      case "1b":
      System.Console.Write("Enter first Name : ");
         FirstName = Console.ReadLine()!;
         System.Console.Write("Enter Last Name : ");
         LastName = Console.ReadLine()!;
         System.Console.Write("Enter Height : ");
         Height = int.Parse(Console.ReadLine()!);
         p = new Person(FirstName, LastName, Height);
         Line.AddSorted (p);
         break;
      case "2":
         if (Line.Head == null) { System.Console.WriteLine("The Queue is Empty"); }
         else
         {

            var CurrentOnTop = Line.Head;
            do
            {
               System.Console.WriteLine(CurrentOnTop.person?.ToString());
               CurrentOnTop = CurrentOnTop?.Next;
            } while (CurrentOnTop != null);

         }
         break;
      case "3":
         Line.Clear();
         break;
   }

} while (Choice != "4");

