using Rpg.Logic;
using RPG.Logic;

// Some weapons and defenses
var stormbringerBlade = new Weapon { Name = "Stormbringer Blade", BaseDamage = 30 };
var ravenclawBlade = new Weapon { Name = "Ravenclaw Blade", BaseDamage = 28 };
var nightsFang = new Weapon { Name = "Night's Fang", BaseDamage = 9 };
var silentWhisper = new Weapon { Name = "Silent Whisper", BaseDamage = 11 };
var tempestBlade = new Weapon { Name = "Tempest Blade", BaseDamage = 32 };
var starshardLance = new Weapon { Name = "Starshard Lance", BaseDamage = 28 };
var guardianOfDawn = new Shield { Name = "Guardian of Dawn", BaseDefenseValue = 14 };
var bulwarkOfTheAncients = new Shield{ Name = "Bulwark of the Ancients", BaseDefenseValue = 15 };
var starflare = new AttackSpell { Spell = "Starflare", BaseDamage = 50 };
var whisperingDagger1 = new Weapon { Name = "Whispering Dagger", BaseDamage = 10 };
var whisperingDagger2 = new Weapon { Name = "Baselard", BaseDamage = 12 };
var steelwindPlate = new Armor { BaseDefenseValue = 20 };
var celestialAegis = new Armor { BaseDefenseValue = 22 };

// Some brave warriors
var people = new Person[]
{
    new Warrior("Eldric the Brave", stormbringerBlade, bulwarkOfTheAncients),
    new Warrior("Seraphina the Valiant", ravenclawBlade, guardianOfDawn),
    new Warrior("Draven the Ironheart", tempestBlade, steelwindPlate),
    new Warrior("Aeliana the Shieldmaiden", starshardLance, celestialAegis),
    new Mage("Liora the Enchantress", starflare),
    new Rogue("Thalos the Silent", whisperingDagger1, whisperingDagger2),
    new Rogue("Nimue the Shadow", nightsFang, silentWhisper),
};

var Fight = new Fight(people[0],people[1]);
System.Console.WriteLine("Enter Helath of Character 1 : ");
int Helath1 = int.Parse(System.Console.ReadLine() ?? string.Empty );
System.Console.WriteLine("Enter Helath of Character 2 : ");
int Helath2 = int.Parse(System.Console.ReadLine() ?? string.Empty );
Fight.ExecuteFight();
System.Console.WriteLine("We let Eldric the Brave fight against Seraphina the Valiant 100 times. Here are the results:");
System.Console.WriteLine($"Eldric the brave won {Fight.Charc1Wins} Times");
System.Console.WriteLine($"Seraphina the Valiant won {Fight.Charc2Wins} Times");
