namespace HangMan.Library.Services
{
    public interface IEvaluateWordChactersService
    {
        /// <summary>
        /// Evaluate the selected user character and if it is a match to the random selected word
        /// </summary>
        /// <param name="word"></param>
        /// <param name="character"></param>
        /// <param name="highightedCharacters"></param>
        /// <returns></returns>
        string EvaluateCharacter(string word, char character, string highightedCharacters);

        /// <summary>
        /// Checks if a character is present
        /// </summary>
        /// <param name="word"></param>
        /// <param name="character"></param>
        /// <returns></returns>
        bool IsCharacterPresentInWord(string word, char character);
    }
}
