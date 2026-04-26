using AnkiCardGenerator.Api.Interfaces;
using AnkiCardGenerator.Api.Models;

namespace AnkiCardGenerator.Api.Providers;

public class MockAiProvider : IAiProvider
{
    public string Name => "default";

    public AiGeneratedContent GenerateContent(string input, string domain, string targetLanguage,string promptName)
    {
        //throw new Exception("MockAiProvider is being used");

        return new AiGeneratedContent
        {
            Content = $"Mock generated content for '{input}'",
            Provider = Name,
            TargetLanguage = targetLanguage,
            Domain = domain,
            PromptName = promptName
        };
    }
}
