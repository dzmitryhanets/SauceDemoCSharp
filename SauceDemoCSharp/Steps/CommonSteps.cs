using BoDi;
using SauceDemoCSharp.Pages;
using TechTalk.SpecFlow;

namespace SauceDemoCSharp.Steps
{
    [Binding]
    class CommonSteps : BasePageSteps
    {
        private readonly CommonPage commonPage;

        protected CommonSteps(IObjectContainer container) : base(container)
        {
            commonPage = new CommonPage(Driver);
        }

        [Then(@"page title is '(.*)'")]
        public void ThenPageTitleIs(string expectedTitle)
        {
            commonPage.VerifyPageTitle(expectedTitle);
        }
    }
}
