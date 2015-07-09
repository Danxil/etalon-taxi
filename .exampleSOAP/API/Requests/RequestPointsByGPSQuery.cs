using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon;

namespace ServerAppAPI.API.Requests {
    internal class RequestPointsByGPSQuery : Request {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public SysLangs Lang { get; set; }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int TownId { get; set; }
        public string TownName { get; set; }
        public int StreetId { get; set; }
        public string StreetName { get; set; }
        public string House { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.PointsByGPSQuery;
        }
    }
}
