using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using SauceDemoCSharp.Config;
using OpenQA.Selenium.Edge;

namespace SauceDemoCSharp.Utils
{
    public class CapabilitiesGenerator
    {
        public IWebDriver Create(BrowserType browserType)
        {
            IWebDriver driver = browserType switch
            {
                BrowserType.FireFox => GetFireFoxDriver(),
                BrowserType.Chrome => GetChromeDriver(),
                BrowserType.Edge => GetEdgeDriver(),
                _ => throw new ArgumentOutOfRangeException($"Browser type {browserType} is not supported"),
            };

            return driver;
        }

        private IWebDriver GetFireFoxDriver()
        {
            IWebDriver fireFoxDriver = new FirefoxDriver();
            return fireFoxDriver;
        }

        private IWebDriver GetChromeDriver()
        {
            IWebDriver chromeDriver = new ChromeDriver();
            return chromeDriver;
        }

        private IWebDriver GetEdgeDriver()
        {
            IWebDriver edgeDriver = new EdgeDriver();
            return edgeDriver;
        }
    }
}
