using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon.App.Enums;

namespace ServerAppAPI.API.Responses {
    internal class ResponseOrderDriverSelection : Response {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderStt Status { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderSubStt SubStatus { get; set; }
    }
}
