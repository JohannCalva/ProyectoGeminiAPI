using ProyectoGemini.Interfaces;

namespace ProyectoGemini.Repositories
{
    public class OpenAIRepository : IChatbotService
    {
        public Task<string> GetChatbotResponseAsync(string prompt)
        {
            throw new NotImplementedException();
        }
        public Task<bool> SaveResponseInDatabase(string chatbotPrompt, string chatBotResponse)
        {
            throw new NotImplementedException();
        }
    }
}
