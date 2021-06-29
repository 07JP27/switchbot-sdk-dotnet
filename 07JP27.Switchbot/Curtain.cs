﻿using _07JP27.Switchbot.Constants;
using _07JP27.Switchbot.Enums;
using _07JP27.Switchbot.Exceptions;
using _07JP27.Switchbot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07JP27.Switchbot
{
    public class Curtain: BaseDevice
    {
        public Curtain(SwitchbotClient client) : base(client)
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

        public Task<CommandExecuteResoponse> SetPositionAsync(string deviceId, CurtainMode mode, int position)
        {
            if (!Enumerable.Range(1, 100).Contains(position)) throw new ServiceException("The position must be between 0 to 100.");
            
            string lmode;
            switch(mode)
            {
                case CurtainMode.Default:
                    lmode = "ff";
                    break;
                case CurtainMode.Performance:
                    lmode = "0";
                    break;
                case CurtainMode.Silent:
                    lmode = "1";
                    break;
                default:
                    throw new ServiceException("Can not set curtain mode.");
            }

            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.SetPosition,
                Parameter = $"0,{lmode},{position}"
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }
    }
}
