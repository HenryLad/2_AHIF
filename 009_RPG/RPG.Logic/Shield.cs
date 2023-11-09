namespace RPG.Logic;

public class Shield : Defence 
{
   public string Name {get; set;} = "";

    public override double CalculateDefence()
    {
        return BaseDefenseValue + (BaseDefenseValue * Random.Shared.Next(75, 101) / 100d);
    }
}