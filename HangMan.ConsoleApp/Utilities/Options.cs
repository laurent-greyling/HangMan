using System;
using System.Text;

namespace HangMan.ConsoleApp.Utilities
{
    public static class Options
    {
        /// <summary>
        /// Write a message in a specified color
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        public static void Message(string message, ConsoleColor color)
        {
            TextColor(color);
            Console.WriteLine(message);
            TextColor(ConsoleColor.White);
        }

        /// <summary>
        /// Set Cursor position
        /// </summary>
        /// <param name="leftPosition"></param>
        /// <param name="topPosition"></param>
        public static void CursorPosition(int leftPosition, int topPosition)
        {
            Console.SetCursorPosition(leftPosition, topPosition);
        }

        /// <summary>
        /// Clear a line at a set position on screen
        /// </summary>
        /// <param name="lineNumber"></param>
        public static void ClearLine(int lineNumber)
        {
            CursorPosition(0, lineNumber);
            Console.Write(new string(' ', Console.WindowWidth));
            CursorPosition(0, lineNumber);
        }

        /// <summary>
        /// Set and write incorrect characters on screen for user
        /// </summary>
        /// <param name="character"></param>
        public static void IncorrectCharacters(char character)
        {
            _incorrectCharacterSet.Append($"{character},");
            Message($"{ConstantValues.IncorrectCharacters}: {_incorrectCharacterSet}", ConsoleColor.Red);
            CursorPosition(0, 9);
        }

        /// <summary>
        /// initial word box that will display the word or hidden value
        /// </summary>
        public static void WordBox()
        {
            Console.WriteLine(ConstantValues.WordBox);
        }

        /// <summary>
        /// Game over text
        /// </summary>
        public static void GameOver()
        {
            CursorPosition(0, 16);
            Message(ConstantValues.GameOver, ConsoleColor.Red);
        }

        private static readonly StringBuilder _incorrectCharacterSet = new StringBuilder();

        private static void TextColor(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public static void UserInstructions()
        {
            TextColor(ConsoleColor.Yellow);
            Console.WriteLine("How to Play:");
            Console.WriteLine("1. Choose if you want to guess the word or not");
            Console.WriteLine("2. If Yes, you will be prompted to guess the word");
            Console.WriteLine("   - If correct, you win");
            Console.WriteLine("   - If incorrect, you must again select if you want to guess the word");
            Console.WriteLine("3. If No, you will be prompted to guess a letter");
            Console.WriteLine("   - Everytime you select a letter you will be asked if you want to select a letter or word");
            Console.WriteLine("   - You can continue to guess a letter or choose to guess the word");
            Console.WriteLine("   - If you continue to select the correct letter, you win");
            Console.WriteLine("   - Incorrectly selected letters will be shown to you so you can remember them");
            Console.WriteLine("4. Game will continue untill your character is hung or you selected correct word");
            TextColor(ConsoleColor.White);
        }
    }
}
