using NUnit.Framework;
using OpenQA.Selenium;
using Test.Base;
using Test.Config;
using Test.Extensions;
using Test.Utilities;

namespace Test.Pages
{
    class HomePage: Navigation
    {
        public void Navigate()
        {
            Browser.Start().Navigate().GoToUrl(Settings.URL);
        }

        public void VerrifyIfLoggedIn(string expectedUserName)
        {
            var usernameElement = Browser.Driver.FindElement(Element.userSelector, 20);
            Assert.That(expectedUserName.ToLower().Equals(usernameElement.Text.ToLower()));
        }

        public void GoToGame(string gameToSearch)
        {
            var searchElement = Browser.Driver.FindElement(Element.searchGameSelector, 10);
            searchElement.SendKeys(gameToSearch);
            var firstGameResultElement = Browser.Driver.FindElement(Element.gameSearched, 10);
            firstGameResultElement.Click();
        }
    }

}
