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
    public class Fan : BaseDevice
    {
        public Fan(SwitchbotClient client): base(client)
        {
        }

        public Task<CommandExecuteResoponse> SwingAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.Swing,
                Parameter = CommandParameter.Default
            };
            
            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> TimerAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.Timer,
                Parameter = CommandParameter.Default
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> LowSpeedAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.LowSpeed,
                Parameter = CommandParameter.Default
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> MiddleSpeedAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.MiddleSpeed,
                Parameter = CommandParameter.Default
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> HighSpeedAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.HighSpeed,
                Parameter = CommandParameter.Default
            };

            return this.CommandExecuteAsync(deviceId, parameters);
        }
    }
}
