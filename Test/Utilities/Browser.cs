using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Test.Utilities
{
    public class Browser
    {
        public Browser()
        {

        }
        public static ChromeDriver Driver { get; set; }

        public static ChromeDriver Start()
        {
            var options = new ChromeOptions();
         options.AddArgument("start-maximized"); // open Browser in maximized mode
         options.AddArgument("disable-infobars"); // disabling infobars
         options.AddArgument("--disable-extensions"); // disabling extensions
         options.AddArgument("--disable-gpu"); // applicable to windows os only
         options.AddArgument("--disable-dev-shm-usage"); // overcome limited resource problems
         options.AddArgument("--no-sandbox"); // Bypass OS security model
         options.AddArgument("--headless");

            Driver  = new ChromeDriver(options);
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            return Driver;
        }

        public static void Stop()
        {
            if (Driver != null)
                Driver.Quit();
        }

        public static void KillChromeProcesses()
        {
            Process[] chromeDriverProcesses = Process.GetProcessesByName("chromedriver");
            foreach (var chromeDriverProcess in chromeDriverProcesses)
            {
                chromeDriverProcess.Kill();
            }
        }
    }
}
