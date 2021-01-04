using Test.Pages;

namespace Test.Base
{
    public class Navigation : BasePage
    {
        internal StartBrowser StartBrowser()
        {
            var startBrowser = GetInstance<StartBrowser>();
            startBrowser.Navigate("https://www.google.com");
            return startBrowser;
        }

        public void doSomething()
        {
            //
        }
    }
}
