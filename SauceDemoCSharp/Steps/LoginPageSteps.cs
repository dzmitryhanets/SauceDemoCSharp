using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using SauceDemoCSharp.Pages;
using SauceDemoCSharp.Utils;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SauceDemoCSharp.Steps
{
    [Binding]
    class LoginPageSteps : BasePageSteps
    {
        private readonly LoginPage loginPage;
        public LoginPageSteps(IObjectContainer container) : base(container)
        {
            loginPage = new LoginPage(Driver);
        }

        [Given(@"SauceDemo page is opened in browser")]
        [When(@"SauceDemo page is opened in browser")]
        public void SauceDemoPageIsOpened()
        {
            loginPage.OpenPage();
        }

        [When(@"login as '(.*)'")]
        public void WhenLoginAsUser(string loginAs)
        {
            var userName = $"@Users.{loginAs}.userName".GetTestData();
            var password = $"@Users.{loginAs}.password".GetTestData();
            loginPage
                .InputName(userName)
                .InputPassword(password)
                .ClickLoginBtn();
        }

        [Then(@"error message '(.*)' appears")]
        public void ThenErrorMessageAppears(string errorMessage)
        {
            loginPage.VerifyIncorrectLogin(errorMessage);
        }
    }
}
