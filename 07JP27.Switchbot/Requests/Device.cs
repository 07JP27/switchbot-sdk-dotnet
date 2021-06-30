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
            return this._client.GetAsync<DeviceListResponse>("/v1.0/devices");
        }

        public Task<DeviceStatusResponse> GetStatusAsync(string deviceId)
        {
            if (string.IsNullOrEmpty(deviceId)) throw new ArgumentException("deviceId is missing.");
            return this._client.GetAsync<DeviceStatusResponse>($"/v1.0/devices/{deviceId}/status");
        }

        public Bot Bot
        {
            get
            {
                return new Bot(_client);
            }
        }

        public Plug Plug
        {
            get
            {
                return new Plug(_client);
            }
        }

        public Curtain Curtain
        {
            get
            {
                return new Curtain(_client);
            }
        }

        public Humidifier Humidifier
        {
            get
            {
                return new Humidifier(_client);
            }
        }

        public SmartFan SmartFan
        {
            get
            {
                return new SmartFan(_client);
            }
        }

        public AirConditioner AirConditioner
        {
            get
            {
                return new AirConditioner(_client);
            }
        }

        public Tv Tv
        {
            get
            {
                return new Tv(_client);
            }
        }

        public DVD DVD
        {
            get
            {
                return new DVD(_client);
            }
        }
    }
}
