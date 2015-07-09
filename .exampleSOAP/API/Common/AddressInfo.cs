namespace ServerAppAPI.API.Common {
    internal class AddressInfo {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public int TownId { get; set; }
        public string TownName { get; set; }
        public int StreetId { get; set; }
        public string StreetName { get; set; }
        public string House { get; set; }
    }
}
