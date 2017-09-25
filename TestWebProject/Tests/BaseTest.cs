using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TestWebProject.WebdriverConfiguration;

namespace TestWebProject.webdriver
{
	[TestClass]
	public class BaseTest
	{
		public TestContext TestContext { get; set; }
		protected static Browser Browser = Browser.Instance;

		[TestInitialize]
		public void InitTest()
		{
			Browser = Browser.Instance;
			Browser.WindowMaximise();
			Browser.NavigateTo(Configuration.StartUrl);
		}

		[TestCleanup]
		public void CleanTest()
		{
		    Browser.TakeScreenshot();

            Browser.Quit();
		}
	}
}