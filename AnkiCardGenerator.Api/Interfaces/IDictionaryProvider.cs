using AnkiCardGenerator.Api.Models;

namespace AnkiCardGenerator.Api.Interfaces
{
    public interface IDictionaryProvider
    {
        DictionaryEntry GetEntry(string input, string sourceLanguage, string targetLanguage);

    }
}
