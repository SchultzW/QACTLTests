using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace NCILWebTests
{
    [TestClass]
    public class Events
    {
        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {

            GCDriver = new ChromeDriver();
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/events");
        }
        [TestMethod]
        public void TestTitle()
        {
            Assert.IsTrue(GCDriver.Title.Equals("Events & Opportunites | National Center on Improving Literacy"));
        }
        [TestMethod]
        public void TestHeaderText()
        {
          Assert.IsTrue(GCDriver.FindElement(By.Id("block-block-8")).Text.Equals("Find upcoming regional professional development, workshops, and conferences."));
        }
        [TestMethod]
        public void TestButtonSubscribe()
        {
            TestingClass.IsElementPresentCSS("[href *= 'webcal://improvingliteracy.org/calendar-created/ical/%2A/calendar.ics']", GCDriver);
         
        }
        [TestMethod]
        public void TestButtonArchive()
        {
            TestingClass.IsElementPresentCSS("[href *= '/events/archived']", GCDriver);
           
            GCDriver.FindElement(By.CssSelector("[href *= '/events/archived']")).Click();
           Assert.IsTrue( GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("Archived Events & Opportunities"));
        }



        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }
    }
}
