using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon.App.Enums;

namespace ServerAppAPI.API.Responses {
    internal class ResponseRegistersQuery : Response {
        public Town[] Towns { get; set; }
        public Street[] Streets { get; set; }
        public ObjectPlace[] ObjectPlaces { get; set; }
        public Provider[] Providers { get; set; }
        public CarClass[] CarClasses { get; set; }
        public OrderType[] OrderTypes { get; set; }
        public OrderStatus[] OrderStatuses { get; set; }
        public OrderSubStatus[] OrderSubStatuses { get; set; }
        public ClientStatus[] ClientStatuses { get; set; }
        public DriverShiftStatus[] DriverShiftStatuses { get; set; }
        public PayType[] PayTypes { get; set; }
        public Tariff[] Tariffs { get; set; }
    }

    internal class Town {
        public int Code { get; set; }
        public string Name { get; set; }
        public int CountryCode { get; set; }
        public string CountryName { get; set; }
    }

    internal class Street {
        public int Code { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }

    internal class ObjectPlace {
        public int RecordId { get; set; }
        public string Name { get; set; }
        public int StreetId { get; set; }
        public string StreetName { get; set; }
        public string House { get; set; }
        public double GPSLat { get; set; }
        public double GPSLon { get; set; }
    }

    internal class Provider {
        public int RecordId { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public string CenterServerId { get; set; }
        public string[] DispatchPhones { get; set; }
    }

    internal class CarClass {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public CarClasses Code { get; set; }

        public string Name { get; set; }
        public string Descr { get; set; }
    }

    internal class OrderType {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderTypes Code { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public CarClasses? CarClass { get; set; }

        public string Name { get; set; }
        public string Descr { get; set; }
    }

    internal class OrderStatus {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderStt Code { get; set; }

        public string Name { get; set; }
    }

    internal class OrderSubStatus {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderSubStt Code { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderStt SttCode { get; set; }

        public string Name { get; set; }
    }

    internal class ClientStatus {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public ClientStt Code { get; set; }

        public string Name { get; set; }
        public string Descr { get; set; }
    }

    internal class DriverShiftStatus {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public DriverShiftStt Code { get; set; }

        public string Name { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
    }

    internal class PayType {
        [JsonConverter( typeof( StringEnumConverter ) )]
        public PayTypes Code { get; set; }

        public string Name { get; set; }
    }

    internal class Tariff {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Descr { get; set; }
        public bool Active { get; set; }
    }
}
