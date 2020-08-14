using HangMan.Library.Services;

namespace HangMan.ConsoleApp.Factories
{
    public static class WordSelectionFactory
    {
        public static IDetermineWordService DetermineWordService() 
        {
            return new DetermineWordService();
        }
    }
}
