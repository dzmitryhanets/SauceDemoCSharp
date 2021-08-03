using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.Edge.SeleniumTools;
using OpenQA.Selenium.Firefox;
using System;

namespace SauceDemoCSharp.Utils
{
    public class CapabilitiesGenerator
    {
        public IWebDriver Create(BrowserType browserType)
        {
            switch (browserType)
            {
                case BrowserType.FireFox:
                    return GetFireFoxDriver();
                case BrowserType.Chrome:
                    return GetChromeDriver();
                case BrowserType.Edge:
                    return GetEdgeDriver();
                default:
                    throw new ArgumentOutOfRangeException("no such browser");
            }

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
            var options = new EdgeOptions();
            options.UseChromium = true;
            IWebDriver edgeDriver = new EdgeDriver(options);
            return edgeDriver;
        }
    }
}
