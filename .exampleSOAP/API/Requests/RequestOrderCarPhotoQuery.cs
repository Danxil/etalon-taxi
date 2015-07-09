using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon.App.Enums;

namespace ServerAppAPI.API.Requests {
    internal class RequestOrderCarPhotoQuery : Request {
        public int Id { get; set; }
        public int DriverId { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public CarPhotoViews CarView { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.OrderCarPhotoQuery;
        }
    }
}
