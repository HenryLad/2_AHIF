namespace Clothes.Logic
{
   public class BoxinStack
   {
      public string Content { get; set; }
      public BoxinStack? Next { get; set; }

      public BoxinStack(string content, BoxinStack? next)
      {
         Content = content;
         Next = next;
      }
   }

   public class ClothesStack
   {
      public BoxinStack? Top { get; set; }

      public void Push(string content)
      {
         if (Top == null)
         {
            Top = new BoxinStack(content, null);
         }
         else
         {
            Top = new BoxinStack(content, Top);
         }
      }

      public string Pop()
      {
         if(Top == null)
         {
            throw new Exception("The Stack is Empty");
         }
         var temp = Top;
         Top = Top?.Next;
         return temp.Content;
      }

    
   }
}


/*public int Pop(string contentToRemove)
{
   int i = 0;
   if (Top == null)
   {
      // Stack is empty, nothing to pop.
      return i;
   }

   else if (Top.Content == contentToRemove)
   {
      // Remove the top box by updating the Top reference.
      Top = Top.Next;
      i += 1;
   }
   else
   {
      // Remove the box by updating the Next reference of the box above the top box.
      var currentBox = Top;
      var TempBox = Top;

      do
      {
         TempBox = currentBox;
         currentBox = currentBox.Next;

         i++;
      }while (currentBox.Next != null && currentBox.Content != contentToRemove);
      i *= 2;
      Top = currentBox;
   }
   return i;
}
}
*/