using Assets.Patterns_Examples.Proxy_Pattern.Scripts.Exceptions;
using Assets.Patterns_Examples.Proxy_Pattern.Scripts.Services;
using UnityEngine;

namespace Assets.Patterns_Examples.Proxy_Pattern.Scripts
{
    class ServerProxy : IServer
    {
        public int ConnectionId { get => connectionId; }

        private int connectionId;
        private bool connected;
        private IServer server;
        private ISecureSystem secureSystem;

        public ServerProxy(IServer server, ISecureSystem secureSystem)
        {
            this.server = server;
            this.secureSystem = secureSystem;
            connectionId = new System.Random().Next(0, 128);
            Debug.Log($"Proxy id: {connectionId}");
        }

        public void Connect()
        {
            if (secureSystem.FilterConnections(connectionId))
            {
                server.Connect();
                connected = true;
            }
            else
            {
                Debug.Log("Permission denied! Try again.");
            }
        }
        public void Disconnect()
        {
            if (connected)
            {
                server.Disconnect();
                connected = false;
            }
            else
            {
                throw new NotConnectedException(connectionId);
            }            
        }

        public string FetchData()
        {
            if (connected)
            {
                return server.FetchData();
            }
            else
            {
                throw new NotConnectedException(connectionId);
            }
        }
    }
}