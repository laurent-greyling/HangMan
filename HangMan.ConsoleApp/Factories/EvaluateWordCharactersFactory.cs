using HangMan.Library.Services;

namespace HangMan.ConsoleApp.Factories
{
    public static class EvaluateWordCharactersFactory
    {
        public static IEvaluateWordChactersService EvaluateWordChactersService()
        {
            return new EvaluateWordCharactersService();
        }
    }
}
