using System.Runtime.Serialization;

namespace ServerAppAPI.API.Requests {
    internal class RequestOrderAutoSearchDrivers : Request {
        public int Id { get; set; }
        public int FactPayment { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.OrderAutoSearchDrivers;
        }
    }
}
