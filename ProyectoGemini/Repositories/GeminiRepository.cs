using Newtonsoft.Json;
using ProyectoGemini.Interfaces;
using ProyectoGemini.Models;
using System.Text;

namespace ProyectoGemini.Repositories
{
    public class GeminiRepository : IChatbotService
    {
        private HttpClient _httpClient;
        private string geminiApiKey = "AIzaSyBZFA1dpLS1DejGK4otzvJCCmf1dgSn6SI";
        public GeminiRepository()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> GetChatbotResponseAsync(string prompt)
        {
            string url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=" + geminiApiKey;
            GeminiRequest request = new GeminiRequest
            {
                contents = new List<GeminiContent>
                {
                    new GeminiContent
                    {
                        parts = new List<GeminiPart>
                        {
                            new GeminiPart
                            {
                                text = prompt
                            }
                        }
                    }
                }
            };
            string requestJson = JsonConvert.SerializeObject(request); // Serializar el objeto a JSON
            var content = new StringContent(requestJson, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(url, content);
            var answer = await response.Content.ReadAsStringAsync();

            return answer;
        }

        public Task<bool> SaveResponseInDatabase(string chatbotPrompt, string chatBotResponse)
        {
            throw new NotImplementedException();
        }
    }
}
