namespace ServerAppAPI.API.Responses {
    internal class ResponsePointsByGPSQuery : Response {
        public GPSPoint[] Points { get; set; }
    }

    internal class GPSPoint {
        public double GPSLat { get; set; }
        public double GPSLon { get; set; }
    }
}
