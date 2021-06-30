using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoCSharp.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver { get; set; }
        WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
                Driver = driver;           
        }

        public bool isElementPresented(IWebElement element)
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

        public void waitClickableElement(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public void waitSelectedElement(IWebElement element)
        {
            wait.Until(ExpectedConditions.ElementToBeSelected(element));
        }
    }
}
