using _07JP27.Switchbot;
using _07JP27.Switchbot.Enums;
using _07JP27.Switchbot.Structs;
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

        [TestMethod()]
        public async Task HumidifierTurnOffAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Humidifier.TurnOffAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task HumidifierTurnOnAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Humidifier.TurnOnAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task HumidifierSetModeAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Humidifier.SetModeAsync("", HumidifierMode.Percentage(30));
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task SmartFanTurnOffAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.SmartFan.TurnOffAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task SmartFanTurnOnAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.SmartFan.TurnOnAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task SmartFanSetAllStatusAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.SmartFan.SetAllStatusAsync("", SmartFanPower.On, SmartFanMode.Natural, SmartFanSpeed.Middle, 50);
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task TvSetChannelAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Tv.SetChannelAsync("", 4);
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task TvVolumeAddAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Tv.VolumeAddAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task TvVolumeSubAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Tv.VolumeSubAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task TvChannelAddAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Tv.ChannelAddAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task TvChannelSubAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Tv.ChannelSubAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task DVDSetMuteAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.DVD.SetMuteAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task DVDFastForwardAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.DVD.FastForwardAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task DVDRewindAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.DVD.RewindAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task DVDNextAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.DVD.NextAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task DVDPreviousAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.DVD.PreviousAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task DVDPauseAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.DVD.PauseAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task DVDPlayAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.DVD.PlayAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task DVDStopAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.DVD.StopAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task AirConditionerSetAllSAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.AirConditioner.SetAllAsync("", 26, AirConditionerMode.Cool, AirConditionerFanSpeed.High, AirConditionerPower.On);
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task SpeakerVolumeAddAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Speaker.volumeAddAsync("");
            Assert.AreNotEqual(result, null);
        }

        [TestMethod()]
        public async Task SpeakerVolumeSubAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient(TOKEN);
            var result = await client.Device.Speaker.volumeSubAsync("");
            Assert.AreNotEqual(result, null);
        }
    }
}
