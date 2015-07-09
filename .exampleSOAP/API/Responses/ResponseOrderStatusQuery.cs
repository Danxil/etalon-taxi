using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon.App.Enums;

namespace ServerAppAPI.API.Responses {
    internal class ResponseOrderStatusQuery : Response {
        public int? ProviderId { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderStt Status { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderSubStt SubStatus { get; set; }

        public bool SentToXchg { get; set; }
        public int? FactPayment { get; set; }
        public double? CarCurrentGPSlat { get; set; }
        public double? CarCurrentGPSlon { get; set; }
    }
}
