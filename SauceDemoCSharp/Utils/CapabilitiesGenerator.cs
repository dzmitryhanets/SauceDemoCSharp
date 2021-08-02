using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
