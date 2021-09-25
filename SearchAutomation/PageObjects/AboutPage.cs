

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace SearchAutomation.PageObjects
{
    class AboutPage : BasePageObject
    {
        // private IWebDriver driver;
        // private WebDriverWait wait;

        //public AboutPage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //   // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //    //SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        //}

        //[FindsBy(How = How.CssSelector, Using = "#sidebar input[class='s']")]
        //private IWebElement searchText;


        const string mainMenuSearchButtonLocator = "span.menu-bar-item";

        const string searchTextElementLocator = "input.search-field";
        
        const string searchResultElementClickLocator = ".fusion-custom-menu-item-contents input.fusion-search-submit";

        public ResultPage search(string text)
        {
            var mainMenuSearchButtonElement = Driver.FindElement(By.CssSelector(mainMenuSearchButtonLocator));
            mainMenuSearchButtonElement.Click();

            var searchTextElement = Driver.FindElement(By.CssSelector(searchTextElementLocator));
            searchTextElement.SendKeys(text);
            searchTextElement.SendKeys(Keys.Enter);

            return new ResultPage();
        }
    }
}