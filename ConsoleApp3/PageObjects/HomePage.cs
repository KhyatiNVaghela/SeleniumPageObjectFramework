using OpenQA.Selenium;

namespace ConsoleApp3.PageObjects
{
    class HomePage : BasePageObject
    {

        //private IWebDriver driver;

        //public HomePage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //    //PageFactory.InitElements(driver, this);
        //}

        
        
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