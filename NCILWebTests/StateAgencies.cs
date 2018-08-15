using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NCILWebTests
{
    [TestClass]
    public class StateAgencies
    {
        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {
            var options = new ChromeOptions();
            options.AddArgument("headless");
            GCDriver = new ChromeDriver(options);
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state");
        }
        [TestMethod]
        public void TitleTest()
        {
            string title = GCDriver.Title;
            if (title == "State Agencies | National Center on Improving Literacy")
                Assert.IsTrue(true);
            else
                Assert.IsTrue(false);
        }
        [TestMethod]
        public void TestHeader()
        {
            //header title
            Assert.IsTrue(TestingClass.TextCheckMethodClassName("You are here\r\nHome\r\nState Agencies\r\nDevelop and implement state and local structures, procedures and policies to address student challenges in learning to read and write.", "col-sm-8",GCDriver));
            //header description
            Assert.IsTrue(TestingClass.TextCheckMethodCSS("Develop and implement state and local structures, procedures and policies to address student challenges in learning to read and write.", ".block.block-block.first.last.odd",GCDriver));
            //Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".container.header-icon")).Displayed;

            TestingClass.IsElementPresentCSS(".container.header-icon", GCDriver);
         

        }

        [TestMethod]
        public void WhatsNewAndFeaturedBrief()
        {
            //tests the literary brieg text
            Assert.IsTrue(TestingClass.TextCheckMethodCSS("What's New", ".panel-pane.pane-custom.pane-7",GCDriver));
            
            Assert.IsTrue(GCDriver.FindElement(By.LinkText("Featured Literacy Brief")).Text.Equals("Featured Literacy Brief"));
        }
        [TestMethod]
        public void FeaturedBriefLinkCheck()
        {
            //tests brief links
            GCDriver.FindElement(By.LinkText("Featured Literacy Brief")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Improving Literacy Briefs | National Center on Improving Literacy"));
        }

        [TestMethod]
        public void AskAnExpertTest()
        {
            
            Assert.IsTrue(GCDriver.FindElement(By.LinkText("Featured Ask an Expert Question")).Text.Equals("Featured Ask an Expert Question"));
        }
        [TestMethod]
        public void ArePresent()
        {
            //check if literary brief and experts are visable and present

            bool flag = false;
            IList<IWebElement> elements = GCDriver.FindElements(By.ClassName(".panel.panel-default.panel-horizontal"));
            foreach (IWebElement listElement in elements)
            {
                bool visable = TestingClass.IsElementVisible(listElement);
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
            


            GCDriver.SwitchTo().Frame("twitter-widget-0");
            TestingClass.IsElementPresentCSS(".timeline-Tweet-brand.u-floatRight", GCDriver);
          
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
            foreach (IWebElement element in elements)
            {

                bool visable = TestingClass.IsElementVisible(element);
                if (visable == true)
                    flag = true;
                else
                    flag = false;

                Assert.IsTrue(flag);
            }

        }
        [TestMethod]
        public void LiasonPresent()
        {
            
            TestingClass.IsElementPresentCSS(".panel-pane.pane-custom.pane-8",GCDriver);
           
        }
        [TestMethod]
        public void LiasonText()
        {
            GCDriver.FindElement(By.CssSelector(".card.card--well.card--shadow")).Text.Equals("Liaisons\r\nOur liaisons provide technical assistance to Regional Comprehensive Center (RCC) staff so they may better" +
                " assist SEAs in developing and implementing state and local structures, procedures and policies to address student challenges in learning to read and write.\r\nSarah Sayko: Mid-Atlantic, Appalachia," +
                " Texas, and Great Lakes\r\nSheryl Turner: Southeast, Florida and the Islands, and Mid-West\r\nAndrea Reade: Northeast, South Central, and Central\r\nBrian Gearin: Northwest, Pacific, California, West" +
                " and North Central");
        }
        [TestMethod]
        public void LiasonEmailLinks()
        {
            bool flag = false;
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("[href*='mailto']"));
            foreach (IWebElement element in elements)
            {

                bool visable = TestingClass.IsElementVisible(element);
                if (visable == true)
                    flag = true;
                else
                    flag = false;

                Assert.IsTrue(flag);
            }
        }


        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }

        
    }
}
