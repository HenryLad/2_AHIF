namespace RPG.Logic;

public class AttackSpell : Attack
{
   public string Spell{get; set; } = "";
    public override double CalulateDamage()
    {
        if(Random.Shared.Next(1,9 ) >= 1 && Random.Shared.Next(1,9)  <= 8){return BaseDamage; }
        else return BaseDamage * 0;
    }
}