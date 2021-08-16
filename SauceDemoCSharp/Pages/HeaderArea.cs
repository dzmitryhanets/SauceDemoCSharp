using OpenQA.Selenium;

namespace SauceDemoCSharp.Pages
{
    class HeaderArea : BasePage
    {
        public IWebElement CartItem => Driver.FindElement(By.XPath("//a[@class='shopping_cart_link']"));

        public HeaderArea(IWebDriver driver) : base(driver)
        {
        }

        public CartPage ClickCartIcon()
        {
            CartItem.Click();
            return new CartPage(Driver);
        }
    }
}
