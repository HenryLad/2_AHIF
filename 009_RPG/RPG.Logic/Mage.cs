using RPG.Logic;

public class Mage : Person
{
   public AttackSpell Spell{get; set;}

   public Mage(string name, AttackSpell spell)
   {
      Name = name;
      Spell = spell;
   }

    public override double CalulateDamage()
    {
        return Spell.CalulateDamage();
    }
}