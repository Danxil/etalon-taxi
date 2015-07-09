using ServerAppAPI.API.Common;

namespace ServerAppAPI.API.Responses {
    internal class ResponseOrderCalculateOnly : Response {
        public OrderInfo OrderInfo { get; set; }
    }
}
