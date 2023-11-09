
// Abstract Base class, only for inheritance
var cat = new Cat();
cat.Purr();
Animals animal;
var animalType = Random.Shared.Next(2);
switch(animalType)
{
   case 0: animal = new Cat(); break;
   case 1: animal = new Dog(); break;
   default : return;
}
animal.MakeSound();
System.Console.WriteLine(animal.Legs);


Animals[] zoo = new Animals[] {new Dog(), new Cat(), new Sheep()};
foreach(var a in zoo)
{
   //Polymorphismus
   a.MakeSound();
}
 //Dieser Code erstellt eine Instanz der Klasse Cat und weist sie der Variablen cat zu. 
//Dann wird eine neue Variable animal vom Typ Animals erstellt und mit einer neuen Instanz von Cat initialisiert. 
//Da Cat von Animals erbt, ist dies möglich.
abstract class Animals
{
   public abstract int Legs {get;}
   public abstract void MakeSound(); // All desendent classes MUST invokte the MakeSound Method

    public override string ToString()
    {
      return "I am an Animal";
    }

    public abstract bool Likes(Animals other);
}
// Cat is a derived class from Animal
// Animal is the base class of cat
class Cat : Animals
{
    public override void MakeSound() => System.Console.WriteLine("Meww");
    public override int Legs => 4;
    public void Purr()
    {
      System.Console.WriteLine("Purrrr");
    }

    public override string ToString()
    {
        return "I am a cat";
    }
    public override bool Likes(Animals other)
    {
        // Cats like Cats
        return other is Cat;
    }
}


class Dog : Animals
{
   public override void MakeSound() => System.Console.WriteLine("Bark");
   public override int Legs => 4;

   public override string ToString()
    {
        return "I am a dog";
    }

    public override bool Likes(Animals other)
    {
        return other is Cat or Sheep;
    }
}
// Mermaid.live is an editor for clases
class Sheep : Animals
{
   public override void MakeSound() => System.Console.WriteLine("Mähhh");
   public override int Legs => 4;

   public override string ToString()
    {
        return "I am a Sheep";
    }

    public override bool Likes(Animals other)
    {
        return other is Sheep;
    }
}