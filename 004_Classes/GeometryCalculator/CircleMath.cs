using System.Dynamic;

namespace GeometryCalculator;

public class Circle
{
    //Constructor 
    public Circle(double radius) => Radius = radius;
/*  {
    /Second Method to write 
    Radius = radius;
    }
*/   
    //Property
    public double Radius {get; set;}
    //Caluclted Property 
    public double Area => Math.PI * Radius * Radius;
    
    public void  Scale(double factor)
    {
         Radius *= Math.Sqrt(factor);
    }
}
