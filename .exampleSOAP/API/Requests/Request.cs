using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ServerAppAPI.API.Requests {
    internal class Request {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public Commands Command { get; set; }
    }
}
