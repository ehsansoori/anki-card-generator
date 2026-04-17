using AnkiCardGenerator.Api.Interfaces;
using AnkiCardGenerator.Api.Models;

namespace AnkiCardGenerator.Api.Providers;

public class MockAiProvider : IAiProvider
{
    public AiGeneratedContent GenerateContent(string input, string domain, string targetLanguage)
    {
        return new AiGeneratedContent
        {
            Example = $"Example sentence with {input}",
            ExampleTranslation = $" translate for: {input}",
            Notes = $"Mock note for {input}"
        };
    }
}