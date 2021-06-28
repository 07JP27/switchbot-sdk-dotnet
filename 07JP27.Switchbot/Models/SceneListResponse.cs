using System;
using System.Collections.Generic;
using System.Text;

namespace _07JP27.Switchbot.Models
{
    public class SceneListResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public List<Scene> Body { get; set; }

    }
}
