using HangMan.Library.Utilities;
using System;
using System.Collections.Generic;

namespace HangMan.Library.Services
{
    public class DetermineWordService : IDetermineWordService
    {
        private readonly List<string> Words = WordDictionary.Words;

        public string RandomWordSelection()
        {
            var randomWordIndex = new Random().Next(Words.Count);

            return Words[randomWordIndex].ToLowerInvariant();
        }

        public int Length(string word)
        {
            return word.Length;
        }
    }
}
