using BoDi;
using SauceDemoCSharp.Pages;
using TechTalk.SpecFlow;

namespace SauceDemoCSharp.Steps
{
    [Binding]
    class HeaderAreaSteps : BasePageSteps
    {
        private readonly HeaderArea headerArea;

        protected HeaderAreaSteps(IObjectContainer container) : base(container)
        {
            headerArea = new HeaderArea(Driver);
        }

        [When(@"user click cart icon")]
        public void WhenClickCartIcon()
        {
            headerArea.ClickCartIcon();
        }
    }
}
