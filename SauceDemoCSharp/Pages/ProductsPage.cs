using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace SauceDemoCSharp.Pages
{
    class ProductsPage : BasePage
    {
        public static string itemName;
        private string productsTitle => Driver.FindElement(By.ClassName("title")).Text;
        IList<IWebElement> productItem => Driver.FindElements(By.ClassName("inventory_item_name"));
        IList<IWebElement> inventoryBtn => Driver.FindElements(By.XPath("//div[@class='inventory_item_price']/following-sibling::button"));

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

        public ProductsPage ClickItemInventoryBtn(int itemNumber)
        {
            inventoryBtn[itemNumber].Click();
            isElementPresented(inventoryBtn[itemNumber]);
            return this;
        }

        public ProductsPage VerifyButtonNameChanging(string expectedBtnTitle, int itemNumber)
        {
            Assert.AreEqual(expectedBtnTitle, inventoryBtn[itemNumber].Text);
            return this;
        }
    }
}
