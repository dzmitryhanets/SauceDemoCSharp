namespace SauceDemoCSharp.Config
{
    public static class ConfigReader
    {
        public static readonly BrowserType browserType = BrowserType.Chrome;
    }

    public enum BrowserType
    {
        FireFox,
        Chrome,
        Edge
    }
}
