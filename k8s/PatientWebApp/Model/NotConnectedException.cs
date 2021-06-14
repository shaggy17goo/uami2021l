#nullable enable
namespace Model
{
    using System;
    using System.Runtime.Serialization;

    public class NotConnectedException : Exception
    {
        public NotConnectedException()
        {
        }

        protected NotConnectedException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public NotConnectedException(string? message) : base(message)
        {
        }

        public NotConnectedException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}