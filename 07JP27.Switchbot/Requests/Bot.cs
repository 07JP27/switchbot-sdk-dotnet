using _07JP27.Switchbot.Constants;
using _07JP27.Switchbot.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _07JP27.Switchbot
{
    public class Bot: BaseDevice
    {
        public Bot(SwitchbotClient client): base(client)
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

        public Task<CommandExecuteResoponse> PressAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.Press,
                Parameter = CommandParameter.Default
            };
            return this.CommandExecuteAsync(deviceId, parameters);
        }
    }
}
