using System.Runtime.Serialization;

namespace ServerAppAPI.API.Requests {
    internal class RequestOrderRestartProcess : Request {
        public int Id { get; set; }

        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.OrderRestartProcess;
        }
    }
}
