namespace Assets.Patterns_Examples.Proxy_Pattern.Scripts
{
    public interface IServer
    {
        public void Connect();
        public void Disconnect();
        public string FetchData();
    }
}