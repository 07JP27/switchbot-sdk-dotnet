using DoinJomain.Switchbot.Exceptions;
using DoinJomain.Switchbot.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DoinJomain.Switchbot
{
    public class SwitchbotClient: IDisposable
    {
        private HttpClient _client;
        private Device _device;
        private Scene _scene;

        public SwitchbotClient(string token, string baseUrl = "https://api.switch-bot.com")
        {
            if (string.IsNullOrEmpty(token)) throw new ArgumentException("Token is missing.");

            _client = _client ?? new HttpClient()
            {
                BaseAddress = new Uri(baseUrl)
            };
            _client.DefaultRequestHeaders.Add("Authorization", token);
        }

        public async Task<T> GetAsync<T>(string requestUrl)
        {
            HttpResponseMessage response = await _client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseText);
        }

        public async Task<T> PostAsync<T>(string requestUrl, HttpContent content)
        {
            HttpResponseMessage response = await _client.PostAsync(requestUrl, content);
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseText);
        }

        public void Dispose()
        {
            this._client.Dispose();
        }

        public Device Device
        {
            get
            {
                if (_device is null)
                {
                    _device = new Device(this);
                }
                return _device;
            }
        }

        public Scene Scene
        {
            get
            {
                if (_scene is null)
                {
                    _scene = new Scene(this);
                }
                return _scene;
            }
        }
    }
}
