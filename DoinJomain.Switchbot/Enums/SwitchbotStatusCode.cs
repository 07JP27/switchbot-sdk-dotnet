using System;
using System.Collections.Generic;
using System.Text;

namespace DoinJomain.Switchbot.Enums
{
    public enum SwitchbotStatusCode
    {
        Success = 100,
        DeviceTypeError = 150,
        DeviceNotFound = 152,
        CommandNotSupported = 160,
        DeviceOffline = 161,
        HubOffline = 171,
        SystemError = 190,
    }
}