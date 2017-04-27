using Newtonsoft.Json;

namespace AdamTest
{
    public class AdamResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }
    }
}