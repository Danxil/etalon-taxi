using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YTxCommon.App.Enums;

namespace ServerAppAPI.API.Common {
    internal class OrderEstimatedDriver {
        public int ProviderId { get; set; }
        public int DriverId { get; set; }
        public string DriverName { get; set; }
        public int DriverSign { get; set; }
        public string DriverWorkPhone { get; set; }

        [JsonConverter( typeof( StringEnumConverter ) )]
        public Gender DriverGender { get; set; }

        public int DriverWorkingPeriod { get; set; }
        public DriverShiftStt DriverStatus { get; set; }
        public OrderAssignmentToDriverStt AssignmentStatus { get; set; }
        public string CarNumber { get; set; }
        public string CarMakerModel { get; set; }
        public string CarColorName { get; set; }
        public DateTime? LastGPSReq { get; set; }
        public double GPSLat { get; set; }
        public double GPSLon { get; set; }
        public int LinearDistanceToStartPoint { get; set; }
        public int EstimatedDurationToStartPoint { get; set; }
    }
}
