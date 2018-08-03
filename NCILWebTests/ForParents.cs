using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NCILWebTests
{
    [TestClass]
    public class ForParents
    {
        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {

            GCDriver = new ChromeDriver();
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/family");
        }
        [TestMethod]
        public void TitleTest()
        {
            string title = GCDriver.Title;
            if (title == "Parents & Families | National Center on Improving Literacy")
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }
        [TestMethod]
        public void TestHeader()
        {
            //header title
            Assert.IsTrue(TextCheckMethodClassName("You are here\r\nHome\r\nParents & Families\r\nHelp your child learn to read and write with practical ideas and expert-approved strategies.", "col-sm-8"));
            //header description
            Assert.IsTrue(TextCheckMethodCSS("Help your child learn to read and write with practical ideas and expert-approved strategies.", ".block.block-block.first.last.odd"));
            //Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".container.header-icon")).Displayed;
            IWebElement element = null;
            bool flag = false;
            if (TryFindElement(By.CssSelector(".container.header-icon"), out element))
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
        public void WhatsNewAndFeaturedBrief()
        {
            //tests the literary brieg text
            Assert.IsTrue(TextCheckMethodCSS("What's New", ".panel-pane.pane-custom.pane-7"));
            Assert.IsTrue(TextCheckMethodLinkText("Featured Literacy Brief", "Featured Literacy Brief"));

        }
        [TestMethod]
        public void FeaturedBriefLinkCheck()
        {
            //tests brief links
            GCDriver.FindElement(By.LinkText("Featured Literacy Brief")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Improving Literacy Briefs | National Center on Improving Literacy"));
        }
        [TestMethod]
        public void PhonicAwareness()
        {
            Assert.IsTrue(TextCheckMethodLinkText("Phonemic Awareness", "Phonemic Awareness"));
            // Assert.IsTrue(TextCheckMethodXPath("Definition", "fa fa-info-circle"));
            // Assert.IsTrue(TextCheckMethodCSS(" Learn More", ".fa.fa-graduation-cap"));
            Assert.IsTrue(TextCheckMethodClassName("More Glossary Terms", "more-link"));
            IWebElement element = null;
            bool flag = false;
            if (TryFindElement(By.CssSelector(".fa.fa-graduation-cap"), out element))
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
            if (TryFindElement(By.CssSelector(".fa.fa-info-circle"), out element))
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
        public void PhonicAwarenessLinks()
        {
            GCDriver.FindElement(By.LinkText("Phonemic Awareness")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Phonemic Awareness | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void PhonicAwarenessGlossaryLink()
        {
            GCDriver.FindElement(By.LinkText("More Glossary Terms")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Learning Literacy Glossary | National Center on Improving Literacy"));
        }
        [TestMethod]
        public void AskAnExpertTest()
        {
            TextCheckMethodLinkText("Featured Ask an Expert Question", "Featured Ask an Expert Question");
        }
        [TestMethod]
        public void ArePresent()
        {
            //check if literary brief and experts are visable and present
            
            bool flag = false;
            IList<IWebElement> elements = GCDriver.FindElements(By.ClassName(".panel.panel-default.panel-horizontal"));
            foreach (IWebElement listElement in elements)
            {
                    bool visable = IsElementVisible(listElement);
                    if (visable == true)
                        flag = true;
                    else
                        flag = false;

                    Assert.IsTrue(flag);
            }
        }
        [TestMethod]
        public void TwitterIsPresent()
        {
            IWebElement element = null;
            bool flag = false;
        

            GCDriver.SwitchTo().Frame("twitter-widget-0");
            element = null;
            flag = false;
            if (TryFindElement(By.CssSelector(".timeline-Tweet-brand.u-floatRight"), out element))
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
        public void AskAnExpertLink()
        {
            GCDriver.FindElement(By.LinkText("Featured Ask an Expert Question")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Ask an Expert | National Center on Improving Literacy"));
        }
        [TestMethod]
        public void FeaturedResources()
        {
            GCDriver.FindElement(By.LinkText("Featured Resources")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Resource Repository | National Center on Improving Literacy"));
        }
        [TestMethod]
        public void ToolsAndEvents()
        {
            //tests if the tools and events boxes are present
            
            bool flag = false;
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector(".teal-text"));
            foreach(IWebElement element in elements)
            {

                bool visable = IsElementVisible(element);
                if (visable == true)
                    flag = true;
                else
                    flag = false;

                Assert.IsTrue(flag);
            }
           
        }
        [TestMethod]
        public void KidZone()
        {
            IWebElement element = null;
            bool flag = false;
            if (TryFindElement(By.CssSelector(".panel-pane.pane-custom.pane-8.margin-bottom"), out element))
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
            GCDriver.FindElement(By.XPath("//*[@id='content']/div/div[1]/div[2]/div[1]/div/div/div/div/a")).Click();
            //Assert.IsTrue(GCDriver.Title.Equals("Kid Zone! | Kid Zone! | National Center on Improving Literacy"));
            GCDriver.Title.Equals("Kid Zone! | Kid Zone! National Center on Improving Literacy");
        }


        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
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
        public static bool TextCheckMethodLinkText(string txtTocheck, string linkText)
        {
            if (GCDriver.FindElement(By.LinkText(linkText)).Text.Equals(txtTocheck) == true)
                return true;
            else
                return false;
        }
        //testing these methods may remove
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


    }
}
