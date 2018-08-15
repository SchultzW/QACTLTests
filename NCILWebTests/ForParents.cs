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
            var options = new ChromeOptions();
            options.AddArgument("headless");
            GCDriver = new ChromeDriver(options);
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
            Assert.IsTrue(GCDriver.FindElement(By.ClassName("col-sm-8")).Text.Equals("You are here\r\nHome\r\nParents & Families\r\nHelp your child learn to read and write with practical ideas and expert-approved strategies."));
            
            //header description
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".block.block-block.first.last.odd")).Text.Equals("Help your child learn to read and write with practical ideas and expert-approved strategies."));
            
            TestingClass.IsElementPresentCSS(".container.header-icon", GCDriver);

   
        }
        [TestMethod]
        public void WhatsNewAndFeaturedBrief()
        {
            //tests the literary brieg text
            

            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".panel-pane.pane-custom.pane-7")).Text.Equals("What's New"));
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
        public void PhonicAwareness()
        {
            
            Assert.IsTrue(GCDriver.FindElement(By.LinkText("Phonemic Awareness")).Text.Equals("Phonemic Awareness"));
            // Assert.IsTrue(TextCheckMethodXPath("Definition", "fa fa-info-circle"));
            // Assert.IsTrue(TextCheckMethodCSS(" Learn More", ".fa.fa-graduation-cap"));
            
            Assert.IsTrue(GCDriver.FindElement(By.ClassName("more-link")).Text.Equals("More Glossary Terms"));
            TestingClass.IsElementPresentCSS(".fa.fa-graduation-cap", GCDriver);
           
            TestingClass.IsElementPresentCSS(".fa.fa-info-circle", GCDriver);
           
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
            foreach(IWebElement element in elements)
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
        public void KidZone()
        {
            TestingClass.IsElementPresentCSS(".panel-pane.pane-custom.pane-8.margin-bottom",GCDriver);
           
            GCDriver.FindElement(By.XPath("//*[@id='content']/div/div[1]/div[2]/div[1]/div/div/div/div/a")).Click();
            //Assert.IsTrue(GCDriver.Title.Equals("Kid Zone! | Kid Zone! | National Center on Improving Literacy"));
           Assert.IsTrue(GCDriver.Title.Equals("Kid Zone! | Kid Zone! National Center on Improving Literacy"));
        }


        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }

     

    }
}
