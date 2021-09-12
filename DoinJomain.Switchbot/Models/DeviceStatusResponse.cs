using DoinJomain.Switchbot.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoinJomain.Switchbot.Models
{
    public class DeviceStatusResponse
    {
        public SwitchbotStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public DeviceStatus Body { get; set; }
    }

    public class DeviceStatus
    {
        public string DeviceId { get; set; }
        public string DeviceType { get; set; }
        public string HubDeviceId { get; set; }
        public string Power { get; set; }
        public int Humidity { get; set; }
        public float Temperature { get; set; }
        public int NebulizationEfficiency { get; set; }
        public bool Auto { get; set; }
        public bool ChildLock { get; set; }
        public bool Sound { get; set; }
        public bool Calibrate { get; set; }
        public bool Group { get; set; }
        public bool Moving { get; set; }
        public int SlidePosition { get; set; }
        public int Mode { get; set; }
        public int Speed { get; set; }
        public bool Shaking { get; set; }
        public int ShakeCenter { get; set; }
        public int ShakeRange { get; set; }
        public bool MoveDetected { get; set; }
        public string Brightness { get; set; }
        public string OpenState { get; set; }
        public string Color { get; set; }
        public int ColorTemperature { get; set; }
        public bool LackWater { get; set; }
    }
}
