namespace CoinHandling.Test;

using Main;

public class CoinHandlingConsoleTest
{
    [Fact]

    public void UserEnteredValidCoinsoThatSheReachestheProductPriceExactly()
    {
        var chc = new CoinHandlingConsoleMock(["4E", "2E", "2E"]);

        var result = chc.HandleCoins();
        Assert.Equal(0, result);
    }
    [Fact]
    public void UserEnteredAnValidConisSoThatSheexecedsTheLimitandGetsChange()
    {
        var chc = new CoinHandlingConsoleMock(["4E", "50C", "2E", "2E"]);

        var result = chc.HandleCoins();

        Assert.Equal(0.5, result);

    }
    [Fact]
    public void UserEnteredAnInvalidCoinssoThatTheProgramGivesUsanError()
    {
        var chc = new CoinHandlingConsoleMock(["4E", "3E"]);


        Assert.Throws<FormatException>(() => chc.HandleCoins());
    }
}