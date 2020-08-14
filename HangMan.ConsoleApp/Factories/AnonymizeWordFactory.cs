using HangMan.Library.Services;

namespace HangMan.ConsoleApp.Factories
{
    public static class AnonymizeWordFactory
    {
        public static IAnonymizeWordService AnonymizeWordService()
        {
            return new AnonymizeWordService();
        }
    }
}
