// BASE CLASS FOR circle, Regtangle, etc.

//only for inhertance can't use directly
public abstract class Shape
{
      public abstract double Area{ get; }
      public abstract void Scale(double factor);
      // Only for descend claasses
      protected double  CalulatedScaledFactor(double factor)
      {
         return Math.Sqrt(factor);
      }
      public virtual double PiFactor()
      {
         return Math.PI;
      }

}