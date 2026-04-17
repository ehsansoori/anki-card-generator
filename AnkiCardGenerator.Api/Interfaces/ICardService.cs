using AnkiCardGenerator.Api.DTOs;

namespace AnkiCardGenerator.Api.Interfaces
{
    public interface ICardService
    {
        List<CardResponseDto> GenerateCards(GenerateCardsRequestDto request);
    }
}
