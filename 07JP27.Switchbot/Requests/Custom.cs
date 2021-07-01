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
    public class Custom: BaseDevice
    {
        public Custom(SwitchbotClient client): base(client)
        {
        }

        public Task<CommandExecuteResoponse> ExecuteAsync(string deviceId, string userDefinedBtnName)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Customize,
                Command = userDefinedBtnName,
                Parameter = CommandParameter.Default
            };
            
            return this.CommandExecuteAsync(deviceId, parameters);
        }
    }
}
