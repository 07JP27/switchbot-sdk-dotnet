using DoinJomain.Switchbot.Constants;
using DoinJomain.Switchbot.Models;
using DoinJomain.Switchbot.Structs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DoinJomain.Switchbot
{
    public class Humidifier : BaseDevice
    {
        public Humidifier(SwitchbotClient client) : base(client)
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

        public Task<CommandExecuteResoponse> SetModeAsync(string deviceId, HumidifierMode mode)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.SetMode,
                Parameter = mode.Value
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }
    }
}
