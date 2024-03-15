using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using WordGuesser;
var input = "";
var nowg = 0;
Console.WriteLine("Welcome to Word Guesser!");

// TODO: Ask the user if she wants to play a normal, easy, or hard game.
do
{
   System.Console.WriteLine("Please select the game mode: Normal, Easy, or Hard");
   input = System.Console.ReadLine().ToUpper();

}while(input != "N" && input != "E" && input != "H");


// TODO: Create the proper instance of WordGuess or its derived class based on the user's input.

WordGuess game = input switch
{
    "N" => new WordGuess(),
    "E" => new EasyWordGuess(),
    "H" => new HardWordGuess(),
    _ => throw new NotImplementedException()
};


// TODO: Game loop
// 1. Clear the screen
// 2. Show the current guess and the current number of wrong guesses
// 3. Ask the user to press a letter (use Console.ReadKey().KeyChar)
// 4. If the user's guess is wrong, increment the number of wrong guesses
// 5. Repeat until the word is completed
do
{
    
    System.Console.WriteLine($"The current guess is : {game.CurrentGuess.ToString()}");
    System.Console.WriteLine("Enter the next Letter : ");
    var currentguess = Console.ReadKey().KeyChar;
    if(game.Guess(currentguess) == false){nowg++;}
    System.Console.WriteLine($"Number of wrong guess : {nowg}");
}while(!game.Completed);



// TODO: Show the final result:
// 1. Clear the screen
// 2. Show a message with the guessed word and the number of wrong guesses 

Console.Clear();
System.Console.WriteLine($"The right word was {game.WordToGuess} \nThe number of wrong guess were {nowg}");
