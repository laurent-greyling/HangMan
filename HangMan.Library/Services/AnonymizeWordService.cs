using System.Text;

namespace HangMan.Library.Services
{
    public class AnonymizeWordService : IAnonymizeWordService
    {
        public string Anonymize(int wordLenght)
        {
            var anonymizeDisplayedWord = new StringBuilder();

            for (int i = 0; i < wordLenght; i++)
            {
                anonymizeDisplayedWord.Append("*");
            }

            return anonymizeDisplayedWord.ToString();
        }
    }
}
