// Implent in  a clas that will create a list of stundents sorting them by there age if put in and if they are over 40 put them on the failure list.
do{
List<string> Students = [];
System.Console.Write("Enter name : ");
string name = Console.ReadLine()!;
System.Console.Write("Enter age : ");
string age = Console.ReadLine()!;
Students.Insert(Students.Count, $"{name} , {age}");
var SortSt = new SortStudtens(Students);
System.Console.Write("Do you now want to sort the students ? y/n");
string sort = Console.ReadLine()!;
if(sort == "y"){ SortSt.SortByAge();}
else{continue;}



}while(true);
public class SortStudtens( List<string> students)
{
   public void SortByAge()
   {
    for(int i = 1; i <= students.Count(); i += 2)
    {
      if(int.Parse(students[i].Split(',')[1]) > int.Parse(students[i + 1].Split(',')[1]))
      {
         students.Insert(i + 1, students[i].Split(',')[1]);
      }
    }
   }
}