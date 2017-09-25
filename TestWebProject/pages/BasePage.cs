﻿using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using TestWebProject.webdriver;
using TestWebProject.Webdriver;
using TestWebProject.WebdriverConfiguration;

namespace TestWebProject.forms
{
	public class BasePage : AbstractPage
	{
		public BasePage(By locator) : base(locator)
		{
			PageFactory.InitElements(Browser.GetDriver(), this);	
		}

	    private Button ComposeButton = new Button(By.XPath(".//*[@gh='cm']"), "Compose Button");


  //      [FindsBy(How = How.XPath, Using = ".//*[@gh='cm']")]
		//private IWebElement ComposeButon;

		[FindsBy(How = How.XPath, Using = ".//a[contains(@href, '#drafts')]")]
		private IWebElement DraftsLink;

		[FindsBy(How = How.XPath, Using = ".//a[contains(@href, '#sent')]")]
		private IWebElement SentMailLink;

		[FindsBy(How = How.XPath, Using = ".//*[@gh='tm']//*[@act='20' and @role='button']")]
		private IWebElement Refresh;

		public DraftsPage NavigateToDrafts()
		{
			DraftsLink.Click();

			Thread.Sleep(5000);

            SerilogLogger.Logger.Information("Navigate to Drafts Page");

			return new DraftsPage();
		}

		public void WaitForDraftsListAppeared()
		{
			new WebDriverWait(Browser.GetDriver(), TimeSpan.FromSeconds(3)).Until(
				ExpectedConditions.ElementIsVisible(By.XPath(".//*[@class='AO']//*[@role ='main']")));
		}


		public SentMailPage NavigateToSentMail()
		{
			SentMailLink.Click();

			Thread.Sleep(5000);

			return new SentMailPage();
		}

		public ComposeEmailDialogPage OpenComposeEmailDialog()
		{
		    ComposeButton.Click();

			return new ComposeEmailDialogPage();
		}
	}
}
