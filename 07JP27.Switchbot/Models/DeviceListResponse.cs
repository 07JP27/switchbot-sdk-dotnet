using _07JP27.Switchbot.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07JP27.Switchbot.Models
{
    public class DeviceListResponse
    {
        public SwitchbotStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public DeviceList Body { get; set; }

    }

    public class DeviceList
    {
        [JsonProperty("DeviceList")]
        public List<Device> PhysicalDeviceList { get; set; }
        public List<InfraredRemote> InfraredRemoteList { get; set; }
    }
}
