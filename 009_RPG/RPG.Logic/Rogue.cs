
public class Rogue : Person
{
    public Weapon Weapon1 { get; set; }
    public Weapon Weapon2 { get; set; }

    public Rogue(string name, Weapon weapon1, Weapon weapon2)
    {
        Name = name;
        Weapon1 = weapon1;
        Weapon2 = weapon2;
    }

    public virtual double CalculateDamage()
    {
      return Weapon1.CalulateDamage() + Weapon2.CalulateDamage();
   }
}
