# switchbot-sdk-dotnet
[![Build and Release](https://github.com/07JP27/switchbot-sdk-dotnet/actions/workflows/build-and-publish.yml/badge.svg)](https://github.com/07JP27/switchbot-sdk-dotnet/actions/workflows/build-and-publish.yml)
![](https://img.shields.io/nuget/v/DoinJomain.Switchbot.svg)
![](https://img.shields.io/nuget/dt/DoinJomain.Switchbot.svg)

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

## Press Bot (and execute other commands.)
``` cs
SwitchbotClient client = new SwitchbotClient("{token}");
CommandExecuteResoponse result = await client.Device.Bot.PressAsync("{deviceId}");
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