using Assets.Patterns_Examples.Proxy_Pattern.Scripts;
using Assets.Patterns_Examples.Proxy_Pattern.Scripts.Services;
using System;
using UnityEngine;

namespace Assets.Patterns_Examples.Proxy_Pattern
{
    class ProxyExecutionScript : MonoBehaviour
    {
        private void Start()
        {
            IServer realServer = new Server();
            ISecureSystem secureSystem = new SecureService();
            IServer proxyServer = new ServerProxy(realServer, secureSystem);

            try
            {
                proxyServer.Connect();
                string data = proxyServer.FetchData();
                print(data);
                proxyServer.Disconnect();
            }
            catch (Exception e)
            {
                Debug.LogError($"An error occured while fetching server data. Message: " + e);
            }
        }
    }
}