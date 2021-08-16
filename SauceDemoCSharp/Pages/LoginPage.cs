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
        private IWebElement UserName => Driver.FindElement(By.Id("user-name"));
        private IWebElement PasswordField => Driver.FindElement(By.Id("password"));
        private IWebElement LoginBtn => Driver.FindElement(By.XPath("//input[@class='submit-button btn_action']"));
        //private IWebElement ProductsTitle => Driver.FindElement(By.XPath("//div[contains(text(),'Products')]"));
        private IWebElement IncorrectMsg => Driver.FindElement(By.XPath("//h3[@data-test='error']"));


        public LoginPage OpenPage()
        {
            Driver.Navigate().GoToUrl(URL);
            return this;
        }

        
        public LoginPage InputName(String name)
        {
            UserName.SendKeys(name);
            return this;
        }

        public LoginPage InputPassword(String password)
        {
            PasswordField.SendKeys(password);
            return this;
        }

        public LoginPage ClickLoginBtn()
        {
            LoginBtn.Click();
            return this;
        }

        public LoginPage VerifyIncorrectLogin(String errorMsg)
        {
            Assert.IsTrue(IncorrectMsg.Text.Equals(errorMsg), "Correct message displayed");
            return this;
        }
    }
}
