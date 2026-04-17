using AnkiCardGenerator.Api.DTOs;
using AnkiCardGenerator.Api.Interfaces;

namespace AnkiCardGenerator.Api.Services;

public class CardService : ICardService
{
    private readonly IDictionaryProvider _dictionaryProvider;
    private readonly IAiProvider _aiProvider;

    public CardService(IDictionaryProvider dictionaryProvider, IAiProvider aiProvider)
    {
        _dictionaryProvider = dictionaryProvider;
        _aiProvider = aiProvider;
    }

    public List<CardResponseDto> GenerateCards(GenerateCardsRequestDto request)
    {
        var result = new List<CardResponseDto>();

        foreach (var input in request.Inputs)
        {
            var dictionaryEntry = _dictionaryProvider.GetEntry(
                input,
                request.SourceLanguage,
                request.TargetLanguage);

            var aiContent = _aiProvider.GenerateContent(
                input,
                request.Domain,
                request.TargetLanguage);

            var back = $"""
            Meaning: {dictionaryEntry.Meaning}
            Phonetic: {dictionaryEntry.Phonetic}
            Part of Speech: {dictionaryEntry.PartOfSpeech}
            Example: {aiContent.Example}
            Example Translation: {aiContent.ExampleTranslation}
            Notes: {aiContent.Notes}
            """;

            result.Add(new CardResponseDto
            {
                Front = input,
                Back = back
            });
        }

        return result;
    }
}