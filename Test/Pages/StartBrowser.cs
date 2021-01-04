using OpenQA.Selenium;
using Test.Base;
using Test.Extensions;
using Test.Utilities;

namespace Test.Pages
{
    public class StartBrowser : Navigation
    {
         string gmailSelector = "gb_g";
         string googleAgree = "/html/body/div/c-wiz/div[2]/div/div/div/div/div[2]/form/div/span";
         string iframe = "//iframe";
         string verifyGmail = "h-c-headline--one";

        public void Navigate(string url)
        {
            Browser.Start().Navigate().GoToUrl(url);
        }

        public void clickMenu()
        {
            Browser.Driver.SwitchTo().DefaultContent();
            var element = Browser.Driver.FindElement(By.ClassName(gmailSelector), 20);
            element.Click();
        }

        public void clickAgree()
        {
            Browser.Driver.SwitchTo().Frame(Browser.Driver.FindElement(By.XPath(iframe), 20));
            var element = Browser.Driver.FindElement(By.XPath(googleAgree), 20);
            element.Click();
           
        }

        public string checkIfGmail()
        {
          var element = Browser.Driver.FindElement(By.ClassName(verifyGmail), 20);
          var text = element.Text;
            return text;
        }

    }
}
