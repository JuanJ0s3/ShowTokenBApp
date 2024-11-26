using System.Text;
using Newtonsoft.Json;
using ShowTokenBApp.Core.Entities.Token;
using ShowTokenBApp.Services.Interfaces;

namespace ShowTokenBApp.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly HttpClient _httpClient;

        public AuthenticationService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<bool> AuthenticateAsync(string username, string password)
        {
           var credentials = new {username, password};
            var content = new StringContent(JsonConvert.SerializeObject(credentials), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("https://localhost:7025/api/Authentications/login", content);

            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                var tokenResponse = JsonConvert.DeserializeObject<TokenResponse>(json);

                await SecureStorage.SetAsync("jwt_token", tokenResponse.Token);

                return true;
            }

            return false;
        }
    }
}
