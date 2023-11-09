namespace GeometryCalculator;

public class Rectangle : Shape
{
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Width { get; set; }

    public double Height { get; set; }

    public override double Area => Width * Height;

    public override void Scale(double factor)
    {
        Width *= CalulatedScaledFactor(factor);
        Height *= CalulatedScaledFactor(factor);
    }

    public override string ToString()
    {
        return $"Regtangle width = {Width} & height = {Height}";
    }
}
