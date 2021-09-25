using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchAutomation.PageObjects
{
    public class BasePageObject
    {
        private static IWebDriver driver;

        //private int driver;

        public static IWebDriver Driver
        {
            //get { return driver; }
            get
            {
                if (driver == null)
                {
                    Setup();
                }
                return driver;
            }
        }

        public static void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized"); //driver.Manage().Window.Maximize();
            options.AddArgument("disable-notifications");
            //var driver = new ChromeDriver(Environment.CurrentDirectory, options);
            driver = new ChromeDriver("..\\..\\..\\Resources", options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

        }
        public void DisposeDriver()
        {
            driver.Close();
        }
    }

}
