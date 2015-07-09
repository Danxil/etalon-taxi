using System.Runtime.Serialization;

namespace ServerAppAPI.API.Requests {
    internal class RequestOrderClientRejection : Request {
        public int Id { get; set; }
        public string Cause { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.OrderClientRejection;
        }
    }
}
