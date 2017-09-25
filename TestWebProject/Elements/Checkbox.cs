using OpenQA.Selenium;
using System;
using TestWebProject.webdriver;
using TestWebProject.WebdriverConfiguration;

namespace TestWebProject.Elements
{
	public class Checkbox : BaseElement
	{
		protected By ButtonLocator;
		protected Checkbox CheckBoxElement;
	    protected string ElementName;

		public Checkbox(By locator, string name) : base(locator, name)
		{
		    ElementName = name;
			ButtonLocator = locator;
		}

		public override void Click()
		{
			var button = Browser.GetDriver().FindElement(this.Locator);
			button.Click();
		}
	}
}
