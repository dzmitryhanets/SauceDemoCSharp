using BoDi;
using SauceDemoCSharp.Pages;
using TechTalk.SpecFlow;

namespace SauceDemoCSharp.Steps
{
    [Binding]
    class CartPageSteps : BasePageSteps
    {
        private readonly CartPage cartPage;

        protected CartPageSteps(IObjectContainer container) : base(container)
        {
            cartPage = new CartPage(Driver);
        }

        [When(@"user clicks Continue Shopping btn")]
        public void WhenUserClickContinueBtn()
        {
            cartPage.ClickContinueShoppingBtn();
        }
    }
}
