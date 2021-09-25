using OpenQA.Selenium;

namespace SearchAutomation.PageObjects
{
    class HomePage : BasePageObject
    {
        public void goToPage()
        {
            Driver.Navigate().GoToUrl("http://www.swtestacademy.com");
        }

        public AboutPage goToAboutPage()
        {
            var about = Driver.FindElement(By.LinkText("About"));
            about.Click();
            return new AboutPage();
        }
    }
}