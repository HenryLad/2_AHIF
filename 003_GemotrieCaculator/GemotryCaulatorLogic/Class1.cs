namespace GemotryCaulatorLogic;

public static class RectangleMath
{
   public static double CalculateArea(double width, double height)
   {
      return width * height;
   }
   public static (double width, double height) CalculateScaledDimensions(double width, double height, double factor)
   {
      return(width * Math.Sqrt(factor), height * Math.Sqrt(factor));
   }
}
public static class CircleMath
{
   public static double CalculateArea(double radius)
   {
      return (radius * radius) * Math.PI;
   }
   public static double CalculateScaledDimensions(double radius, double factor)
   {
      return(((radius * radius) * Math.Sqrt(factor) ) * Math.PI);
   }
}
public static class TriangleMath
{
   public static double CalculateArea(double baselength, double height)
   {
      return (baselength * height) / 2;
   }
   public static (double baseLength, double height) CalculateScaledDimensions(double baseLength, double height, double factor)
   {
      return(baseLength * Math.Sqrt(factor), height * Math.Sqrt(factor));
   }
}


