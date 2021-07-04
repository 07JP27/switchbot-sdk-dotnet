using DoinJomain.Switchbot.Constants;
using DoinJomain.Switchbot.Enums;
using DoinJomain.Switchbot.Exceptions;
using DoinJomain.Switchbot.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DoinJomain.Switchbot
{
    public class AirConditioner: BaseDevice
    {
        public AirConditioner(SwitchbotClient client): base(client)
        {
        }

        public Task<CommandExecuteResoponse> SetAllAsync(string deviceId, int temp, AirConditionerMode mode, AirConditionerFanSpeed fanSpeed, AirConditionerPower power)
        {
            string lpower;

            switch (power)
            {
                case AirConditionerPower.Off:
                    lpower = "off";
                    break;
                case AirConditionerPower.On:
                    lpower = "on";
                    break;
                default:
                    throw new ServiceException("The power can not set.");
            }

            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.SetAll,
                Parameter = $"{temp},{((int)mode)},{((int)fanSpeed)},{lpower}"
            };
            
            return this.CommandExecuteAsync(deviceId, parameters);
        }
    }
}
