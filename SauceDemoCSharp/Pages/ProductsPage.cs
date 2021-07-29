using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoCSharp.Pages
{
    class ProductsPage : BasePage
    {
        public static string itemName;
        private string productsTitle => Driver.FindElement(By.ClassName("title")).Text;
        IList<IWebElement> productItem => Driver.FindElements(By.ClassName("inventory_item_name"));


        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }

        public ProductsPage VerifyRedirectToProducts(String expectedTitle)
        {
            Assert.AreEqual(expectedTitle, productsTitle);
            return this;
        }

        public string GetItemName(int itemIndex)
        {
            itemName = productItem[itemIndex].Text;
            return itemName;
        }

        public ItemPage RedirectToItemPage(int itemIndex)
        {
            productItem[itemIndex].Click();
            return new ItemPage(Driver);
        }
    }
}
