using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoCSharp.Pages
{
    class ProductsPage : BasePage
    {
        private string productsTitle => Driver.FindElement(By.ClassName("title")).Text;
        
        public ProductsPage(IWebDriver driver) : base(driver)
        {
        }

        public ProductsPage VerifyRedirectToProducts(String expectedTitle)
        {
            Assert.AreEqual(expectedTitle, productsTitle);
            return this;
        }
    }
}
