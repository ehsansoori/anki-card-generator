using AnkiCardGenerator.Api.DTOs;
using AnkiCardGenerator.Api.Interfaces;
using AnkiCardGenerator.Api.Templates;

namespace AnkiCardGenerator.Api.Services;

public class CardService : ICardService
{
    private readonly IDictionaryProvider _dictionaryProvider;
    private readonly IAiProvider _aiProvider;
    private readonly TemplateFactory _templateFactory;
    public CardService(IDictionaryProvider dictionaryProvider, IAiProvider aiProvider, TemplateFactory templateFactory)
    {
        _dictionaryProvider = dictionaryProvider;
        _aiProvider = aiProvider;
        _templateFactory = templateFactory;
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

            var template = _templateFactory.GetTemplate(request.TemplateName);

            var back = template.Format(
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