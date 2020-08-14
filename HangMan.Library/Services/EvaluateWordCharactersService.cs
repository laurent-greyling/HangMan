using System.Text;

namespace HangMan.Library.Services
{
    public class EvaluateWordCharactersService : IEvaluateWordChactersService
    {
        public string EvaluateCharacter(string word, char character, string highightedCharacters)
        {
            var characterShown = new StringBuilder(highightedCharacters);

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i].Equals(character))
                {
                    characterShown[i] = character;
                }
            }

            return characterShown.ToString();
        }

        public bool IsCharacterPresentInWord(string word, char character)
        {
            return word.Contains(character);
        }
    }
}
