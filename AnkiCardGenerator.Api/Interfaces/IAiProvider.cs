using AnkiCardGenerator.Api.Models;

namespace AnkiCardGenerator.Api.Interfaces
{
    public interface IAiProvider
    {
        string Name { get; }

        AiGeneratedContent GenerateContent(string input, string domain, string targetLanguage,string promptName);

    }
}
