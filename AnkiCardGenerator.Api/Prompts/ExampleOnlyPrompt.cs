using AnkiCardGenerator.Api.Interfaces;

namespace AnkiCardGenerator.Api.Prompts
{
    public class ExampleOnlyPrompt: IAiPrompt
    {

        public string Name => "example-only";

        public string Build(string input, string domain, string targetLanguage)
        {
            return $"""
        You are helping generate Anki card study content.

        Input: {input}
        Domain: {domain}
        Target language: {targetLanguage}

        Write one short, natural example sentence for this input.
        Keep it concise.
        """;
        }
    }
}
