using AnkiCardGenerator.Api.DTOs;
using AnkiCardGenerator.Api.Models;

namespace AnkiCardGenerator.Api.Templates
{
    public interface ICardTemplate
    {
        string Name { get; }

        CardBackDto Format(
            string input,
            DictionaryEntry dictionary,
            AiGeneratedContent aiContent,
            GenerateCardsRequestDto request);
    }
}
