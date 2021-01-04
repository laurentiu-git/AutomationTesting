using Test.Config;
using Test.Utilities;
using TechTalk.SpecFlow;

namespace Test.Hooks
{
    [Binding]
    public sealed class TestIntialize
    {
        [BeforeFeature]
        public static void BeforeScenario()
        {
            ConfigReader.InitializeSettings("DemoBranch");
            Browser.KillChromeProcesses();
        }

        [AfterFeature]
        public static void AfterScenario()
        {
            Browser.Stop();
        }
    }
}
