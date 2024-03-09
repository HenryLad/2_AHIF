namespace Adder.Tests;

public class NumberAdderTest
{
    [Fact]
    public void Add_WhenCalledWithValidINput_ShloudAddToSum()
    {
        const int value = 5;
        // Arange Step 
        var numberAdder = new NumberAdder();

        // Act State 

        var result = numberAdder.Add(value);

        // Assert State

        Assert.Equal(value, result);
        Assert.Equal(value, numberAdder.Sum);
    }

    [Fact]

    public void Add_SumIsInitallyZero()
    {
        // Arrange 
        var numberAdder = new NumberAdder();

        // Assert
        Assert.Equal(0, numberAdder.Sum);
    }

    [Fact]

    public void Add_ThorwsOverFlowExceptions_WhenSumExceedsMaxValue()
    {
            var numberAdder = new NumberAdder();

            numberAdder.Add(int.MaxValue);


            Assert.Throws<OverflowException>(() => numberAdder.Add(1));
    }
}