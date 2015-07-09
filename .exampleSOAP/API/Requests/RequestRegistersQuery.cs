using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon;

namespace ServerAppAPI.API.Requests {
    internal class RequestRegistersQuery : Request {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public SysLangs Lang { get; set; }

        [JsonProperty( ItemConverterType = typeof( StringEnumConverter ) )]
        public RegisterTypes[] Requested { get; set; }

        /// <summary>
        ///     ID города для запроса улиц и объектов для быстрого поиска
        /// </summary>
        public int TownId { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.RegistersQuery;
        }
    }
}
