namespace GeometryCalculator;

public class Elipsse
{
public Elipsse(double a, double b)
{
   A = a;
   B = b;
}

public double A { get; set; }
public double B { get; set; }

public double Area => Math.PI * A * B;

public void Scaled(double factor)
{
   A *= Math.Sqrt(factor); B *= Math.Sqrt(factor);
}

}