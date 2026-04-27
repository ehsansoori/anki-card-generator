namespace AnkiCardGenerator.Api.DTOs
{
    public class CardResponseDto
    {
        public string Front { get; set; } = string.Empty;
        public CardBackDto Back { get; set; } = new ();
    }
}
