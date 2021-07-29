using BoDi;
using SauceDemoCSharp.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SauceDemoCSharp.Steps
{
    [Binding]
    class ItemPageSteps : BasePageSteps
    {
        private readonly ItemPage itemPage;
        protected ItemPageSteps(IObjectContainer container) : base(container)
        {
            itemPage = new ItemPage(Driver);
        }

        [Then(@"Item page is opened for '(.*)' item")]
        public void ThenItemPageIsOpened(string selectedItem)
        {
            itemPage.VerifyItemPage(selectedItem);
        }
    }
}
