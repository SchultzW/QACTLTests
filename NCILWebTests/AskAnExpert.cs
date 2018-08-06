using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NCILWebTests
{
    [TestClass]
    public class AskAnExpert
    {

        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {

            GCDriver = new ChromeDriver();
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/ask-an-expert");
        }
        [TestMethod]
        public void TestTitle()
        {
            Assert.IsTrue(GCDriver.Title.Equals("Ask an Expert | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.ClassName("page__title")).Text.Equals("Ask an Expert"));
        }
        [TestMethod]
        public void ScreeningAndID1()
        {
            GCDriver.FindElement(By.LinkText("Can a young child (under age 6) be diagnosed with dyslexia or at that age is the focus on recognizing warning signs?")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Can a young child (under age 6) be diagnosed with dyslexia or at that age is the focus on recognizing warning signs? | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.Id("page-title")).Text.Equals("Can a young child (under age 6) be diagnosed with dyslexia or at that age is the focus on recognizing warning signs?"));
            IsElementPresentClassName("action");
            IsElementPresentClassName("figure");
            IsElementPresentLinkText("Related Resources");

        }
        [TestMethod]
        public void ScreeningAndID2()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElement(By.LinkText("What is the relationship between MTSS and diagnosis of dyslexia? Does MTSS slow down the diagnosis?")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("What is the relationship between MTSS and diagnosis of dyslexia? Does MTSS slow down the diagnosis? | National Center on Improving Literacy"));
            IsElementPresentClassName("action");
            IsElementPresentClassName("figure");
            IsElementPresentLinkText("Related Resources");
        }
        [TestMethod]
        public void LegislationAndPolicy()
        {
            GCDriver.Manage().Window.Maximize();
            GCDriver.FindElement(By.XPath("//*[@id='ui-accordion-1-header-1']/a")).Click();
            WaitUntilElementClickable(By.LinkText("Does Special Education law include dyslexia?"));
            GCDriver.FindElement(By.LinkText("Does Special Education law include dyslexia?")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Does Special Education law include dyslexia? | National Center on Improving Literacy"));
            IsElementPresentClassName("action");
            IsElementPresentClassName("figure");
            IsElementPresentLinkText("Related Resources");
        }



        public static IWebElement WaitUntilElementClickable(By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(GCDriver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
        public void IsElementPresentXpath(string whereToLook)
        {
            IWebElement element = null;
            bool flag = false;
            if (TryFindElement(By.XPath(whereToLook), out element))
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
        public void IsElementPresentLinkText(string whereToLook)
        {
            IWebElement element = null;
            bool flag = false;
            if (TryFindElement(By.LinkText(whereToLook), out element))
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
        public void IsElementPresentClassName(string whereToLook)
        {
            IWebElement element = null;
            bool flag = false;
            if (TryFindElement(By.ClassName(whereToLook), out element))
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
        public void IsElementPresentCSS(string whereToLook)
        {
            IWebElement element = null;
            bool flag = false;
            if (TryFindElement(By.CssSelector(whereToLook), out element))
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
        public static bool TextCheckMethodClassName(string txtToCheck, string whereToCheck)
        {

            //method for testing if a supplied text a certain location (using class name) is found
            if (GCDriver.FindElement(By.ClassName(whereToCheck)).Text.Equals(txtToCheck) == true)

                return true;
            else
                return false;
        }
        public static bool TextCheckMethodCSS(string txtTocheck, string whereToCheck)
        {
            if (GCDriver.FindElement(By.CssSelector(whereToCheck)).Text.Equals(txtTocheck) == true)
                return true;
            else
                return false;
        }
        public static bool TextCheckMethodXPath(string txtTocheck, string whereToCheck)
        {
            if (GCDriver.FindElement(By.XPath(whereToCheck)).Text.Equals(txtTocheck) == true)
                return true;
            else
                return false;
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
