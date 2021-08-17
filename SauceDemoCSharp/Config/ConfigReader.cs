namespace SauceDemoCSharp.Config
{
    public static class ConfigReader
    {
        public static readonly BrowserType browserType = BrowserType.FireFox;
    }

    public enum BrowserType
    {
        FireFox,
        Chrome,
        Edge
    }
}
