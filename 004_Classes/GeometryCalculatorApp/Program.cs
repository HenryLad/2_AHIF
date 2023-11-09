using System.Net.Http.Headers;
using GeometryCalculator;

Console.Write("Enter the type of the geometric figure ([r]ectangle, [c]ircle, [t]riangle, [e]lippse): ");
var figureType = Console.ReadLine()!;

double width = 0d, height = 0d, radius = 0d, baselength = 0d; double a = 0d; double b = 0d;
switch (figureType)
{
    case "r":
        Console.Write("Enter the width of the rectangle: ");
        width = double.Parse(Console.ReadLine()!);
        Console.Write("Enter the height of the rectangle: ");
        height = double.Parse(Console.ReadLine()!);
        break;
    case "c":
        Console.Write("Enter the radius of the circle: ");
        radius = double.Parse(Console.ReadLine()!);
        break;
    case "t":
        Console.Write("Enter the base of the triangle: ");
        baselength = double.Parse(Console.ReadLine()!);
        Console.Write("Enter the height of the triangle: ");
        height = double.Parse(Console.ReadLine()!);
        break;
    case "e":
        Console.Write("Enter the length for a of the Elippse: ");
        a = double.Parse(Console.ReadLine()!);
        Console.Write("Enter the length for b of the Elippse: ");
        b = double.Parse(Console.ReadLine()!);
        break;

    default:
        Console.WriteLine("Invalid figure type.");
        return;
}

Console.Write("Enter the factor: ");
var factor = double.Parse(Console.ReadLine()!);

switch (figureType)
{
    case "r":
        {
            var rectangle = new Rectangle(width, height);
            Console.WriteLine($"The original area of the rectangle is {rectangle.Area}.");
            rectangle.Scaled(factor);
            
            Console.WriteLine($"The new area of the rectangle with width = {rectangle.Width} and height = {rectangle.Height} the Area is {Math.Round(rectangle.Area), 3}.");
            break;
        }
    case "c":
        {
/*            var area = CircleMath.CalculateArea(radius);
            Console.WriteLine($"The original area of the circle is {area}.");
            var scaledRadius = CircleMath.CalculateScaledDimensions(radius, factor);
            Console.WriteLine($"The new area of the circle with radius = {scaledRadius} is {Math.Round(CircleMath.CalculateArea(scaledRadius), 3)}.");*/
            var circle =  new Circle(radius);
            Console.WriteLine($"The original area of the circle is {circle.Area}.");
            circle.Scale(factor);
            Console.WriteLine($"The new area of the circle with radius = {circle.Radius} is {Math.Round(circle.Area, 3)}.");
            break; 
        }
    case "t":
        {
            var triangle = new Triangle(baselength, height);  
            Console.WriteLine($"The original area of the triangle is {triangle.CalculateArea}.");
            triangle.Scaled(factor);
            Console.WriteLine($"The new area of the triangle with base = {triangle.Baselength} and height = {triangle.Height} is {Math.Round(triangle.CalculateArea), 3}.");
            break;
        }
    case "e":
            var elippse = new Elipsse(a, b);
            System.Console.WriteLine($"The orignal area of the Elipsse was {elippse.Area}");
            elippse.Scaled(factor);
            System.Console.WriteLine($"The new length of  a is {elippse.A} & the new length of b is {elippse.B} & the new area is {elippse.Area} ");
        break;
    default:
        Console.WriteLine("Invalid figure type.");
        break;
}
