List<int> numbers = [1,2,324,]; // List is a generic class and <int> is the Type parameter
List<string> names = ["Tim", "Moin Diggi"];
List<Point> points = [];



numbers.Add(4); // Addes the number 4

foreach(var n in numbers)
{
   Console.WriteLine(n); // Prints all numbers
}
Console.WriteLine(numbers[0]); //Writes the number in the index


numbers.Insert(0, -24); // Instert the number at the index

numbers.RemoveAt(0); // Remove the number at the index

numbers.Remove(4);


numbers = [1,2,3];
var numbers2 = numbers;
numbers[0] = 5;

var numbers3 = numbers.ToList();
numbers3[0] = 10;

// LINQ = Language Integrated Query
var sum = numbers.Sum();
var avg = numbers.Average();
var max = numbers.Max();
var min = numbers.Min();
var first = numbers.First();
var last = numbers.Last();
var count = numbers.Count();

record Point(int y, int x);
