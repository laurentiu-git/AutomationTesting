using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Base
{
   public class BasePage
    {
        public TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            var T = Activator.CreateInstance(typeof(TPage));
            return (TPage)T;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}
