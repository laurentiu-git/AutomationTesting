using Test.Pages;
using TechTalk.SpecFlow;
using Test.Config;
using Test.Base;

namespace Test.Steps
{
    [Binding]
    class SppecFlowFeature1
    {
       // private StartBrowser startBrowser;

        [Given(@"I go to Google")]
        public void GivenIGoToGoogle()
        {

            //    var startBrowser =  new StartBrowser();
            //    string google = "https://www.google.com";
            //   startBrowser.Navigate(google);
           var page = PageFactory.Instance.CurrentPage.GetInstance<StartBrowser>();
            page.StartBrowser();
        }

    }
}
