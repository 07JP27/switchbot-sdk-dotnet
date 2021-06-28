using _07JP27.Switchbot;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace _07JP27.Switchbot.Tests
{
    [TestClass()]
    public class UnitTest1
    {
        [TestMethod()]
        public async Task GetDeviceListAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient("");
            var devices = await client.GetDeviceListAsync();
            Assert.AreNotEqual(devices, null);
        }

        [TestMethod()]
        public async Task GetDeviceStatusAsyncTest()
        {
            SwitchbotClient client = new SwitchbotClient("");
            var device = await client.GetDeviceStatusAsync("");
            Assert.AreNotEqual(device, null);
        }

        [TestMethod()]
        public async Task GetSceneListAsyncTestAsync()
        {
            SwitchbotClient client = new SwitchbotClient("");
            var scenes = await client.GetSceneListAsync();
            Assert.AreNotEqual(scenes, null);
        }
    }
}
