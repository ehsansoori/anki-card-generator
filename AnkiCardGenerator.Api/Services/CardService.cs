using AnkiCardGenerator.Api.DTOs;
using AnkiCardGenerator.Api.Interfaces;

namespace AnkiCardGenerator.Api.Services
{
    public class CardService : ICardService
    {
        public List<CardResponseDto> GenerateCards(GenerateCardsRequestDto request)
        {
           var result = new List<CardResponseDto>();
            foreach (var input in request.Inputs)
            {
                result.Add(new CardResponseDto
                {
                    Front =input,
                    Back = $"Generated card for {input} with template {request.TemplateName} in domain {request.Domain} using {request.AiProvider} and {request.DictionaryProvider}"
                });
            }
            return result;
        }
    }
}
