namespace AnkiCardGenerator.Api.Interfaces
{
    public interface IAiPrompt
    {
        string Name { get; }

        string Build(string input, string domain, string targetLanguage);
    }
}
