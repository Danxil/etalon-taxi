using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ServerAppAPI.API.Responses {
    public class Response {
        public Response() {
            Result = ResultCodes.Success;
        }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public ResultCodes Result { get; set; }

        public string Reason { get; set; }
    }
}
