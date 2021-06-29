using _07JP27.Switchbot.Exceptions;
using _07JP27.Switchbot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _07JP27.Switchbot
{
    public class Device
    {
        SwitchbotClient _client;
        public Device(SwitchbotClient client)
        {
            _client = client;
        }

        public Task<DeviceListResponse> GetListAsync()
        {
            return this._client.SendAsync<DeviceListResponse>("/v1.0/devices");
        }

        public Task<DeviceStatusResponse> GetStatusAsync(string deviceId)
        {
            if (string.IsNullOrEmpty(deviceId)) throw new ServiceException("deviceId is missing.");
            return this._client.SendAsync<DeviceStatusResponse>($"/v1.0/devices/{deviceId}/status");
        }

        public Bot Bot
        {
            get
            {
                return new Bot(_client);
            }
        }
    }
}
