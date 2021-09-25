using OpenQA.Selenium;

namespace SearchAutomation.PageObjects
{
    class ResultPage : BasePageObject
    {
        const string firstArticleLocator = "h2 a";
        public void clickOnFirstArticle()
        {
            var firstArticle = Driver.FindElement(By.CssSelector(firstArticleLocator)); //.fusion-posts-container>article:nth-child(1) .fusion-flexslider
            firstArticle.Click();
        }

       
    }
}