using _07JP27.Switchbot.Constants;
using _07JP27.Switchbot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _07JP27.Switchbot
{
    public class Speaker : DVD
    {
        public Speaker(SwitchbotClient client) : base(client)
        {
        }

        public Task<CommandExecuteResoponse> volumeAddAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.VolumeAdd,
                Parameter = CommandParameter.Default
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> volumeSubAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.VolumeSub,
                Parameter = CommandParameter.Default
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }
    }
}
