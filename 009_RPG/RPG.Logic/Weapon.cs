
using RPG.Logic;

public class Weapon : Attack
{
    public string Name {get; set;} = "";
    public override double CalulateDamage()
    {
        return BaseDamage * Random.Shared.Next(50, 101) / 100d;
    }
}