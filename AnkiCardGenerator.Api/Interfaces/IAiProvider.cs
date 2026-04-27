using AnkiCardGenerator.Api.DTOs;
using AnkiCardGenerator.Api.Models;

namespace AnkiCardGenerator.Api.Interfaces
{
    public interface IAiProvider
    {
        string Name { get; }

        AiGeneratedContent GenerateContent(string input, GenerateCardsRequestDto request);

    }
}
