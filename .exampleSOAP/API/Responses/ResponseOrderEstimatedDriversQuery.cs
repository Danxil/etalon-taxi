using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ServerAppAPI.API.Common;
using YTxCommon.App.Enums;

namespace ServerAppAPI.API.Responses {
    internal class ResponseOrderEstimatedDriversQuery : Response {
        public OrderEstimatedDriver[] Drivers { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderStt Status { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderSubStt SubStatus { get; set; }
    }
}
