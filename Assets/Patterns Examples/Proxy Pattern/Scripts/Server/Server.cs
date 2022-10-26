using UnityEngine;

namespace Assets.Patterns_Examples.Proxy_Pattern.Scripts
{
    class Server : IServer
    {
        public void Connect()
        {
            Debug.Log("Succesfully connect to server!");
        }

        public void Disconnect()
        {
            Debug.Log("Disconnected from server!");
        }

        public string FetchData()
        {
            return "Some server data";
        }
    }
}