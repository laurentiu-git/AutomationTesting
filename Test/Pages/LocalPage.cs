using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Base;
using Test.Extensions;
using Test.Utilities;

namespace Test.Pages
{
    class LocalPage : Navigation
    {

        public void checkOurApplication()
        {
            var application = Browser.Driver.FindElement(Element.application, 20);;
            Assert.That(application.Text.Equals("Our Application"));
        }
    }
}
