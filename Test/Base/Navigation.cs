using OpenQA.Selenium;
using Test.Config;
using Test.Extensions;
using Test.Pages;
using Test.Utilities;

namespace Test.Base
{
    public class Navigation : BasePage
    {

        private static string LoginSelector = "login_buttons_login_text";

        internal LoginPage GotoLoginPage()
        {
            ClickLoginButton();
            return new LoginPage();
        }

        private void ClickLoginButton()
        {
            var loginElement = Browser.Driver.FindElement(By.ClassName(LoginSelector), 20);
            loginElement.Click();
        }
    }
}
