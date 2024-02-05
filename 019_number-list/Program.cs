



using System.Globalization;



/*
inPlace.GenerateNumbers(1, 100);
Console.WriteLine(inPlace.CalculateSum());
inPlace.InsertSumAfterPairs();
Console.WriteLine(inPlace.CalculateSum());
inPlace.RemoveEvenNumbers();
Console.WriteLine(inPlace.CalculateSum());
inPlace.ReplaceWithRunningTotal();
Console.WriteLine(inPlace.CalculateSum());
long result = inPlace.CalculateResult();
Console.WriteLine($"Result: {result}");
public class InPlace(List<long> number)
{
   
   public void GenerateNumbers(long start, long end) 
   {
      for(long i = start; i <= end; i++)
      {
         number.Add(i);
      }
   }

   // Behind each pair of numbers (i.e. after 1 and 2, after 3 and 4, etc.),
   // insert the sum of the number pair.
   //
   // 1
   // 2
   // <<< insert 3
   // 3
   // 4
   // <<< insert 7
   // 5
   // 6
   // <<< insert 11
   // ...
   public  void InsertSumAfterPairs()
    {
        for (int n = 0; n < number.Count - 1; n += 3)
        {
          number.Insert(n + 2, number[n + 1] + number[n]);    
        }
    }

   // Remove all even numbers from the list
   public void RemoveEvenNumbers() 
   {
      for(int n = 1; n < number.Count ; n++)
      {
         if(number[n] % 2 != 0 )
         {
            number.Remove(n);
         }
      }
   }

   // Exchange each number with the running total up until the number.
   public void ReplaceWithRunningTotal() 
   {
    for(int i = 2; i < number.Count() ; i += 2)
      {
         number.Insert(i, number[i - 1 ] + number[i - 2]);
      }      
      number.Add(1);
   }

   // Calculate the sum of all numbers.
   public long CalculateSum() 
   {
      long sum = 0;
      foreach(var n in number)
      {
         sum += n;
      }
      return sum;
      
}
   // Calculate the mean (rounded to 0 decimals) and the sum of all numbers. 
   // Add these three values. This is your result.
   public long CalculateResult() 
   {
      long sum = CalculateSum();
      
      return sum + (long) Math.Round((double)sum / 100, 0); ;

   }
}

*/
// Aufgabe 2 Static
var list = NewList.GenerateNumbers(1, 100);
Console.WriteLine(NewList.CalculateSum(list));
list = NewList.InsertSumAfterPairs(list);
Console.WriteLine(NewList.CalculateSum(list));
list = NewList.RemoveEvenNumbers(list);
Console.WriteLine(NewList.CalculateSum(list));
list = NewList.ReplaceWithRunningTotal(list);
Console.WriteLine(NewList.CalculateSum(list));
var result = NewList.CalculateResult(list);
Console.WriteLine($"Result: {result}");
static class NewList
{
   // Generate a list of numbers between start and end
   public static List<long> GenerateNumbers(long start, long end)
   {
      List<long> numbers = [];
      for (long i = start; i <= end; i++)
      {
         numbers.Add(i);
      }
      return numbers;
   }

   // Behind each pair of numbers, insert the sum of the number pair.
   public static List<long> InsertSumAfterPairs(List<long> numbers)
   {
      List<long> newNumbers = [];
      for (int n = 0; n < numbers.Count - 1; n += 3)
      {
         newNumbers.Insert(n + 2, numbers[n + 1] + numbers[n]);
      }
      return newNumbers;   
   }

   // Remove all even numbers from the list
   public static List<long> RemoveEvenNumbers(List<long> numbers)
   {
      for (int n = 1; n < numbers.Count; n++)
      {
         if (numbers[n] % 2 != 0)
         {
            numbers.Remove(n);
         }
      }
      return numbers;
   }

   // Exchange each number with the running total up until the number.
   public static List<long> ReplaceWithRunningTotal(List<long> numbers)
   {
      for (int i = 2; i < numbers.Count(); i += 2)
      {
         numbers.Insert(i, numbers[i - 1] + numbers[i - 2]);
      }
      numbers.Add(1);
      return numbers;
   }

   // Calculate the sum of all numbers.
   public static long CalculateSum(List<long> numbers)
   {
      long sum = 0;
      foreach (var n in numbers)
      {
         sum += n;
      }
      return sum;
   }

   // Calculate the mean (rounded to 0 decimals) and the sum of all numbers.
   public static long CalculateResult(List<long> numbers)
   {

      long sum = CalculateSum(numbers);
      return sum + (long)Math.Round((double)sum / 100, 0); ;
   }
}
