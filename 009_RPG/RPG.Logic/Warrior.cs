
using RPG.Logic;

public class Warrior : Person
{
   public Attack Attack {get; set;}
   public Defence Defence{get; set;}

   public Warrior(string name, Attack attack, Defence defence)
   {
      Name = name;
      Attack = attack;
      Defence = defence;
   }

    public override double CalculateDefence() {return Defence.CalculateDefence();}
    public override double CalulateDamage() {return Attack.CalulateDamage();}

    


}