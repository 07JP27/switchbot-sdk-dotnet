using _07JP27.Switchbot.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07JP27.Switchbot.Models
{
    public class DeviceListResponse
    {
        public SwitchbotStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public DeviceListResponseBody Body { get; set; }

    }

    public class DeviceListResponseBody
    {
        public List<Device> DeviceList { get; set; }
        public List<InfraredRemote> InfraredRemoteList { get; set; }
    }
}
