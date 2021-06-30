using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SauceDemoCSharp.Pages
{
    class LoginPage : BasePage
    {

        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        String URL = "https://www.saucedemo.com";
        private IWebElement userName => Driver.FindElement(By.Id("user-name"));
        private IWebElement passwordField => Driver.FindElement(By.Id("password"));
        private IWebElement loginBtn => Driver.FindElement(By.XPath("//input[@class='submit-button btn_action']"));
        private IWebElement productsTitle => Driver.FindElement(By.XPath("//div[contains(text(),'Products')]"));
        private IWebElement incorrectMsg => Driver.FindElement(By.XPath("//h3[@data-test='error']"));


        public LoginPage OpenPage()
        {
            Driver.Navigate().GoToUrl(URL);
            return this;
        }

        
        public LoginPage inputName(String name)
        {
            userName.SendKeys(name);
            return this;
        }

        public LoginPage inputPassword(String password)
        {
            passwordField.SendKeys(password);
            return this;
        }

        public LoginPage clickLoginBtn()
        {
            loginBtn.Click();
            return this;
        }

        public LoginPage verifyIncorrectLogin(String errorMsg)
        {
            Assert.IsTrue(incorrectMsg.Text.Equals(errorMsg), "Correct message displayed");
            return this;
        }
    }
}
