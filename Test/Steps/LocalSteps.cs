using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Test.Base;
using Test.Pages;

namespace Test.Steps
{
    [Binding]
    class LocalSteps
    {
        private HomePage homePage;

        [Given(@"I go to home page")]
        public void GivenIGoToHomePage()
        {
            homePage = PageFactory.Instance.CurrentPage.GetInstance<HomePage>();
            homePage.Navigate();
        }

        [Given(@"I click something")]
        public void GivenIClickSomething()
        {
            var localPage = new LocalPage();
            localPage.checkOurApplication();
        }


    }
}
