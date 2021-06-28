using _07JP27.Switchbot.Exceptions;
using System;
using System.Net.Http;

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

        
    }
}
