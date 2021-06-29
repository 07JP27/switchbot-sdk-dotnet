using _07JP27.Switchbot.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _07JP27.Switchbot
{
    public class Scene
    {
        SwitchbotClient _client;
        public Scene(SwitchbotClient client)
        {
            _client = client;
        }

        public Task<SceneListResponse> GetListAsync()
        {
            return this._client.SendAsync<SceneListResponse>("/v1.0/scenes");
        }
    }
}
