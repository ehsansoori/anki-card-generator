using AnkiCardGenerator.Api.Interfaces;

namespace AnkiCardGenerator.Api.Factories
{
    public class AiPromptFactory
    {
        private readonly IEnumerable<IAiPrompt> _prompts;

        public AiPromptFactory(IEnumerable<IAiPrompt> prompts)
        {
            _prompts = prompts;
        }

        public IAiPrompt GetPrompt(string name)
        {
            var prompt = _prompts.FirstOrDefault(p =>
                string.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase));

            if (prompt == null)
                throw new Exception($"Prompt '{name}' not found");

            return prompt;
        }
    }
}
