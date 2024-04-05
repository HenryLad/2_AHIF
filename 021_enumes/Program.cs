/*const int WAGON_PASSENGER = 1;
const int WAGON_LOCOMOTIVE = 2;

var myNewWagon = WagonType.Locomotive;
Console.WriteLine(myNewWagon);
Console.WriteLine((int)myNewWagon);

WagonType myOtherWagon = (WagonType)5;
System.Console.WriteLine("myOtherWagon: " + myOtherWagon);

var fileMode = FileMode.Read | FileMode.Write;
System.Console.WriteLine(fileMode);
fileMode = (FileMode)0b1111;
System.Console.WriteLine(fileMode);
enum WagonType

{
    Passenger,
    Locomotive = 5
}


[Flags]
enum FileMode
{
    Read = 0b0001, 
    Write = 0b0010,
    CreateIfNotExist = 0b0100, 
    DeleteOnClose = 0b1000,
}
*/
// Hash Sets

HashSet<int> Number = [1, 2, 3, 3, 4, 5,5];

foreach (var number in Number)
{
    Console.WriteLine(number);
}
if(Number.Contains(3))
{
    Console.WriteLine("Number 3 is in the set");
}

HashSet<int> Number2 = [1,2,3,4,5];
if(Number.SetEquals(Number2))
{
    Console.WriteLine("Number and Number2 are equal");
}

System.Console.WriteLine(8.8.GetHashCode());
