namespace HangMan.Library.Services
{
    public interface IDetermineWordService
    {
        /// <summary>
        /// Select a random word from <see cref="WordDictionary"/>
        /// </summary>
        /// <returns></returns>
        string RandomWordSelection();

        /// <summary>
        /// Lenght of the word
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        int Length(string word);
    }
}
