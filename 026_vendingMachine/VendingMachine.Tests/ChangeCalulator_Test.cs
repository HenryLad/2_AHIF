using Change.Calulator;
using Main;

namespace Change.Test;

public class Change_Test
{
    [Fact]
    public void CheckIfThe_TotalAmout_IsZeroAttheBeginning()
    {
        var change = new ChangeCalculator();

        Assert.Equal(0, change.TotalAmount);
    }
    [Fact]
    public void CheckIfTheAmount_IsAddedCorectly()
    {
        var change = new ChangeCalculator();

        change.AddCoin("5");

        Assert.Equal(5, change.TotalAmount);
    }

    [Fact]
    public void CheckIfTheIsEnoughMoneyProp_ReturnsFalse_whenthereisnotEngouhMoney()
    {
        var change = new ChangeCalculator();

        Assert.False(change.IsEnoughMoney);
    }
    [Fact]
    public void CheckIfTheIsEngouhMoneyProp_ReturnsTrue_whentereisEngouhMoney()
    {
        var change = new ChangeCalculator();

        change.AddCoin("5.5");

        change.IsEnoughMoneySetter("5");

        Assert.True(change.IsEnoughMoney);
    }

    [Fact]
    public void TestHandleCoinsReturnsCorrectChange()
    {
        // Arrange
        var console = new CoinHandlingConsole();
        var change = new ChangeCalculator();
        
        change.AddCoin("5");
        Assert.Equal(1, console.HandleCoins());
    }
    [Fact]
    public void CheckIfTheChangeIsThrowsAnException()
    {
        var change = new ChangeCalculator();

        change.AddCoin("4");

        Assert.Throws<InvalidOperationException>(() => change.GetChange("5"));
    }
}