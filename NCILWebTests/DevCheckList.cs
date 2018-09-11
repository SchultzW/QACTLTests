using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using OpenQA.Selenium.Support.UI;

namespace NCILWebTests
{
    [TestClass]
    public class DevCheckList
    {

        static IWebDriver GCDriver;
        [TestInitialize]
        public void TestMethod1()
        {
            GCDriver = new ChromeDriver();
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            GCDriver.Navigate().GoToUrl("https://improvingliteracy2.uoregon.edu/checklist");
        }
        [TestMethod]
        public void AreBtnPresent()
        {
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div/router-view/router-view/div/div/persona-selection/div/button[1]",GCDriver);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div/router-view/router-view/div/div/persona-selection/div/button[2]", GCDriver);

        }
        [TestMethod]
        public void MainPageCheck()
        {
            System.Threading.Thread.Sleep(6000);
            Assert.IsTrue(GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Text.Equals("I'm a Caregiver"));      
            Assert.IsTrue(GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[1].Text.Equals("I'm a Practitioner"));
            GCDriver.FindElement(By.XPath("//*[@id='page-top']/header/div/div/div/nav")).Text.Equals("Home");
            GCDriver.FindElement(By.XPath("//*[@id='page-top']/header/div/div/div/div")).Text.Equals("Answer questions to help assess your student's literacy level. Get recommendations to help your student succeed!");
            TestingClass.IsElementPresentXpath("//*[@id='page-top']/header/div/div", GCDriver);
        }
        [TestMethod]
        public void BtnClick()
        {
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            //GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/router-view/router-view/div/div/persona-selection/div/button[1]")).Click();
            Assert.IsTrue(GCDriver.Url.Equals("https://improvingliteracy2.uoregon.edu/checklist#/personas/caregiver"));
            GCDriver.Navigate().GoToUrl("https://improvingliteracy2.uoregon.edu/checklist");
            //System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[1].Click();
            //GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/router-view/router-view/div/div/persona-selection/div/button[2]")).Click();
            Assert.IsTrue(GCDriver.Url.Equals("https://improvingliteracy2.uoregon.edu/checklist#/personas/practitioner"));
        }
        [TestMethod]
        public void CaregiverBtnTextCheck()
        {
            //this test checks the text on the caregiverpage
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            Assert.IsTrue(GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Text.Equals("K1"));
            Assert.IsTrue(GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[1].Text.Equals("4th"));
            Assert.IsTrue(GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[2].Text.Equals("8th"));
            Assert.IsTrue(GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[3].Text.Equals("10th"));

        }
        [TestMethod]
        public void K1CaregiverPagecheck()
        {
            //this test checks the text and btns on the k1 caregiverpage
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            System.Threading.Thread.Sleep(600);
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".btn.btn-primary.btn-lg")).Text.Equals("Get Recommendations"));
            System.Threading.Thread.Sleep(600);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/router-view/router-view/router-view/router-view/div/div[1]/div/h2")).Text.Equals("Answer Questions"));
            System.Threading.Thread.Sleep(600);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/router-view/router-view/router-view/router-view/div/div[2]/p")).Text.Equals("Picked the wrong user or grade? Start Over."));

        }
        [TestMethod]
        public void K1CaregiverClickChecks()
        {
            //this test checks that the links on the caregiverk1 page go to the right page
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            //GCDriver.FindElement(By.CssSelector(".btn.btn-primary.btn-lg")).Click();
            //Assert.IsTrue(GCDriver.Url.Equals("https://improvingliteracy2.uoregon.edu/checklist#/personas/caregiver/K1/resources"));
            //Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/router-view/router-view/router-view/router-view/router-view/div[1]/div/div/h2")).Text.Equals("Your student is doing great!"));
            GCDriver.FindElement(By.LinkText("Start Over")).Click();
            Assert.IsTrue(GCDriver.Url.Equals("https://improvingliteracy2.uoregon.edu/checklist#/personas"));
            GCDriver.FindElement(By.ClassName("au-animate")).Text.Equals("Tell us who you are so we can get started.\r\nI'm a Caregiver\r\nI'm a Practitioner");
            GCDriver.Navigate().GoToUrl("https://improvingliteracy2.uoregon.edu/checklist#/personas/caregiver/K1");
            GCDriver.FindElement(By.LinkText("Start Over")).Click();
            Assert.IsTrue(GCDriver.Url.Equals("https://improvingliteracy2.uoregon.edu/checklist#/personas"));
            Assert.IsTrue(GCDriver.FindElement(By.ClassName("au-animate")).Text.Equals("Tell us who you are so we can get started.\r\nI'm a Caregiver\r\nI'm a Practitioner"));


        }
        [TestMethod]
        public void K1CaregiverQuestions()
        {
            //checks if questions are present on the k1CaregiverPage
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            Assert.IsTrue(GCDriver.Url.Equals("https://improvingliteracy2.uoregon.edu/checklist#/personas/caregiver/K1"));
            TestingClass.IsElementPresentCSS(".text-primary.mr-2.align-middle.au-target.fa.fa-book", GCDriver);
            TestingClass.IsElementPresentCSS(".text-primary.mr-2.align-middle.au-target.fa.fa-language", GCDriver);
            GCDriver.FindElements(By.ClassName("au-target"))[8].Click();
            bool btn = GCDriver.FindElements(By.ClassName("au-target"))[9].Selected;
            Assert.IsTrue(btn);
                 


        }
        [TestMethod]
        public void TestK1CareTakerRecomend()
        {
            //tests for the recomentdations from k1 caretaker. all radio btns set to "i dont know"
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            Assert.IsTrue(GCDriver.Url.Equals("https://improvingliteracy2.uoregon.edu/checklist#/personas/caregiver/K1"));
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.ClassName("au-target"))[12].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.ClassName("au-target"))[20].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.ClassName("au-target"))[26].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.ClassName("au-target"))[36].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElement(By.CssSelector(".btn.btn-primary.btn-lg")).Click();
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div/router-view/router-view/router-view/router-view/router-view/div[1]/div/div/resources-by-category/form/div/div[1]", GCDriver);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div/router-view/router-view/router-view/router-view/router-view/div[1]/div/div/resources-by-category/form/div/div[2]", GCDriver);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div/router-view/router-view/router-view/router-view/router-view/div[1]/div/div/resources-by-category/form/div/div[3]", GCDriver);


        }
        //here below for xbrowser
        [TestMethod]
        public void CaregiverYesAllTest()
        {
            //test chooses all yes for caregiver. should give message saying your student is good.
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.ClassName("au-target"))[9].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.ClassName("au-target"))[16].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.ClassName("au-target"))[23].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.ClassName("au-target"))[32].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElement(By.CssSelector(".btn.btn-primary.btn-lg")).Click();
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/router-view/router-view/router-view/router-view/router-view/div[1]/div/div/h2")).Text.Equals("Your student is doing great!"));

        }
        [TestMethod]
        public void StartOverTest()
        {
            GCDriver.Manage().Window.Maximize();
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/router-view/router-view/router-view/router-view/div/div[2]/p/a")).Click();
            System.Threading.Thread.Sleep(600);
            Assert.IsTrue(GCDriver.Url.Equals("https://improvingliteracy2.uoregon.edu/checklist#/personas"));
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            System.Threading.Thread.Sleep(600);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div/router-view/router-view/router-view/router-view/div/div[1]/div/questions/form/div[1]/question/div[1]/div/h2", GCDriver);

        }
        [TestMethod]
        public void NoChoices()
        {
            //test that chooses no radio buttons and clicks to show results. should stay on the same page. the page has a small pop up but i dont think i can test it.
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            GCDriver.FindElement(By.CssSelector(".btn.btn-primary.btn-lg")).Click();
            Assert.IsTrue(GCDriver.Url.Equals("https://improvingliteracy2.uoregon.edu/checklist#/personas/caregiver/K1"));
        }
        [TestMethod]
        public void OneChoice()
        {
            //only chooses one radio button and clicks results
            GCDriver.Manage().Window.Maximize();
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            GCDriver.FindElements(By.CssSelector(".btn.btn-primary.btn-lg.au-target"))[0].Click();
            System.Threading.Thread.Sleep(600);
            GCDriver.FindElements(By.ClassName("au-target"))[9].Click();
            GCDriver.FindElement(By.CssSelector(".btn.btn-primary.btn-lg")).Click();
            Assert.IsTrue(GCDriver.Url.Equals("https://improvingliteracy2.uoregon.edu/checklist#/personas/caregiver/K1"));

        }

        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }

    }
}
