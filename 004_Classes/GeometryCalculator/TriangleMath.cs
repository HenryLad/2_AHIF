namespace GeometryCalculator;

public  class Triangle
{
    public Triangle(double baselength, double height)
    {
        Baselength = baselength;
        Height = height;
    }
    public double Baselength { get; set; }
    public double Height { get; set; }
    public double CalculateArea =>  Baselength * Height / 2;
    
       
    

    public void Scaled(double factor)
    {
        Baselength *= Math.Sqrt(factor); Height *= Math.Sqrt(factor);
    }
}
