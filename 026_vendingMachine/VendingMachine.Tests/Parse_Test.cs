
namespace VendingMachine.Tests;
using Coin.Checker;
public class Prase
{
    [Fact]
    public void Parse_IfItChecksforUnitError()
    {
        var coin = new Coins();

        Assert.Throws<FormatException>(() => coin.Parse("34"));
    }
    [Fact]
    public void Prase_IfItIsInCorrectFormat()
    {
        var coin = new Coins();

        var exception = Record.Exception(() => coin.Parse("2E")); 
        Assert.Null(exception);

    }
    [Fact]
    public void Prase_IfItHasTwoOrMorePoints()
    {

        var coin = new Coins();

        Assert.Throws<FormatException>(() => coin.Parse("2.2.2E"));

    }
}