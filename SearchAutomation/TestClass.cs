﻿using SearchAutomation.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SearchAutomation
{
    public class TestClass
    {
        [Test]
        public void SearchTextFromAboutPage()
        {
            
            HomePage home = new HomePage();
            
            //Step 1 go to home page load site
            home.goToPage();
            //Step 2 click about page 
            AboutPage about = home.goToAboutPage();
            //Step 3 Click on magnifying glass -> search "selenium c#" -> click on first result
            ResultPage result = about.search("selenium c#");


            result.clickOnFirstArticle();
           
            //need to add layer for dispose of driver
           // result.TearDown();
        }

        [TearDown]
        public void TearDown()
        {
            var basePageObject = new BasePageObject();
            basePageObject.DisposeDriver();
        }
    }
}