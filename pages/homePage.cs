﻿using OpenQA.Selenium;
using System;
using System.IO;

namespace ESPN_Specflow_Nunit.pages
{
    class homePage
    {
        readonly IWebDriver driver;
        public homePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //By TopHeadline = By.XPath("//div/section[3]/div[1]/section/ul/li[1]/a");

        public void SaveHeadline()
        {

            string headlinetxt = driver.FindElement(By.XPath("//div/section[3]/div[1]/section/ul/li[1]/a")).Text;

            Console.WriteLine($"Top Headline is: {headlinetxt}");

            FileStream f = new FileStream("C:\\Users\\Samsa\\source\\repos\\ESPN_Specflow_Nunit\\data\\LogOutput" + DateTime.Now.ToString("_MM-dd_HH-mm-ss") + ".txt", FileMode.Create);

            StreamWriter s = new StreamWriter(f);
            s.WriteLine(headlinetxt);

            s.Close();
            f.Close();
        }

        public void Screenshot()
        {
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();

            image.SaveAsFile("C:\\Users\\Samsa\\source\\repos\\ESPN_Specflow_Nunit\\data\\ScreenShot"+ DateTime.Now.ToString("_MM-dd_HH-mm-ss") + ".png", ScreenshotImageFormat.Png);
        }
    }
}
