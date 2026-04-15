using Consul;
using Newtonsoft.Json;
using System.Text;

namespace SmokeTestSelenium.Setup.Libs
{
    internal class ConsulConnection
    {
        private readonly ConsulClient client;

        public ConsulConnection()
        {
            String consulHost = "http://consul.service.consul:8500";
            client = new ConsulClient(consulConfig => { consulConfig.Address = new Uri(consulHost); });
        }

        public async Task<T> GetPairAsync<T>(string key)
        {
            var getPair = await client.KV.Get(key);
            var value = Encoding.UTF8.GetString(getPair.Response.Value, 0, getPair.Response.Value.Length);

            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}
