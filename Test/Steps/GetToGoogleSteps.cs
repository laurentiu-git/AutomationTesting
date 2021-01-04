using Test.Pages;
using TechTalk.SpecFlow;
using Test.Config;
using Test.Base;

namespace Test.Steps
{
    [Binding]
    class GetToGoogleSteps
    {
       // private StartBrowser startBrowser;

        [Given(@"I go to Google")]
        public void GivenIGoToGoogle()
        {
            var page = PageFactory.Instance.CurrentPage.GetInstance<StartBrowser>();
            page.StartBrowser();

            //    var startBrowser =  new StartBrowser();
            //    string google = "https://www.google.com";
            //   startBrowser.Navigate(google);
        }

        [Given(@"I click on menu")]
        public void GivenIClickOnMenu()
        {
            var page = PageFactory.Instance.CurrentPage.GetInstance<StartBrowser>();
            page.clickMenu();
        }

        [Given(@"I click on Agree")]
        public void GivenIClickOnAgree()
        {
            var page = PageFactory.Instance.CurrentPage.GetInstance<StartBrowser>();
            page.clickAgree();
        }



    }
}
