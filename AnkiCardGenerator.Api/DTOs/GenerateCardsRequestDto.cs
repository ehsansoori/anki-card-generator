namespace AnkiCardGenerator.Api.DTOs
{
    public class GenerateCardsRequestDto
    {
        public List<string> Words { get; set; } = new();
    }
}
