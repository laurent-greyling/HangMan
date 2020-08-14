using HangMan.ConsoleApp.Factories;
using HangMan.ConsoleApp.Utilities;
using System;

namespace HangMan.ConsoleApp
{
    class Program
    {        
        private static bool _isCorrectAnswer;

        static void Main(string[] args)
        {
            Options.CursorPosition(0, 19);
            Options.UserInstructions();
            Options.CursorPosition(0, 0);

            Gallows.Build();           

            var determineWord = WordSelectionFactory.DetermineWordService();
            var word = determineWord.RandomWordSelection();
            var wordLenght = determineWord.Length(word);

            var anonamyzedWord = AnonymizeWordFactory
                .AnonymizeWordService()
                .Anonymize(wordLenght);

            var evaluateWord = EvaluateWordCharactersFactory.EvaluateWordChactersService();

            Options.CursorPosition(0, 9);
            Console.WriteLine(anonamyzedWord);

            var countIncorrectGuess = 0;

            while (!_isCorrectAnswer && countIncorrectGuess < 7)
            {
                Options.CursorPosition(0, 13);
                Console.WriteLine(ConstantValues.WantToGuessTheWord);

                var wantToGuessTheWord = Console.ReadKey(true).Key;

                if (wantToGuessTheWord == ConsoleKey.Y)
                {
                    Options.ClearLine(15);
                    Console.WriteLine(ConstantValues.GuessTheWord);

                    Options.ClearLine(16);
                    var answer = Console.ReadLine();

                    _isCorrectAnswer = answer.ToLowerInvariant() == word.ToLowerInvariant();

                    if (!_isCorrectAnswer)
                    {
                        Options.Message(ConstantValues.WrongGuess, ConsoleColor.Red);
                        continue;
                    }

                    Options.ClearLine(17);
                    Options.CursorPosition(0, 17);
                    Options.Message(ConstantValues.GameWon, ConsoleColor.Green);
                    continue;
                }

                Options.ClearLine(17);
                Options.ClearLine(15);
                Console.WriteLine(ConstantValues.GuessTheLetter);

                Options.ClearLine(16);
                var result = Console.ReadKey(true).KeyChar;

                var isCharacterPresent = evaluateWord.IsCharacterPresentInWord(word, result);

                anonamyzedWord = evaluateWord.EvaluateCharacter(word, result, anonamyzedWord);

                if (isCharacterPresent)
                {
                    Options.CursorPosition(0, 9);
                    Console.WriteLine(anonamyzedWord);

                    _isCorrectAnswer = anonamyzedWord.ToLowerInvariant() == word.ToLowerInvariant();

                    if (_isCorrectAnswer)
                    {
                        Options.ClearLine(17);
                        Options.Message(ConstantValues.GameWon, ConsoleColor.Green);
                    }

                    continue;
                }

                countIncorrectGuess++;

                Gallows.AddBodyPart(countIncorrectGuess);
                Options.CursorPosition(0, 12);
                Options.IncorrectCharacters(result);
            }

            Options.CursorPosition(0, 31);
            Console.ReadKey();
        } 
    }
}
