using OpenQA.Selenium;
using Test.Base;
using Test.Extensions;
using Test.Utilities;

namespace Test.Pages
{
     class LoginPage : Navigation
    {

        public void Authenticate(string username, string password)
        {
            InsertUserName(username, password);
            ClickSubmitLoginBtn();
            ClickClosePopUpBtn();
        }
        private void InsertUserName(string username, string password)
        {
            var usernameElement = Browser.Driver.FindElement(Element.usernameSelector, 10);
            var passwordElement = Browser.Driver.FindElement(Element.passwordSelector, 10);
            usernameElement.SendKeys(username);
            passwordElement.SendKeys(password);
        }

        private void ClickSubmitLoginBtn()
        {
            var submitButtonElement = Browser.Driver.FindElement(Element.submitSelector, 10);
            submitButtonElement.Click();
        }

        private void ClickClosePopUpBtn()
        {
            var closeFormElement = Browser.Driver.FindElement(Element.closePopUpSelector, 10);
            closeFormElement.Click();
        }
    }
}