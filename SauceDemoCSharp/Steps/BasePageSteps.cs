using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using SauceDemoCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SauceDemoCSharp.Steps
{
    class BasePageSteps
    {
        public readonly IObjectContainer Container;
        public IWebDriver Driver;

        protected BasePageSteps(IObjectContainer container)
        {
            Container = container;

            Driver = container.Resolve<IWebDriver>();
        }
    }
}
