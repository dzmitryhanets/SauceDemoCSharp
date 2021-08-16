using OpenQA.Selenium;

namespace SauceDemoCSharp.Pages
{
    class CartPage : BasePage
    {
        private IWebElement ContinueShoppingBtn => Driver.FindElement(By.XPath("//button[@name='continue-shopping']"));

        public CartPage(IWebDriver driver) : base(driver)
        {
        }

        public ProductsPage ClickContinueShoppingBtn()
        {
            ContinueShoppingBtn.Click();
            return new ProductsPage(Driver);
        }
    }
}
