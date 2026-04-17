using AnkiCardGenerator.Api.Models;

namespace AnkiCardGenerator.Api.Interfaces
{
    public interface IAiProvider
    {
        AiGeneratedContent GenerateContent(string input, string domain, string targetLanguage);

    }
}
