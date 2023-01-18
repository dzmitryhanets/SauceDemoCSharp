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
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("headless");
            chromeOptions.AddArguments("no-sandbox");
            chromeOptions.AddArguments("disable-gpu");
            chromeOptions.AddArguments("disable-setuid-sandbox");
            chromeOptions.AddArguments("disable-dev-shm-usage");
            IWebDriver chromeDriver = new ChromeDriver(chromeOptions);
            return chromeDriver;
        }

        private IWebDriver GetEdgeDriver()
        {
            IWebDriver edgeDriver = new EdgeDriver();
            return edgeDriver;
        }
    }
}
