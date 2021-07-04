using DoinJomain.Switchbot.Exceptions;
using DoinJomain.Switchbot.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DoinJomain.Switchbot
{
    public class BaseDevice
    {
        private SwitchbotClient _client;
        public BaseDevice(SwitchbotClient client)
        {
            _client = client;
        }

        public Task<CommandExecuteResoponse> CommandExecuteAsync(string deviceId, CommandRequestBody parameters)
        {
            if (string.IsNullOrEmpty(deviceId)) throw new ArgumentException("deviceId is missing.");
            var json = JsonConvert.SerializeObject(parameters);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            return this._client.PostAsync<CommandExecuteResoponse>($"/v1.0/devices/{deviceId}/commands", content);
        }
    }
}
