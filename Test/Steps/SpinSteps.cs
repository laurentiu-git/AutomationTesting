using Test.Pages;
using TechTalk.SpecFlow;
using Test.Config;
using Test.Base;
using NUnit.Framework;
using Test.Utilities;

namespace Test.Steps
{
    [Binding]
    class GetToGoogleSteps
    {
        private HomePage homePage;
        private LoginPage loginPage;
        private TrailandTreatsPage trailandTreatsPage;
        
        [Given(@"I go to Casion")]
        public void GivenIGoToCasion()
        {
            homePage = PageFactory.Instance.CurrentPage.GetInstance<HomePage>();
            homePage.Navigate();
        }

        [Given(@"I check URL")]
        public void GivenICheckURL()
        {
            Assert.AreEqual("","");
        }

        [Given(@"I Log In")]
        public void GivenILogIn()
        {
            loginPage = PageFactory.Instance.CurrentPage.GetInstance<HomePage>().GotoLoginPage();
            loginPage.Authenticate(Settings.Username, Settings.Password);
        }

        [Then(@"I expect to be LoggedIn")]
        public void ThenIExpectToBeLoggedIn()
        {
            homePage.VerrifyIfLoggedIn(Settings.Username);
        }

        [Then(@"I go to the ""(.*)"" game")]
        public void ThenIGoToTheGame(string gameToSearchFor)
        {
            homePage.GoToGame(gameToSearchFor);
        }

        [Then(@"I click on demo button")]
        public void ThenIClickOnDemoButton()
        {
            trailandTreatsPage = PageFactory.Instance.CurrentPage.GetInstance<TrailandTreatsPage>();
            trailandTreatsPage.ClickDemo();

        }

        [Then(@"I click on spin button")]
        public void ThenIClickOnSpinButton()
        {
            trailandTreatsPage.ClickSpinBtn();
        }
    }
}
