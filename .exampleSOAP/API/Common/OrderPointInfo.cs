namespace ServerAppAPI.API.Common {
    internal class OrderPointInfo {
        public int Number { get; set; }
        public string Address { get; set; }
        public int? TownId { get; set; }
        public string TownName { get; set; }
        public int? StreetId { get; set; }
        public string StreetName { get; set; }
        public string House { get; set; }
        public string NearlyHouse { get; set; }
        public double GPSlat { get; set; }
        public double GPSlon { get; set; }
        public int PlannedDistance { get; set; }
        public int PlannedDuration { get; set; }
    }
}
