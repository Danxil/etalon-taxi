using System.Runtime.Serialization;

namespace ServerAppAPI.API.Requests {
    internal class RequestOrderDriverSelection : Request {
        public int Id { get; set; }
        public int DriverId { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.OrderDriverSelection;
        }
    }
}
