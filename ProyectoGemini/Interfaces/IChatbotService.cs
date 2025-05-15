namespace ProyectoGemini.Interfaces
{
    public interface IChatbotService
    {
        public Task<string> GetChatbotResponseAsync(string prompt);
        public Task<bool> SaveResponseInDatabase(string chatbotPrompt ,string chatBotResponse);
    }
}
