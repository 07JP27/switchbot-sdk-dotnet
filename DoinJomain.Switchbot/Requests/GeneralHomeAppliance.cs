using DoinJomain.Switchbot.Constants;
using DoinJomain.Switchbot.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DoinJomain.Switchbot
{
    public class GeneralHomeAppliance : BaseDevice
    {
        public GeneralHomeAppliance(SwitchbotClient client): base(client)
        {
        }

        public Task<CommandExecuteResoponse> TurnOnAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.None,
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
    }
}
