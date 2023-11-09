public abstract class Person
{
   public double Health {get; set;}
   public string Name {get; set;} = "";

   public virtual double CalulateDamage() => 0d;
   public virtual double CalculateDefence() => 0d;

}