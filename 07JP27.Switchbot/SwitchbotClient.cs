using _07JP27.Switchbot.Exceptions;
using _07JP27.Switchbot.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace _07JP27.Switchbot
{
    public class SwitchbotClient
    {
        private static HttpClient _client = null;

        public SwitchbotClient(string token, string baseUrl = "https://api.switch-bot.com")
        {
            if (string.IsNullOrEmpty(token)) throw new ServiceException("Token is missing.");

            _client = _client ?? new HttpClient()
            {
                BaseAddress = new Uri(baseUrl)
            };
            _client.DefaultRequestHeaders.Add("Authorization", token);
        }

        public async Task<DeviceListResponse> GetDeviceListAsync()
        {
            HttpResponseMessage response = await _client.GetAsync("/v1.0/devices");
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DeviceListResponse>(responseText);
        }

        public async Task<DeviceStatusResponse> GetDeviceStatusAsync(string deviceId)
        {
            if (string.IsNullOrEmpty(deviceId)) throw new ServiceException("deviceId is missing.");

            HttpResponseMessage response = await _client.GetAsync($"/v1.0/devices/{deviceId}/status");
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<DeviceStatusResponse>(responseText);
        }

        public async Task<SceneListResponse> GetSceneListAsync()
        {
            HttpResponseMessage response = await _client.GetAsync("/v1.0/scenes");
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<SceneListResponse>(responseText);
        }

    }
}
