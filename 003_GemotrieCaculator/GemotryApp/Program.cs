using GemotryCaulatorLogic;

System.Console.WriteLine("Please choose a Option 1) [R]egtangle 2) [C]ircle 3) [T]riangle: ");
string Choice = Console.ReadLine()!.ToLower();

double width = 0; double height = 0; double baselength = 0; double radius = 0; double factor = 0; double result;
switch(Choice)
{
   case "r": 
      System.Console.Write("Please enter width : ");
      width = double.Parse(Console.ReadLine()!);
      System.Console.Write("Please enter height : ");
      height = double.Parse(Console.ReadLine()!);
   break;
   case "c":
      System.Console.Write("Please enter a radius : ");
      radius = double.Parse(Console.ReadLine()!);
   break;
   case "t":
      System.Console.Write("Please enter length for baseline : ");
      baselength = double.Parse(Console.ReadLine()!);
      System.Console.Write("Please enter height : ");
      height = double.Parse(Console.ReadLine()!);
   break;


}

System.Console.Write("Please enter a factor : ");
factor = double.Parse(Console.ReadLine()!);
switch(Choice)
{
   case "r":
   result = RectangleMath.CalculateArea(width,height);
   System.Console.WriteLine($"Old : w = {width}, h = {height}, A = {result}");
   width = RectangleMath.CalculateScaledDimensions(width, height, factor).width;
   height = RectangleMath.CalculateScaledDimensions(width, height, factor).height;
   System.Console.WriteLine($" New : w = {Math.Round(width)}, h = {Math.Round(height)}, A = {Math.Round(width * height)}, f = {factor}");
   break;
   case "c":
   result = CircleMath.CalculateArea(radius);
   System.Console.WriteLine($"Old : r = {radius}, A = {result}");
   result = CircleMath.CalculateScaledDimensions(radius, factor);
   System.Console.WriteLine($" New : r = {Math.Round(radius)}, A = {Math.Round(result)}, f = {factor}");
   break;
   case "t":
   result = TriangleMath.CalculateArea(baselength, height);
   System.Console.WriteLine($"Old : b = {baselength}, h = {height}, A = {result}");
   height = TriangleMath.CalculateScaledDimensions(baselength,height,factor).height;
   baselength = TriangleMath.CalculateScaledDimensions(baselength,height,factor).baseLength;
   System.Console.WriteLine($" New : b = {Math.Round(baselength)}, h = {Math.Round(height)}, A = {Math.Round((baselength * height) / 2)}, f = {factor}");
   break;
   default:
   System.Console.WriteLine("Not a vailabe Option");
   break;
}