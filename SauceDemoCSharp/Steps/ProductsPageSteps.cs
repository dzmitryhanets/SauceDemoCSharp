using BoDi;
using OpenQA.Selenium;
using SauceDemoCSharp.Pages;
using TechTalk.SpecFlow;

namespace SauceDemoCSharp.Steps
{
    [Binding]
    class ProductsPageSteps : BasePageSteps
    {
        private readonly ProductsPage productsPage;
        protected ProductsPageSteps(IObjectContainer container) : base(container)
        {
            productsPage = new ProductsPage(Driver);
        }

        [Then(@"user is redirected to '(.*)' page")]
        public void ThenUserIsRedirectedTo(string expectedTitle)
        {
            productsPage.VerifyRedirectToProducts(expectedTitle);
        }

        [When(@"user selects item #'(.*)' on Products page")]
        public void WhenUserSelectsItem(int itemNumber)
        {
            productsPage.RedirectToItemPage(itemNumber);
        }
    }
}
