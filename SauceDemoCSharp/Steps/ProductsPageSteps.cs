using BoDi;
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

        [When(@"user selects item #'(.*)' on Products page")]
        public void WhenUserSelectsItem(int itemNumber)
        {
            productsPage.RedirectToItemPage(itemNumber);
        }

        [When(@"user clicks inventory button for item #'(.*)'")]
        public void WhenUserCkicksInventoryBtn(int itemNumber)
        {
            productsPage.ClickItemInventoryBtn(itemNumber);
        }

        [Then(@"button title for item #'(.*)' is changed to '(.*)'")]
        public void ThenButtonTitleChanged(int itemNumber, string expectedTitle)
        {
            productsPage.VerifyButtonNameChanging(expectedTitle, itemNumber);
        }
    }
}
