Animal[] zoo = [
   new Cat(),
   new Kiwi(),
   new Owl()
];
IMiceHunters[] hunters = [
   new Cat(),
   new Owl()
];



abstract class Animal() 
{

}


abstract class Bird() : Animal 
{
   public virtual bool CanFly => true;
}
interface IMiceHunters // Interfaces start always with I
{
   public void Catch(){}
} // You can not use multible base classes.

class Owl : Bird, IMiceHunters
{
   public void Catch() => Console.WriteLine("Fly-Watch-Catch");
}

class Kiwi : Bird
{
    public override bool CanFly => false;
}
class Cat : Animal, IMiceHunters
{
   public void SayMiau() => Console.WriteLine("Miau");
   public void Catch() => Console.WriteLine("Sneak-Watch-Catch");

}