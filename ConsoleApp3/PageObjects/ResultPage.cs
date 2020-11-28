using OpenQA.Selenium;

namespace ConsoleApp3.PageObjects
{
    class ResultPage : BasePageObject
    {
        //private IWebDriver driver;

        //public ResultPage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //   // SeleniumExtras.PageObjects.PageFactory.InitElements(driver, this);
        //}

        //[FindsBy(How = How.CssSelector, Using = "#posts-container>article:nth-child(1)")]
        //private IWebElement firstArticle;

        const string firstArticleLocator = ".fusion-posts-container>article:nth-child(1) h2";
        public void clickOnFirstArticle()
        {
            var firstArticle = Driver.FindElement(By.CssSelector(firstArticleLocator)); //.fusion-posts-container>article:nth-child(1) .fusion-flexslider
            firstArticle.Click();
        }

       
    }
}