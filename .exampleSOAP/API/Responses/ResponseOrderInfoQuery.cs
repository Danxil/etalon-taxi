using ServerAppAPI.API.Common;

namespace ServerAppAPI.API.Responses {
    internal class ResponseOrderInfoQuery : Response {
        public OrderInfo OrderInfo { get; set; }
    }
}
