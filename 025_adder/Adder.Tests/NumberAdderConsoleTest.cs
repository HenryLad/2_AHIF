namespace Adder.Tests;

public class NumberAdderConsoleTest
{
   [Fact]
   public void AddingValidNumbers_ShloudPrintSums()
   {
      var nacm = new NumberAdderConsoleMock(new string[] {"5", "6", "q"});

      // Act
      var result = nacm.AggregateEnteredNumbers();

      // Assert

      Assert.Equal(11, result);
         Assert.Equal([
            "Enter numbers : ",
            "The current sum is 5",
            "The current sum is 11",
        ], nacm.Outputs);
    

   }

   [Fact]
   public void AddWithInvalidnumber_ShloudPrintError()
   {
      var nacm = new NumberAdderConsoleMock(new string[] {"5", "diejddijeieod", "q"});

      // Act
      var result = nacm.AggregateEnteredNumbers();

      // Assert

      Assert.Equal(5, result);
         Assert.Equal([
            "Enter numbers : ",
            "The current sum is 5",
            "The number you enterd is not valid.",
        ], nacm.Outputs);
   }
}