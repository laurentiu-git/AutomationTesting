using Newtonsoft.Json;

namespace Test.Config
{
    class ConfigSettings
    {
        [JsonProperty("url")]
        public string URL { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }
    }
}
