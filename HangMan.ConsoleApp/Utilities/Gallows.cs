using System;

namespace HangMan.ConsoleApp.Utilities
{
    public static class Gallows
    {
        /// <summary>
        /// Build the initial gallow
        /// </summary>
        public static void Build()
        {
            Console.WriteLine(ConstantValues.Gallow);
            Options.WordBox();
        }

        /// <summary>
        /// Add body parts to gallow
        /// </summary>
        /// <param name="countIncorrectGuess"></param>
        public static void AddBodyPart(int countIncorrectGuess)
        {
            Options.CursorPosition(0, 0);
            switch (countIncorrectGuess)
            {
                case 1:
                    BodyPart(1, ConstantValues.Rope);
                    break;
                case 2:
                    BodyPart(2, ConstantValues.Head);
                    break;
                case 3:
                    BodyPart(3, ConstantValues.Body);
                    break;
                case 4:
                    BodyPart(3, ConstantValues.RightArm);
                    break;
                case 5:
                    BodyPart(3, ConstantValues.LeftArm);
                    break;
                case 6:
                    BodyPart(4, ConstantValues.RightLeg);
                    break;
                case 7:
                    BodyPart(4, ConstantValues.LeftLeg);
                    Options.GameOver();
                    break;
                default:
                    break;
            }
        }

        private static void BodyPart(int lineNumber, string BodyPart)
        {
            Options.ClearLine(lineNumber);
            Console.WriteLine(BodyPart);
            Options.CursorPosition(0, 7);
            Options.WordBox();
        }
    }
}
