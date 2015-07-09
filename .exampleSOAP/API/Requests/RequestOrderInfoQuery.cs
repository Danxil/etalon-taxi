using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon;

namespace ServerAppAPI.API.Requests {
    internal class RequestOrderInfoQuery : Request {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public SysLangs Lang { get; set; }

        public int Id { get; set; }
        public bool IncludeCalcLog { get; set; }
        public bool IncludeRoute { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.OrderInfoQuery;
        }
    }
}
