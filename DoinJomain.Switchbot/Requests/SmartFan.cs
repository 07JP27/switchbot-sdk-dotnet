using DoinJomain.Switchbot.Constants;
using DoinJomain.Switchbot.Enums;
using DoinJomain.Switchbot.Exceptions;
using DoinJomain.Switchbot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoinJomain.Switchbot
{
    public class SmartFan: BaseDevice
    {
        public SmartFan(SwitchbotClient client): base(client)
        {
        }
        public Task<CommandExecuteResoponse> TurnOnAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.TurnOn,
                Parameter = CommandParameter.Default
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> TurnOffAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.TurnOff,
                Parameter = CommandParameter.Default
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> SetAllStatusAsync(string deviceId, SmartFanPower power, SmartFanMode fanMode, SmartFanSpeed fanSpeed, int shakeRange)
        {
            if (!Enumerable.Range(1, 120).Contains(shakeRange)) throw new ServiceException("The shakeRange must be between 0 to 120.");
            string lpower;
            switch (power)
            {
                case SmartFanPower.On:
                    lpower = "on";
                    break;
                case SmartFanPower.Off:
                    lpower = "off";
                    break;
                default:
                    throw new ServiceException("Can not set power.");
            }
            
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.SetAllStatus,
                Parameter = $"{lpower},{((int)fanMode)},{((int)fanSpeed)},{shakeRange}"
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }
    }
}
