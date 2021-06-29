using _07JP27.Switchbot;
using _07JP27.Switchbot.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace _07JP27.Switchbot.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        string TOKEN = "";
        [TestMethod()]
        public async Task GetDeviceListAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var devices = await client.Device.GetListAsync();
            Assert.AreNotEqual(devices, null);
        }

        [TestMethod()]
        public async Task GetDeviceStatusAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var device = await client.Device.GetStatusAsync("");
            Assert.AreNotEqual(device, null);
        }

        [TestMethod()]
        public async Task GetSceneListAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var scenes = await client.Scene.GetListAsync();
            Assert.AreNotEqual(scenes, null);
        }

        [TestMethod()]
        public async Task ExecuteSceneAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Scene.ExecuteAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task BotTurnOffAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Bot.TurnOffAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task BotTurnOnAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Bot.TurnOnAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task BotPressAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Bot.PressAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task PlugTurnOffAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Plug.TurnOffAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task PlugTurnOnAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Plug.TurnOnAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task CurtainTurnOffAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Curtain.TurnOffAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task CurtainTurnOnAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Curtain.TurnOnAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task CurtainSetPositionAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Curtain.SetPositionAsync("", CurtainMode.Default, 80);
            Assert.AreNotEqual(result, null);
        }
    }
}
