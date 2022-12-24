using System;
using ESPN_Specflow_Nunit.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace ESPN_Specflow_Nunit
{
    [Binding]
    public class ESPNHeadlineFeatureSteps
    {
        //browserFactory Bf = new browserFactory();
        IWebDriver driver;
        homePage homeP;

        [Before]
        public void Start()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            homeP = new homePage(driver);
        }

        [Given(@"user is on ESPN home page")]
        public void GivenUserIsOnESPNHomePage()
        {
            //navidating to page
            driver.Navigate().GoToUrl("http://espn.com");
        }

        [Then(@"save first headline to a text file")]
        public void GivenSaveFirstHeadlineToATextFile()
        {
            homeP.SaveHeadline();
        }
        
        [Then(@"take a screenshot of the home screenshot")]
        public void ThenTakeAScreenshotOfTheHomeScreenshot()
        {
            homeP.Screenshot();
        }

        [After]
        public void CloseBrowser()
        {
            driver.Close();
            driver.Quit();
        }
    }
}
