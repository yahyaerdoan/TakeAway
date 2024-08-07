using Newtonsoft.Json;
using NuGet.Protocol.Plugins;
using System.Text;
using TakeAway.UserInterface.Models.IdentityServices.IdentityViewModels;
using TakeAway.UserInterface.Services.Abstractions.IdentityServices;

namespace TakeAway.UserInterface.Services.Concretions.IdentityServices;

public class IdentityService(HttpClient httpClient) : IIdentityService
{
    private readonly HttpClient _httpClient = httpClient;

    public async Task<bool> LogIn(LogInViewModel logInViewModel)
    {
        var json = JsonConvert.SerializeObject(logInViewModel);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync("https://localhost:5001/api/logins", content);
        if (response.IsSuccessStatusCode)
        {
            var jsonData = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<LogInResponse>(jsonData);
            return result.Success;
        }

        return false;
    }

    private class LogInResponse
    {
        public bool Success { get; set; }

    }
}
