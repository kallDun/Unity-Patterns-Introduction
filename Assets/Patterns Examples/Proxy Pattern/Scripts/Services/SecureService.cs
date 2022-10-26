using UnityEngine;

namespace Assets.Patterns_Examples.Proxy_Pattern.Scripts.Services
{
    class SecureService : ISecureSystem
    {
        public bool FilterConnections(int connectionId)
        {
            Debug.Log("Trying to get permission to connect...");
            return connectionId > 25;
        }
    }
}