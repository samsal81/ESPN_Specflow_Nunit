using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ESPN_Specflow_Nunit.pages
{
    class homePage
    {
        IWebDriver driver;
        public homePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //By TopHeadline = By.XPath("//div/section[3]/div[1]/section/ul/li[1]/a");

        public void saveHeadline()
        {

            String headlinetxt = driver.FindElement(By.XPath("//div/section[3]/div[1]/section/ul/li[1]/a")).Text;

            Console.WriteLine("Top Headline is: " + headlinetxt);

            FileStream f = new FileStream("C:\\Users\\Samsa\\source\\repos\\ESPN_Specflow_Nunit\\data\\Logoutput.txt", FileMode.Create);

            StreamWriter s = new StreamWriter(f);
            s.WriteLine(headlinetxt);

            s.Close();
            f.Close();
        }

        public void screenshot()
        {
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();

            image.SaveAsFile("C:\\Users\\Samsa\\source\\repos\\ESPN_Specflow_Nunit\\data\\pic.png", ScreenshotImageFormat.Png);
        }
    }
}
