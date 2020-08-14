namespace HangMan.Library.Services
{
    public interface IAnonymizeWordService
    {
        /// <summary>
        /// Anonymize the word based off the lenght of the word
        /// </summary>
        /// <param name="wordLenght"></param>
        /// <returns></returns>
        public string Anonymize(int wordLenght);
    }
}
