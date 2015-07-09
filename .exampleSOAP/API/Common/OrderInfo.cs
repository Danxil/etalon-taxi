using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon.App.Enums;

namespace ServerAppAPI.API.Common {
    internal class OrderInfo {
        public ClientInfo Client { get; set; }
        public string LoyalCardNum { get; set; }
        public int LoyalDiscount { get; set; }
        public int LoyalBonuses { get; set; }
        public int LoyalBonusAdd { get; set; }
        public string NonCashTicketNum { get; set; }
        public int? ProviderId { get; set; }
        public string ProviderName { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderStt Status { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public OrderSubStt SubStatus { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public CarClasses CarClass { get; set; }

        public int? TariffId { get; set; }
        public string Passenger { get; set; }
        public string Address { get; set; }
        public int? TownId { get; set; }
        public string TownName { get; set; }
        public int? StreetId { get; set; }
        public string StreetName { get; set; }
        public string House { get; set; }
        public string NearlyHouse { get; set; }
        public string Porch { get; set; }
        public string Apart { get; set; }
        public double GPSlat { get; set; }
        public double GPSlon { get; set; }
        public string Meet { get; set; }
        public string DriverName { get; set; }
        public int DriverSign { get; set; }
        public string DriverWorkPhone { get; set; }
        public string CarNumber { get; set; }
        public string CarmakerModel { get; set; }
        public string CarColorName { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Completed { get; set; }
        public DateTime? EstimatedCompleted { get; set; }
        public PayTypes PayType { get; set; }
        public bool Preorder { get; set; }
        public bool SentToXchg { get; set; }
        public DateTime? PlannedSupply { get; set; }
        public int PlannedDistance { get; set; }
        public int PlannedDuration { get; set; }
        public int PlannedPayment { get; set; }
        public DateTime? FactSupply { get; set; }
        public int FactDistance { get; set; }
        public int FactDuration { get; set; }
        public int FactWait { get; set; }
        public int FactPayment { get; set; }
        public string CalculationLog { get; set; }

        [JsonProperty( ItemConverterType = typeof( StringEnumConverter ) )]
        public OrderTypes[] OrderTypes { get; set; }

        public OrderPointInfo[] OrderPoints { get; set; }
        public OrderRouteInfo[] OrderRoute { get; set; }
        public OrderParameters Parameters { get; set; }
    }

    /// <summary>
    ///     Параметры заказа (задаются при создании и не изменяются)
    /// </summary>
    internal class OrderParameters {
        /// <summary>
        ///     Для заказа, созданного программно:
        ///     сразу отправить созданный заказ в свободный эфир (CarSearchBroadcast)
        /// </summary>
        public bool OrderSoftwareBroadcastImmediately { get; set; }

        /// <summary>
        ///     Для заказа, созданного программно:
        ///     false - выбор машины клиентом (CarSearchClientSelect)
        ///     true - автоматический поиск машины (CarSearchAuto)
        /// </summary>
        public bool OrderSoftwareCarSearchAuto { get; set; }

        /// <summary>
        ///     Для заказа, созданного программно:
        ///     в случае неуспешного поиска по списку отправить/не отправлять заказ в свободный эфир (CarSearchBroadcast)
        /// </summary>
        public bool OrderSoftwareBroadcastAfterUnsuccessfulSearch { get; set; }
    }
}
