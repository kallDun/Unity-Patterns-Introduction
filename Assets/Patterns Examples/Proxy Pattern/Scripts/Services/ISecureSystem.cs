namespace Assets.Patterns_Examples.Proxy_Pattern.Scripts.Services
{
    interface ISecureSystem
    {
        bool FilterConnections(int connectionId);
    }
}