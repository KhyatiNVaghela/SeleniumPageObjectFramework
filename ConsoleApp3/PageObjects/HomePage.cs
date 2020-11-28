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

        //[FindsBy(How = How.CssSelector, Using = ".fusion-main-menu a[href*='about']")]
        //private IWebElement about;

        //[FindsBy(How = How.ClassName, Using = "fusion-main-menu-icon")]
        //private IWebElement searchIcon;

        public void goToPage()
        {
            Driver.Navigate().GoToUrl("http://www.swtestacademy.com");
        }

        public AboutPage goToAboutPage()
        {
            //new FindsByAttribute().
            var about = Driver.FindElement(By.CssSelector(".fusion-main-menu a[href*='about']"));
            about.Click();
            return new AboutPage();
        }
    }
}