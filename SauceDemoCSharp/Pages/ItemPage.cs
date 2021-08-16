using NUnit.Framework;
using OpenQA.Selenium;

namespace SauceDemoCSharp.Pages
{
    class ItemPage : BasePage
    {
        private string ItemTitle => Driver.FindElement(By.XPath("//*[@class='inventory_details_name large_size']")).Text;

        public ItemPage(IWebDriver driver) : base(driver)
        {
        }

        public ItemPage VerifyItemPage(string expectedTitle)
        {
            Assert.AreEqual(expectedTitle, ItemTitle);
            return this;
        }
    }
}