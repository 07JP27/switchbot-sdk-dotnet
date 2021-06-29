using _07JP27.Switchbot.Exceptions;
using _07JP27.Switchbot.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _07JP27.Switchbot
{
    public class BaseDevice
    {
        SwitchbotClient _client;
        public BaseDevice(SwitchbotClient client)
        {
            _client = client;
        }

        public Task<CommandExecuteResoponse> CommandExecuteAsync(string deviceId, HttpContent content)
        {
            return this._client.PostAsync<CommandExecuteResoponse>($"/v1.0/devices/{deviceId}/commands", content);
        }
    }
}
