using Gemotrie_Caculator;

System.Console.WriteLine("Enter width: ");
double width = double.Parse(System.Console.ReadLine()!);
System.Console.WriteLine("Enter height: ");
double height = double.Parse(System.Console.ReadLine()!);
double area = RectangleMath.CalculateArea(width, height);