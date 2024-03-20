using System.Globalization;

namespace WordGuesser.Tests;

public class WordGuessMockSingleWord : WordGuess
{
    /// <summary>
    /// Gets the word to guess.
    /// </summary>
    /// <remarks>
    /// This method is overriden to return a single, fixed word instead
    /// of a random word. This is useful for testing purposes.
    /// </remarks>
    public override string GetRandomWord() => "Test";
}

public class WordGuessMockWordGroup : WordGuess
{
    /// <summary>
    /// Gets the word to guess.
    /// </summary>
    /// <remarks>
    /// This method is overriden to return a fixed group of words instead
    /// of a random word. This is useful for testing purposes.
    /// </remarks>
    public override string GetRandomWord() => "Test Test";
}

public class NormalGuessTests
{
    [Fact]

    public void TestCurrentGuessInitialization()
    {
        // Arrange
        var word = new WordGuessMockSingleWord();

        // Act
        string initialGuess = word.CurrentGuess;

        // Assert
        Assert.Equal("____", initialGuess);
    }

    [Fact]
    public void WordGuess_InitializesCurrentGuess_WordGroup()
    {
        var word = new WordGuessMockWordGroup();

        // Act
        string initialGuess = word.CurrentGuess;

        // Assert
        Assert.Equal("____ ____", initialGuess);
    }

    [Fact]
    public void WordGuess_Guess_ReturnsTrue()
    {
        var w = new WordGuessMockSingleWord();

        Assert.True(w.Guess('T'));
    }

    [Fact]
    public void WordGuess_Guess_ReturnsFalse()
    {
        // Use the WordGuessMockSingleWord class to test if
        // the Guess method returns false when the guessed letter is not in the word.
        var w = new WordGuessMockSingleWord();

        Assert.False(w.Guess('K'));
    }
}