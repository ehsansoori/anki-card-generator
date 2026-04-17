using AnkiCardGenerator.Api.DTOs;
using AnkiCardGenerator.Api.Interfaces;
using AnkiCardGenerator.Api.Templates;

namespace AnkiCardGenerator.Api.Services;

public class CardService : ICardService
{
    private readonly IDictionaryProvider _dictionaryProvider;
    private readonly IAiProvider _aiProvider;
    private readonly ICardTemplate _cardTemplate;

    public CardService(IDictionaryProvider dictionaryProvider, IAiProvider aiProvider, ICardTemplate template)
    {
        _dictionaryProvider = dictionaryProvider;
        _aiProvider = aiProvider;
        _cardTemplate = template;
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

            var back = _cardTemplate.Format(
            input,
            dictionaryEntry,
            aiContent,
            request);

            result.Add(new CardResponseDto
            {
                Front = input,
                Back = back
            });
        }

        return result;
    }
}