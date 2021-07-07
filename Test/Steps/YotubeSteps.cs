using NUnit.Framework;
using System.Threading;
using TechTalk.SpecFlow;
using Test.Base;
using Test.Extensions;
using Test.Pages;
using Test.Utilities;

namespace Test.Steps
{
    [Binding]
    class YotubeSteps
    {
        private HomePage homePage;

        [Given(@"I go to YT")]
        public void GivenIGoToYT()
        {
            homePage = PageFactory.Instance.CurrentPage.GetInstance<HomePage>();
            homePage.Navigate();
        }


        [Given(@"I agree to data")]
        public void GivenIGoToChannelVideo()
        {
            var agreeConditions = Browser.Driver.FindElement(Element.agree, 10);
            agreeConditions.Click();
            Thread.Sleep(20000);
            var title = Browser.Driver.FindElement(Element.title, 10);
            var browserTitle = Browser.Driver.Title;
            Assert.IsTrue(browserTitle.Contains(title.Text));
        }


    }
}
