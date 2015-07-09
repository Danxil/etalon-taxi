using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon.App.Enums;

namespace ServerAppAPI.API.Common {
    internal class ClientInfo {
        public string Phone { get; set; }
        public string Name { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool NoSMS { get; set; }
        public string LoyalCardNum { get; set; }
        public string NonCashCardNum { get; set; }
        public string StandardAddress { get; set; }
        public int? StandardTownId { get; set; }
        public string StandardTownName { get; set; }
        public int? StandardStreetId { get; set; }
        public string StandardStreetName { get; set; }
        public string StandardHouse { get; set; }
        public string StandardPorch { get; set; }
        public string StandardApart { get; set; }
        public string StandardMeet { get; set; }
        public double StandardGPSlat { get; set; }
        public double StandardGPSlon { get; set; }
        public string Info { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public ClientStt Stt { get; set; }

        public string SttNote { get; set; }
        public bool Active { get; set; }
        public bool BlackListWarning { get; set; }
        public bool BlackListError { get; set; }
    }
}
