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
            IWebElement element = null;
            bool flag = false;
            //GCDriver.SwitchTo().Frame(0);
            if (TryFindElement(By.CssSelector("[href *= 'webcal://improvingliteracy.org/calendar-created/ical/%2A/calendar.ics']"), out element))
            {
                bool visable = IsElementVisible(element);
                if (visable == true)
                    flag = true;
                else
                    flag = false;

                Assert.IsTrue(flag);
            }
            else
                flag = false;
            Assert.IsTrue(flag);
        }
        [TestMethod]
        public void TestButtonArchive()
        {
            IWebElement element = null;
            bool flag = false;
            //GCDriver.SwitchTo().Frame(0); href="/events/archived"
            if (TryFindElement(By.CssSelector("[href *= '/events/archived']"), out element))
            {
                bool visable = IsElementVisible(element);
                if (visable == true)
                    flag = true;
                else
                    flag = false;

                Assert.IsTrue(flag);
            }
            else
                flag = false;
            Assert.IsTrue(flag);
            GCDriver.FindElement(By.CssSelector("[href *= '/events/archived']")).Click();
           Assert.IsTrue( GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("Archived Events & Opportunities"));
        }

        public bool TryFindElement(By by, out IWebElement element)
        {
            try
            {
                element = GCDriver.FindElement(by);
            }
            catch (NoSuchElementException ex)
            {
                element = null;
                return false;
            }
            return true;
        }

        public bool IsElementVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }

        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }
    }
}
