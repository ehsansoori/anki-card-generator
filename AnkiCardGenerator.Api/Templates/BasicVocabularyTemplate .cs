using AnkiCardGenerator.Api.DTOs;
using AnkiCardGenerator.Api.Models;

namespace AnkiCardGenerator.Api.Templates
{
    public class BasicVocabularyTemplate: ICardTemplate
    {
        public string Format(
        string input,
        DictionaryEntry dictionary,
        AiGeneratedContent aiContent,
        GenerateCardsRequestDto request)
        {
            return $"""
            Word: {input}
            Meaning: {dictionary.Meaning}
            Phonetic: {dictionary.Phonetic}
            Part of Speech: {dictionary.PartOfSpeech}
            Example: {aiContent.Example}
            Translation: {aiContent.ExampleTranslation}
            """;
        }
    }
}
