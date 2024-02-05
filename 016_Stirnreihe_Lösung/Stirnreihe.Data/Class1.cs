namespace Stirnreihe.Data;

public class Person(string FName, string NName, int height)
{
   public string FirstName {get;set;} = FName;
   public string SecondName {get; set;} = NName;
   public int Height {get; set;} = height;

    public override string ToString()
    {
        return $"{FirstName} {SecondName} ({Height} cm)";
    }
}
public class Node(Person person, Node? Next)
{
   public Person? person {get; set;} = person;
   public Node? Next  {get; set;} = Next;
}
public class LineOfPeople()
{
   public Node? Head {get; set;}

   public void AddToFront(Person person)
   {
      var NewNode = new Node(person, Head);
      Head = NewNode;
   }
   public void Clear()
   {
      Head = null;
   }  
   public int AddSorted(Person person)
   {
      var Node = new Node(person, null);
      if(Head != null && Node.person.Height < Head.person.Height)
      {
         
      }
   }


   
}