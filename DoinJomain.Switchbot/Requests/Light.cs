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
    public class Light : BaseDevice
    {
        public Light(SwitchbotClient client): base(client)
        {
        }

        public Task<CommandExecuteResoponse> BrightnessUpAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.BrightnessUp,
                Parameter = CommandParameter.Default
            };
            
            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> BrightnessDownAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.BrightnessDown,
                Parameter = CommandParameter.Default
            };
            return this.CommandExecuteAsync(deviceId, parameters);
        }
    }
}
