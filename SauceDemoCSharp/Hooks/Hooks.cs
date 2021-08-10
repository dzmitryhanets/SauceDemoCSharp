using Allure.Commons;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemoCSharp.Utils;
using System;
using System.IO;
using TechTalk.SpecFlow;

namespace SauceDemoCSharp.Hooks
{
    [Binding]
    public sealed class SpecFlowHooks
    {
        private readonly IObjectContainer container;
        private readonly ScenarioContext scenarioContext;
        private AllureLifecycle allureLifecycle;

        public SpecFlowHooks(IObjectContainer Container, ScenarioContext ScenarioContext)
        {
            container = Container;
            scenarioContext = ScenarioContext;
            allureLifecycle = AllureLifecycle.Instance;
        }

        private void AllureHackForScenarioOutlineTests()
        {
            scenarioContext.TryGetValue(out TestResult testresult);
            allureLifecycle.UpdateTestCase(testresult.uuid, tc =>
            {
                tc.name = scenarioContext.ScenarioInfo.Title;
                tc.historyId = Guid.NewGuid().ToString();
            });
        }

        [OneTimeSetUp]
        public void Init()
        {
            Environment.CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
        }
        
        [BeforeScenario]
        public void BeforeScenario()
        {
            var capabilitiesGenerator = new CapabilitiesGenerator();
            IWebDriver driver = capabilitiesGenerator.Create(BrowserType.FireFox);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            // Make this instance available to all other step definitions
            container.RegisterInstanceAs(driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            IWebDriver driver = container.Resolve<IWebDriver>();
            if (scenarioContext.TestError != null)
            {
                var path = WebElementsUtils.MakeScreenshot(driver);
                allureLifecycle.AddAttachment(path);
            }
            driver.Close();
            driver.Dispose();
            AllureHackForScenarioOutlineTests();
        }
    }
}
