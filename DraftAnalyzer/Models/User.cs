using Newtonsoft.Json;

namespace DraftAnalyzer.Models
{
    public class User
    {
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
