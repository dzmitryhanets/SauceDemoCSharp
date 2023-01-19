namespace SauceDemoCSharp.Config
{
    public static class ConfigReader
    {
        public static readonly BrowserType browserType = BrowserType.Chrome;

        public static readonly bool isHeadlessModeOn = true;
    }

    public enum BrowserType
    {
        FireFox,
        Chrome,
        Edge
    }
}
