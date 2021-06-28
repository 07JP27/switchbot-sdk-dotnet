using System;
using System.Collections.Generic;
using System.Text;

namespace _07JP27.Switchbot.Models
{
    public class Device
    {
        public string DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string DeviceType { get; set; }
        public bool EnableCloudService { get; set; }
        public string HubDeviceId { get; set; }
        public List<string> CurtainDevicesIds { get; set; }
        public bool Calibrate { get; set; }
        public bool Group { get; set; }
        public bool Master { get; set; }
        public string OpenDirection { get; set; }
    }
}
