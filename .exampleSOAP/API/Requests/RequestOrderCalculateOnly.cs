﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using ServerAppAPI.API.Common;
using YTxCommon;

namespace ServerAppAPI.API.Requests {
    internal class RequestOrderCalculateOnly : Request {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public SysLangs Lang { get; set; }

        public OrderInfo OrderInfo { get; set; }
        public bool IncludeCalcLog { get; set; }
        public bool IncludeRoute { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.OrderCalculateOnly;
        }
    }
}
