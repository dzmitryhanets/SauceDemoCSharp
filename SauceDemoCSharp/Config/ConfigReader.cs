namespace SauceDemoCSharp.Config
{
    class ConfigReader
    {
        public static readonly BrowserType browserType = BrowserType.Edge;
    }

    public enum BrowserType
    {
        FireFox,
        Chrome,
        Edge
    }
}
