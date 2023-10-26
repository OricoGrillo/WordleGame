using WordleGame;

Console.WriteLine("How To Play");
Console.WriteLine("Guess the Wordle in 6 tries.");
Console.WriteLine("");
Console.WriteLine("- Each guess must be a valid 5-letter word.");
Console.WriteLine("- The color of the titles will change to show how close your guess was to the word.");
Console.WriteLine("");

var numtries = 6;
var lengthWord = 5;

var jsonwords = new DeserializeJson().GetValidWords();
var secretWord = jsonwords[new Random().Next(0, jsonwords.Count)];


for (int i = 0; i < numtries; i++)
{
    Console.WriteLine("");
    Console.WriteLine("Enter a guess word!");
    var guessWord = Console.ReadLine();
            
    var validword = jsonwords.Contains(guessWord);


    if (!validword)
    {
        Console.WriteLine("The enter word is not a valid word!");
        Console.WriteLine("");
        continue;
    }
              

    if (guessWord.Length > lengthWord)
    {
        Console.WriteLine("Only words with 5-letter is allowed!");
        continue;
    }

    if (new ValidateWords().FindSecretWord(secretWord, guessWord))
    {
        Console.WriteLine("winner;");
        break;
    }
}

