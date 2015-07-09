using ServerAppAPI.API.Common;

namespace ServerAppAPI.API.Responses {
    internal class ResponseAddressByGPSQuery : Response {
        public AddressInfo[] Addresses { get; set; }
    }
}
