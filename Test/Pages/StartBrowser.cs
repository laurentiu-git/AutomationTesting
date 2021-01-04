using Test.Base;
using Test.Utilities;

namespace Test.Pages
{
    public class StartBrowser : Navigation
    {

        public void Navigate(string url)
        {
            Browser.Start().Navigate().GoToUrl(url);
        }

        public void otherSomething()
        {
            doSomething();
        }
    }
}
