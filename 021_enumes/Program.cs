const int WAGON_PASSENGER = 1;
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