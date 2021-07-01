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
        private SwitchbotClient _client;
        private Bot _bot;
        private Plug _plug;
        private Curtain _curtain;
        private Humidifier _humidifier;
        private SmartFan _smartFan;
        private AirConditioner _airConditioner;
        private Tv _tv;
        private DVD _dvd;
        private Speaker _speaker;
        private Fan _fan;
        private Light _light;
        private GeneralHomeAppliance _generalHomeAppliance;
        private Custom _custom;

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
                if (_bot is null)
                {
                    _bot = new Bot(_client);
                }
                return _bot;
            }
        }

        public Plug Plug
        {
            get
            {
                if (_plug is null)
                {
                    _plug = new Plug(_client);
                }
                return _plug;
            }
        }

        public Curtain Curtain
        {
            get
            {
                if (_curtain is null)
                {
                    _curtain = new Curtain(_client);
                }
                return _curtain;
            }
        }

        public Humidifier Humidifier
        {
            get
            {
                if (_humidifier is null)
                {
                    _humidifier = new Humidifier(_client);
                }
                return _humidifier;
            }
        }

        public SmartFan SmartFan
        {
            get
            {
                if (_smartFan is null)
                {
                    _smartFan = new SmartFan(_client);
                }
                return _smartFan;
            }
        }

        public AirConditioner AirConditioner
        {
            get
            {
                if (_airConditioner is null)
                {
                    _airConditioner = new AirConditioner(_client);
                }
                return _airConditioner;
            }
        }

        public Tv Tv
        {
            get
            {
                if (_tv is null)
                {
                    _tv = new Tv(_client);
                }
                return _tv;
            }
        }

        public DVD DVD
        {
            get
            {
                if (_dvd is null)
                {
                    _dvd = new DVD(_client);
                }
                return _dvd;
            }
        }
        public Speaker Speaker
        {
            get
            {
                if (_speaker is null)
                {
                    _speaker = new Speaker(_client);
                }
                return _speaker;
            }
        }

        public Fan Fan
        {
            get
            {
                if (_fan is null)
                {
                    _fan = new Fan(_client);
                }
                return _fan;
            }
        }

        public Light Light
        {
            get
            {
                if (_light is null)
                {
                    _light = new Light(_client);
                }
                return _light;
            }
        }

        public GeneralHomeAppliance GeneralHomeAppliance
        {
            get
            {
                if (_generalHomeAppliance is null)
                {
                    _generalHomeAppliance = new GeneralHomeAppliance(_client);
                }
                return _generalHomeAppliance;
            }
        }

        public Custom Custom
        {
            get
            {
                if (_custom is null)
                {
                    _custom = new Custom(_client);
                }
                return _custom;
            }
        }
    }
}
