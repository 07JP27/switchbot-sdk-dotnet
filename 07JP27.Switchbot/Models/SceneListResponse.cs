using _07JP27.Switchbot.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07JP27.Switchbot.Models
{
    public class SceneListResponse
    {
        public SwitchbotStatusCode StatusCode { get; set; }
        public string Message { get; set; }
        public List<Scene> Body { get; set; }

    }
}
