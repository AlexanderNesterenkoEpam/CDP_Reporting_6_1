using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestWebProject.webdriver;
using TestWebProject.WebdriverConfiguration;

namespace TestWebProject.Elements
{
    public class Link : BaseElement
    {
        public Link(By locator, string elementName) : base(locator, elementName)
        {

        }

        public override void Click()
        {
            SerilogLogger.Logger.Information("Click link: " + this.ElementName);

            base.Click();
        }
    }
}
