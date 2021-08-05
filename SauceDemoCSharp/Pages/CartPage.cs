using OpenQA.Selenium;

namespace SauceDemoCSharp.Pages
{
    class CartPage : BasePage
    {
        private IWebElement continueShoppingBtn => Driver.FindElement(By.XPath("//button[@name='continue-shopping']"));

        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        public ProductsPage ClickContinueShoppingBtn()
        {
            continueShoppingBtn.Click();
            return new ProductsPage(Driver);
        }
    }
}
