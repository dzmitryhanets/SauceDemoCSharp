using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace SauceDemoCSharp.Pages
{
    class CommonPage : BasePage
    {
        private string PageTitle => Driver.FindElement(By.ClassName("title")).Text;

        public CommonPage(IWebDriver driver) : base(driver)
        {
        }

        public CommonPage VerifyPageTitle(String expectedTitle)
        {
            Assert.AreEqual(expectedTitle, PageTitle);
            return this;
        }
    }
}
