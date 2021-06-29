# [WIP]switchbot-sdk-dotnet
The Switchbot dotnet SDK based on https://github.com/OpenWonderLabs/SwitchBotAPI

Note: This SDK is unofficial.

# Usage
## Get device list
``` cs
SwitchbotClient client = new SwitchbotClient("{token}");
DeviceListResponse devices = await client.Device.GetListAsync();
```

## Get device status
``` cs
SwitchbotClient client = new SwitchbotClient("{token}");
DeviceStatusResponse status = await client.Device.GetStatusAsync("{deviceId}");
```

## Get scene list
``` cs
SwitchbotClient client = new SwitchbotClient("{token}");
SceneListResponse devices = await client.Scene.GetListAsync();
```

## Execute scene
``` cs
SwitchbotClient client = new SwitchbotClient("{token}");
SceneExecuteResoponse result = await client.Scene.ExecuteAsync("{sceneId}");
```