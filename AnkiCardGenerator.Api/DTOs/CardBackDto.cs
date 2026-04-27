namespace AnkiCardGenerator.Api.DTOs
{
    public class CardBackDto
    {
        public string Word { get; set; } = string.Empty;
        public string? Meaning { get; set; }
        public string? Phonetic { get; set; }
        public string? PartOfSpeech { get; set; }
        public string? TargetMeaning { get; set; }
        public string? EnglishMeaning { get; set; }
        public List<ExampleDto> Examples { get; set; } = new();
    }
}
