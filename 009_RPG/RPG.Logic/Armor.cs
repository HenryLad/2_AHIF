
using System.ComponentModel;
using RPG.Logic;

public class Armor : Defence
{
    public override double CalculateDefence()
    {
        return BaseDefenseValue;
    }
}