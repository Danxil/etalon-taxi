using System.Runtime.Serialization;

namespace ServerAppAPI.API.Requests {
    internal class RequestVersion : Request {
        [OnSerializing]
        internal void OnSerializingMethod( StreamingContext context ) {
            Command = Commands.Version;
        }
    }
}
