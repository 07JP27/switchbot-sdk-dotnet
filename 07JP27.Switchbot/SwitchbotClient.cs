﻿using _07JP27.Switchbot.Exceptions;
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

        public async Task<T> SendAsync<T>(string requestUrl)
        {
            HttpResponseMessage response = await _client.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            var responseText = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseText);
        }

        public Device Device
        {
            get
            {
                return new Device(this);
            }
        }

        public Scene Scene
        {
            get
            {
                return new Scene(this);
            }
        }
    }
}
