using _07JP27.Switchbot.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
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
            return this._client.GetAsync<SceneListResponse>("/v1.0/scenes");
        }

        public Task<SceneExecuteResoponse> ExecuteAsync(string sceneId)
        {
            if (string.IsNullOrEmpty(sceneId)) throw new ArgumentException("sceneId is missing.");
            return this._client.PostAsync<SceneExecuteResoponse>($"/v1.0/scenes/{sceneId}/execute", null);
        }
    }
}
