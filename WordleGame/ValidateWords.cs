using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordleGame
{
    public  class ValidateWords
    {
        public bool FindSecretWord(string secretWord, string guessWord)
        {
            if (secretWord == guessWord)
            {
                return true;
            }

            List<(string, Position)> results = new List<(string, Position)>();

            for (int i = 0; i < guessWord.Length; i++)
            {
                var position = secretWord.IndexOf(guessWord[i]);
                if (position == -1)
                {
                    results.Add((guessWord[i].ToString(), Position.notexist));
                    Console.Write("\u001b[37m" + guessWord[i].ToString());
                    continue;
                }

                if (secretWord[i] == guessWord[i])
                {
                    results.Add((guessWord[i].ToString(), Position.correctposition));
                    Console.Write("\u001b[32m" + guessWord[i].ToString());
                }
                else
                {
                    results.Add((guessWord[i].ToString(), Position.wrongposition));
                    Console.Write("\u001b[33m" + guessWord[i].ToString());
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;

            return false;
        }
    }

    enum Position
    {
        notexist,
        wrongposition,
        correctposition
    }
}
