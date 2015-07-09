using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon;

namespace ServerAppAPI.API.Requests {
    internal class RequestAddressByGPSQuery : Request {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public SysLangs Lang { get; set; }

        public double GPSLat { get; set; }
        public double GPSLon { get; set; }
        public int Radius { get; set; }
        public int QtPlaces { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.AddressByGPSQuery;
        }
    }
}
