using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Test.Base;
using Test.Extensions;
using Test.Utilities;

namespace Test.Pages
{
    class LocalPage : Navigation
    {

        public void checkOurApplication()
        {
            var application = Browser.Driver.FindElement(Element.application, 20);
            Assert.That(application.Text.Equals("Our Application"));
        }
    }
}
