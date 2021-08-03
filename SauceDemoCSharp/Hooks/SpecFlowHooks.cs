using BoDi;
using OpenQA.Selenium;
using SauceDemoCSharp.Utils;
using System;
using TechTalk.SpecFlow;

namespace SauceDemoCSharp.Hooks
{
    [Binding]
    public sealed class SpecFlowHooks
    {
        private readonly IObjectContainer container;

        public SpecFlowHooks(IObjectContainer container)
        {
            this.container = container;
        }
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            var capabilitiesGenerator = new CapabilitiesGenerator();
            IWebDriver driver = capabilitiesGenerator.Create(BrowserType.Edge);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Make this instance available to all other step definitions
            container.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            IWebDriver driver = container.Resolve<IWebDriver>();

            driver.Close();
            driver.Dispose();
        }
    }
}
