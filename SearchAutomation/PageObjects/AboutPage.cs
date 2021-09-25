using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace SearchAutomation.PageObjects
{
    class AboutPage : BasePageObject
    {
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