using AnkiCardGenerator.Api.DTOs;
using AnkiCardGenerator.Api.Interfaces;

namespace AnkiCardGenerator.Api.Services
{
    public class CardService : ICardService
    {
        public List<CardResponseDto> GenerateCards(List<string> words)
        {
            return words.Select(word => new CardResponseDto
            {
                Front = word,
                Back = $"Meaning of {word} (mock data)"
            }).ToList();
        }
    }
}
