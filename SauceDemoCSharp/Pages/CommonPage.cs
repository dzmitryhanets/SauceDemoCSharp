using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace SauceDemoCSharp.Pages
{
    class CommonPage : BasePage
    {
        private string pageTitle => Driver.FindElement(By.ClassName("title")).Text;

        public CommonPage(IWebDriver driver) : base(driver)
        {
        }

        public CommonPage VerifyPageTitle(String expectedTitle)
        {
            Assert.AreEqual(expectedTitle, pageTitle);
            return this;
        }
    }
}
