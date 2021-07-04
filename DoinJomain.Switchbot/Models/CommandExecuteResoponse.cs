using DoinJomain.Switchbot.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DoinJomain.Switchbot.Models
{
    public class CommandExecuteResoponse
    {
        public SwitchbotStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public object Body { get; set; }
    }
}
