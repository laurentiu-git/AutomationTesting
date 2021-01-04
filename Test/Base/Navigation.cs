using Test.Config;
using Test.Pages;

namespace Test.Base
{
    public class Navigation : BasePage
    {
        internal StartBrowser StartBrowser()
        {
            var startBrowser = GetInstance<StartBrowser>();
            startBrowser.Navigate(Settings.URL);
            return startBrowser;
        }

        public void doSomething()
        {
            //
        }
    }
}
