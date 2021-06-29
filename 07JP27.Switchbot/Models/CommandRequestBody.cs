using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07JP27.Switchbot.Models
{
    public class CommandRequestBody
    {
        [JsonProperty("commandType")]
        public string CommandType { get; set; }
        [JsonProperty("command")]
        public string Command { get; set; }
        [JsonProperty("parameter")]
        public string Parameter { get; set; }
    }
}
