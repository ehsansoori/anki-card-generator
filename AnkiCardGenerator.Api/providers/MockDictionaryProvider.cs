using AnkiCardGenerator.Api.Interfaces;
using AnkiCardGenerator.Api.Models;

namespace AnkiCardGenerator.Api.Providers;

public class MockDictionaryProvider : IDictionaryProvider
{
    public string Name => "default";

    public DictionaryEntry GetEntry(string input, string sourceLanguage, string targetLanguage)
    {
        return new DictionaryEntry
        {
            Input = input,
            Meaning = $"Meaning of {input}",
            Phonetic = $"/{input}/",
            PartOfSpeech = "noun"
        };
    }
}