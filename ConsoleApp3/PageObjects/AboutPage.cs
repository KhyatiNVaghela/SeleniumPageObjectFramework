

using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace ConsoleApp3.PageObjects
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


        const string mainMenuSearchButtonLocator = "ul#menu-main li.fusion-main-menu-search a";

        const string searchTextElementLocator = ".fusion-custom-menu-item-contents input[class='s']";
        
        const string searchResultElementClickLocator = ".fusion-custom-menu-item-contents input.fusion-search-submit";

        public ResultPage search(string text)
        {
            //ul#menu-main li.fusion-main-menu-search a
            var mainMenuSearchButtonElement = Driver.FindElement(By.CssSelector(mainMenuSearchButtonLocator));
            mainMenuSearchButtonElement.Click();

            var searchTextElement = Driver.FindElement(By.CssSelector(searchTextElementLocator));
            searchTextElement.SendKeys(text);

            //wait.Until(ExpectedConditions.ElementToBeClickable(By.CssSelector("#sidebar .searchsubmit"))).Click();

            var searchResultElementClickElement = Driver.FindElement(By.CssSelector(searchResultElementClickLocator));
            searchResultElementClickElement.Click();
            return new ResultPage();
        }
    }
}