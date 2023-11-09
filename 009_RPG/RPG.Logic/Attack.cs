namespace RPG.Logic;

public abstract class Attack
{
   
   public double BaseDamage{get; set;}
   public abstract double CalulateDamage();
 
}