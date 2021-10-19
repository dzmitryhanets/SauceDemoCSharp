using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace SauceDemoCSharp.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver { get; private set; }

        WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
                Driver = driver;           
        }

        public bool IsElementPresented(IWebElement element)
        {
            try
            {
                _ = element.Displayed;
                return true;
            }
            catch (NoSuchElementException exc)
            {
                Console.WriteLine(element.ToString() + " not found " + exc);
                return false;
            }
        }

        public void WaitClickableElement(IWebElement element)
        {
            wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(element));
        }

        public void WaitSelectedElement(IWebElement element)
        {
            wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 30));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeSelected(element));
        }
    }
}
