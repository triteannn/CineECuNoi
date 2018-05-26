using System;
using System.Runtime.Serialization;

namespace ISSApp.Exceptions
{
    [Serializable]
    public class NetworkingException : Exception
    {
        public NetworkingException(string message) : base(message)
        {

        }

        public NetworkingException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
