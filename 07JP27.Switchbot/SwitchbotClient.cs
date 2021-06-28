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
        private string baseUrl;

        public string BaseUrl
        {
            get { return this.baseUrl; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ServiceException("BaseUrl is missing");
                }

                this.baseUrl = value.TrimEnd('/');
            }
        }

        public SwitchbotClient(string token, string baseUrl = "https://api.switch-bot.com")
        {
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
        
    }
}
