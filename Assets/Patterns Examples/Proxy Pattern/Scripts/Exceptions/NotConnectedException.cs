using System;

namespace Assets.Patterns_Examples.Proxy_Pattern.Scripts.Exceptions
{
    public class NotConnectedException : Exception
    {
        public override string Message => $"User with proxy connection id {connectionId} is not connected to server!";

        private int connectionId;

        public NotConnectedException(int connectionId)
        {
            this.connectionId = connectionId;
        }
    }
}