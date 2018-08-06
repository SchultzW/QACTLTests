using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NCILWebTests
{
    [TestClass]
    public class ImprovingLiteracyBriefs
    {

        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {

            GCDriver = new ChromeDriver();
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/brief");
        }

        [TestMethod]
        public void TestTitle()
        {
            Assert.IsTrue(GCDriver.Title.Equals("Improving Literacy Briefs | National Center on Improving Literacy"));
            Assert.IsTrue(TextCheckMethodCSS("Improving Literacy Briefs", ".page__title"));
            Assert.IsTrue(TextCheckMethodClassName("Read research summaries and infographics written by our experts that simplify complex ideas related to literacy.", "lead"));
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
        public void ByAudicenceFamily()
        {
            GCDriver.FindElement(By.Id("edit-field-audience-tid")).FindElement(By.CssSelector("option[value = '2']")).Click();
            GCDriver.FindElement(By.Id("edit-submit-lit-briefs")).Click();
            try
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Defining Dyslexia")).Displayed);
            }
            catch
            {
              Assert.IsTrue(GCDriver.FindElement(By.LinkText("Advocating for My Child's Literacy Needs")).Displayed);
            }
           
        }
        [TestMethod]
        public void ByAudienceSchool()
        {
            GCDriver.FindElement(By.Id("edit-field-audience-tid")).FindElement(By.CssSelector("option[value = '3']")).Click();
            GCDriver.FindElement(By.Id("edit-submit-lit-briefs")).Click();

            try
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Advocating for My Child's Literacy Needs")).Displayed);
            }
            catch
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Defining Dyslexia")).Displayed);
            }

        }
        [TestMethod]
        public void ByAudienceStateAgencies()
        {
            GCDriver.FindElement(By.Id("edit-field-audience-tid")).FindElement(By.CssSelector("option[value = '4']")).Click();
            GCDriver.FindElement(By.Id("edit-submit-lit-briefs")).Click();

            try
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Advocating for My Child's Literacy Needs")).Displayed);
            }
            catch
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div[2]/div")).Text.Equals("No Briefs Found\r\nTry removing filters to get more results.");
            }

        }
        [TestMethod]
        public void ByTopicAdvocacy()
        {
            GCDriver.FindElement(By.Id("edit-field-topic-tid")).FindElement(By.CssSelector("option[value = '14']")).Click();
            GCDriver.FindElement(By.Id("edit-submit-lit-briefs")).Click();

            try
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Defining Dyslexia")).Displayed);
            }
            catch
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Advocating for My Child’s Literacy Needs")).Displayed);
            }

        }
        [TestMethod]
        public void ByTopicBeginningReading()
        {
            GCDriver.FindElement(By.Id("edit-field-topic-tid")).FindElement(By.CssSelector("option[value = '50']")).Click();
            GCDriver.FindElement(By.Id("edit-submit-lit-briefs")).Click();

            try
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Defining Dyslexia")).Displayed);
            }
            catch
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("How We Learn to Read: The Critical Role of Phonological Awareness ")).Displayed);
            }

        }
        [TestMethod]
        public void ByTopicComprehension()
        {
            GCDriver.FindElement(By.Id("edit-field-topic-tid")).FindElement(By.CssSelector("option[value = '22']")).Click();
            GCDriver.FindElement(By.Id("edit-submit-lit-briefs")).Click();

            try
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Defining Dyslexia")).Displayed);
            }
            catch
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Supporting Your Child’s Literacy Development at Home")).Displayed);
            }

        }
        [TestMethod]
        public void ByTopicDyslexia()
        {
            GCDriver.FindElement(By.Id("edit-field-topic-tid")).FindElement(By.CssSelector("option[value = '15']")).Click();
            GCDriver.FindElement(By.Id("edit-submit-lit-briefs")).Click();

            try
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Supporting Your Child’s Literacy Development at Home")).Displayed);
            }
            catch
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Defining Dyslexia")).Displayed);
            }

        }
        [TestMethod]
        public void ByTopicEvidenceBased()
        {
            GCDriver.FindElement(By.Id("edit-field-topic-tid")).FindElement(By.CssSelector("option[value = '316']")).Click();
            GCDriver.FindElement(By.Id("edit-submit-lit-briefs")).Click();

            try
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Supporting Your Child’s Literacy Development at Home")).Displayed);
            }
            catch
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("What Do We Mean by Evidence-based?")).Displayed);
            }

        }
        [TestMethod]
        public void ByTopicPartnership()
        {
            GCDriver.FindElement(By.Id("edit-field-topic-tid")).FindElement(By.CssSelector("option[value = '51']")).Click();
            GCDriver.FindElement(By.Id("edit-submit-lit-briefs")).Click();

            try
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Supporting Your Child’s Literacy Development at Home")).Displayed);
            }
            catch
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Key Roles for Children’s Literacy Success")).Displayed);
            }

        }
        [TestMethod]
        public void ByVocab()
        {
            GCDriver.FindElement(By.Id("edit-field-topic-tid")).FindElement(By.CssSelector("option[value = '51']")).Click();
            GCDriver.FindElement(By.Id("edit-submit-lit-briefs")).Click();

            try
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Supporting Your Child’s Literacy Development at Home")).Displayed);
            }
            catch
            {
                Assert.IsTrue(GCDriver.FindElement(By.LinkText("Succeeding in School: Essential Features of Literacy Development")).Displayed);
            }

        }
        [TestMethod]
        public void AdvocatingMyChildsNeeds()
        {
            GCDriver.FindElement(By.LinkText("Advocating for My Child’s Literacy Needs")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Advocating for My Child’s Literacy Needs | National Center on Improving Literacy"));

            IsElementPresentLinkText("Download PDF");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[12]/a/img");
            IsElementPresentClassName("margin-bottom");//keep reading
          
        }
        [TestMethod]
        public void KeyRolesForChildrensSuccess()
        {
            GCDriver.FindElement(By.LinkText("Key Roles for Children’s Literacy Success")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Key Roles for Children’s Literacy Success | National Center on Improving Literacy"));
            IsElementPresentCSS("[href *= '/improvingliteracy.org/sites/improvingliteracy1.uoregon.edu/files/briefs/key-roles-for-childrens-reading-success.pdf']");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[12]/a/img");
            IsElementPresentLinkText("Related Resources");
            IsElementPresentClassName("margin-bottom");//keep reading

        }
        [TestMethod]
        public void DefiningDyslexia()
        {
            GCDriver.FindElement(By.LinkText("Defining Dyslexia")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Defining Dyslexia | National Center on Improving Literacy"));
            IsElementPresentCSS("[href *= 'improvingliteracy.org/sites/improvingliteracy1.uoregon.edu/files/briefs/Defining-Dyslexia.pdf']");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[7]/a/img");
            IsElementPresentLinkText("Related Resources");
            


        }
        [TestMethod]
        public void HowWeLearnToRead()
        {
            GCDriver.FindElement(By.LinkText("How We Learn to Read: The Critical Role of Phonological Awareness")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("How We Learn to Read: The Critical Role of Phonological Awareness | National Center on Improving Literacy"));

            IsElementPresentCSS("[href *= '/improvingliteracy.org/sites/improvingliteracy1.uoregon.edu/files/briefs/how-we-learn-to-read-the-critical-role-of-phonological-awareness.pdf']");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[12]/a/img");
            IsElementPresentLinkText("Related Resources");
            IsElementPresentClassName("margin-bottom");//keep reading

        }
        [TestMethod]
        public void LearningAboutYourChildsReadingDevelopment()
        {
            GCDriver.FindElement(By.LinkText("Learning About Your Child’s Reading Development")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Learning About Your Child’s Reading Development | National Center on Improving Literacy"));

            IsElementPresentCSS("[href *= 'improvingliteracy.org/sites/improvingliteracy1.uoregon.edu/files/briefs/learning-about-your-childs-reading-development.pdf']");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[8]/a/img");
            IsElementPresentLinkText("Related Resources");
            IsElementPresentClassName("margin-bottom");//keep reading

        }
        [TestMethod]
        public void LearningToRead()
        {
            GCDriver.FindElement(By.LinkText("Learning to Read: “The Simple View of Reading”")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Learning to Read: “The Simple View of Reading” | National Center on Improving Literacy"));
            IsElementPresentCSS("[href *= '/improvingliteracy.org/sites/improvingliteracy1.uoregon.edu/files/briefs/Learing-to-Read-The-Simple-View-of-Reading.pdf']");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[11]/a/img");
            IsElementPresentLinkText("Related Resources");
            IsElementPresentClassName("margin-bottom");//keep reading


        }
        [TestMethod]
        public void PartneringWithYourChildsSchool()
        {
            GCDriver.FindElement(By.LinkText("Partnering With Your Child’s School")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Partnering With Your Child’s School | National Center on Improving Literacy"));
            IsElementPresentCSS("[href *= '/improvingliteracy.org/sites/improvingliteracy1.uoregon.edu/files/briefs/Partnering-With-Childs-School.pdf']");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[12]/a/img");
            IsElementPresentLinkText("Related Resources");
            IsElementPresentClassName("margin-bottom");//keep reading
           
        }
        [TestMethod]
        public void SucceedingInSchool()
        {
            GCDriver.FindElement(By.LinkText("Succeeding in School: Essential Features of Literacy Development")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Succeeding in School: Essential Features of Literacy Development | National Center on Improving Literacy"));

            IsElementPresentCSS("[href *= '/improvingliteracy.org/sites/improvingliteracy1.uoregon.edu/files/briefs/succeeding-in-schools-essential-features-of-literacy-development.pdf']");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[9]/a/img");
            IsElementPresentLinkText("Related Resources");
            IsElementPresentClassName("margin-bottom");//keep reading

        }
        [TestMethod]
        public void SupportingYourChildsLiteracyDevelopment()
        {
            GCDriver.FindElement(By.LinkText("Supporting Your Child’s Literacy Development at Home")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Supporting Your Child’s Literacy Development at Home | National Center on Improving Literacy"));
            
            IsElementPresentCSS("[href *= '/improvingliteracy.org/sites/improvingliteracy1.uoregon.edu/files/briefs/Supporting-Your-Child-Literacy-Development-at-Home.pdf']");        
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");           
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[9]/a/img");          
            IsElementPresentLinkText("Related Resources");          
            IsElementPresentCSS(".panel.panel-default.panel-horizontal");
            IsElementPresentCSS(".panel-heading");
            IsElementPresentClassName("margin-bottom");//keep reading

        }
        [TestMethod]
        public void TheAlphabeticPrinciple()
        {
            GCDriver.FindElement(By.LinkText("The Alphabetic Principle: From Phonological Awareness to Reading Words")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("The Alphabetic Principle: From Phonological Awareness to Reading Words | National Center on Improving Literacy"));

            IsElementPresentCSS("[href *= '/improvingliteracy.org/sites/improvingliteracy1.uoregon.edu/files/briefs/the-alphabetic-principle.pdf']");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[15]/a/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[16]/a/img");
            IsElementPresentLinkText("Related Resources");
            IsElementPresentClassName("margin-bottom");//keep reading
            IsElementPresentCSS(".panel-heading");

        }
        [TestMethod]
        public void WhatDoWeMeanByEvidenceBased()
        {

            GCDriver.FindElement(By.LinkText("What Do We Mean by Evidence-based?")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("What Do We Mean by Evidence-based? | National Center on Improving Literacy"));
            IsElementPresentCSS("[href *= '/improvingliteracy.org/sites/improvingliteracy1.uoregon.edu/files/briefs/what-do-we-mean-by-evidence-based.pdf']");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[1]/img");
            IsElementPresentXpath("//*[@id='content']/div/div/div[1]/p[4]/a/img");
            IsElementPresentLinkText("Related Resources");

            

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
