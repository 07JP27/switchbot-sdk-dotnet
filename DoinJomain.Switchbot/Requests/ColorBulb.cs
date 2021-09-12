using DoinJomain.Switchbot.Constants;
using DoinJomain.Switchbot.Enums;
using DoinJomain.Switchbot.Exceptions;
using DoinJomain.Switchbot.Models;
using DoinJomain.Switchbot.Structs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoinJomain.Switchbot
{
    public class ColorBulb: BaseDevice
    {
        public ColorBulb(SwitchbotClient client): base(client)
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

        public Task<CommandExecuteResoponse> ToggleAsync(string deviceId)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.Toggle,
                Parameter = CommandParameter.Default
            };
            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> SetBrightnessAsync(string deviceId, int brightness)
        {
            if (brightness < 0 || brightness > 100) throw new ArgumentOutOfRangeException(nameof(brightness));
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.SetBrightness,
                Parameter = brightness.ToString()
            };
            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> SetColorAsync(string deviceId, RgbColor color)
        {
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.SetColor,
                Parameter = $"{color.Red}:{color.Green}:{color.Blue}"
            };
            return this.CommandExecuteAsync(deviceId, parameters);
        }

        public Task<CommandExecuteResoponse> SetColorTemperature(string deviceId, int temperature)
        {
            if (temperature < 2700 || temperature > 6500) throw new ArgumentOutOfRangeException(nameof(temperature));
            var parameters = new CommandRequestBody()
            {
                CommandType = CommandType.Commnad,
                Command = Command.SetColorTemperature,
                Parameter = temperature.ToString()
            };
            return this.CommandExecuteAsync(deviceId, parameters);
        }
    }
}
