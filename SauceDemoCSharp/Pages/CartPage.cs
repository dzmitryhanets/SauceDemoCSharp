using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoCSharp.Pages
{
    public class CartPage : BasePage
    {
        public IWebElement CartItem => Driver.FindElement(By.XPath("//div[@class='cart_item']"));

        public CartPage(IWebDriver driver) : base(driver)
        {
        }
    }
}
