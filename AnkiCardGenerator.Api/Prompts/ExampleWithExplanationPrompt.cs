using AnkiCardGenerator.Api.Interfaces;

namespace AnkiCardGenerator.Api.Prompts
{
    public class ExampleWithExplanationPrompt: IAiPrompt
    {
        public string Name => "example-with-explanation";

        public string Build(string input, string domain, string targetLanguage)
        {
            return $"""
        You are helping generate Anki card study content.

        Input: {input}
        Domain: {domain}
        Target language: {targetLanguage}

        Write:
        1. one short natural example sentence
        2. a short explanation of the meaning

        Keep the result concise and easy to study.
        """;
        }
    }
}
