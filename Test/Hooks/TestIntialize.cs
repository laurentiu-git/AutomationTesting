using Test.Config;
using Test.Utilities;
using TechTalk.SpecFlow;

namespace Test.Hooks
{
    [Binding]
    public sealed class TestIntialize
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            ConfigReader.InitializeSettings("DemoBranch");
            Browser.KillChromeProcesses();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Browser.Stop();
        }
    }
}
