using AnkiCardGenerator.Api.Models;

namespace AnkiCardGenerator.Api.Interfaces
{
    public interface IDictionaryProvider
    {
        string Name { get; }
        DictionaryEntry GetEntry(string input, string sourceLanguage, string targetLanguage);

    }
}
