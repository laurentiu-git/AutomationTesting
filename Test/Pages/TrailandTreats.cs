using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Threading;
using Test.Base;
using Test.Extensions;
using Test.Utilities;

namespace Test.Pages
{
    public class TrailandTreatsPage: Navigation
    {
        public void ClickDemo()
        {
            var closeFormElement = Browser.Driver.FindElement(Element.demoSelector, 10);
            closeFormElement.Click();

            Browser.Driver.SwitchTo().Frame(Browser.Driver.FindElement(Element.iframeSelector));
            var gamvasElement = Browser.Driver.FindElement(Element.gameCanvaSelector, 40);

            Thread.Sleep(10000);

            Actions action = new Actions(Browser.Driver);
            action.MoveToElement(gamvasElement, 650, 610).Click().DoubleClick().Build().Perform();
        }

        public void ClickSpinBtn()
        {
            var spinBtnElement = Browser.Driver.FindElement(Element.spinSelector, 10);
            spinBtnElement.Click();
        }
    }
}