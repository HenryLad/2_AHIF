namespace Strinreihe.Logic;

public class Person(string firstname, string lastname, int height) : Object
{
   public string FirstName { get; set; } = firstname;
   public string LastName { get; set; } = lastname;

   public int Height { get; set; } = height;

   public override string ToString()
   {

      return $"{FirstName.ToString()} {LastName.ToString()} ({Height.ToString()} cm)";
   }
}

public class Node(Person person, Node? next = null)
{
   public Person? person { get; set; } = person;
   public Node? Next { get; set; } = next;

}
public class LineOfPeople

{
   public Node? Head { get; set; } = null;

   public void AddToFront(Person person)
   {
      var NewNode = new Node(person, Head);
      Head = NewNode;
   }
   public void Clear()
   {
      Head = null;
   }
   // Aus ihrer Solution
   public int AddSorted(Person person)
   {
      // Erstelle einen neuen Knoten mit der übergebenen Person
      var newNode = new Node(person);

      // Wenn die Liste leer ist oder die Höhe der Person kleiner ist als die des ersten Knotens
      if (Head == null || Head?.person?.Height > newNode?.person?.Height)
      {
         // Setze den nächsten Knoten des neuen Knotens auf den aktuellen Kopf der Liste
         newNode.Next = Head;

         // Setze den Kopf der Liste auf den neuen Knoten
         Head = newNode;

         // Da der neue Knoten nun der erste in der Liste ist, geben wir 0 zurück
         return 0;
      }
      else
      {
         // Beginne mit dem Kopf der Liste
         var current = Head;

         // Initialisiere den Index auf 0
         var index = 0;

         // Durchlaufe die Liste, bis wir einen Knoten finden, dessen Höhe größer ist als die des neuen Knotens
         while (current?.Next != null && current?.Next?.person?.Height <= newNode?.person?.Height)
         {
            // Gehe zum nächsten Knoten
            current = current.Next;

            // Erhöhe den Index
            index++;
         }

         // Setze den nächsten Knoten des neuen Knotens auf den Knoten, der größer ist als der neue Knoten
         newNode.Next = current.Next;

         // Setze den nächsten Knoten des aktuellen Knotens auf den neuen Knoten
         current.Next = newNode;

         // Da wir den neuen Knoten nach dem aktuellen Knoten eingefügt haben, geben wir index + 1 zurück
         return index + 1;
      }
   }

}