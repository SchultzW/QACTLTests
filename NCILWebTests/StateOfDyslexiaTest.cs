using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.Generic;

namespace NCILWebTests
{
    [TestClass]
    public class StateOfDyslecixTest
    {
        static IWebDriver GCDriver;
        #region
        string[,] StateDyslexiaLegArray = new string[,]
                                        {{"https://improvingliteracy.org/state-of-dyslexia/alabama","Yes", "Yes" ,"No", "Yes" ,"Yes","No"},
                                        {"https://improvingliteracy.org/state-of-dyslexia/alaska","No","No","No","No","No","No" },
                                        {"https://improvingliteracy.org/state-of-dyslexia/florida","Yes","Yes","Yes","Yes","Yes","No" },
                                        { "https://improvingliteracy.org/state-of-dyslexia/kentucky","Yes","No","No","No","No","No"},
                                        {"https://improvingliteracy.org/state-of-dyslexia/maine","Yes","Yes","No","Yes","No","No"},
                                         {"https://improvingliteracy.org/state-of-dyslexia/maryland","yes", "no", "no", "no", "no","no" },
                                        {"https://improvingliteracy.org/state-of-dyslexia/massachusetts","No","No","No","No","No","No" },
                                        {"https://improvingliteracy.org/state-of-dyslexia/minnesota","yes" ,"yes","no","yes","yes","no" },
                                        {"https://improvingliteracy.org/state-of-dyslexia/montana","no","no","no","no","no","no" },
                                        {"https://improvingliteracy.org/state-of-dyslexia/new-hampshire","yes","yes", "yes", "yes","yes","no" },
                                        { "https://improvingliteracy.org/state-of-dyslexia/new-jersey","yes","yes","no","yes","yes","no"},

                                        {"https://improvingliteracy.org/state-of-dyslexia/north-carolina", "yes", "no", "no", "yes", "no", "no"},
                                        {"https://improvingliteracy.org/state-of-dyslexia/north-dakota","no","no","no","no","no","no" },
                                        {"https://improvingliteracy.org/state-of-dyslexia/pennsylvania","yes","no","no","no","no","no" },
                                        {"https://improvingliteracy.org/state-of-dyslexia/puerto-rico","no","no","no","no","no","no" },
                                        {"https://improvingliteracy.org/state-of-dyslexia/rhode-island","yes","yes","no","no","yes","no" },
                                        {"https://improvingliteracy.org/state-of-dyslexia/utah","yes","no","no","no","no","no" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/vermont","yes","no","no","no","no","no"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/virginia","yes","yes","yes","yes","yes","no" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/west-virginia","yes","yes","no","no","no","no" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/arizona","yes","yes","no","yes","yes","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/arkansas","yes","yes","yes","yes","yes","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/california","yes","no","no","no","no","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/colorado","yes","no","no","no","yes","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/connecticut", "yes","no","yes","yes","no","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/delaware", "yes","no","no","no","no","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/georgia","yes","no","no","no","no","no" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/hawaii","no","no","no","no","no","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/idaho", "no","no","no","no","no","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/illinois","yes","yes","yes","yes","no","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/indiana", "yes","no","yes","no","no","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/iowa","yes","no","yes","no","no","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/kansas", "no","no","no","no","no","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/louisiana","yes","yes","no","yes","yes","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/michigan","no","no","no","no","no","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/mississippi" ,"yes","yes","no","no","no","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/missouri", "yes","yes","no","yes","no","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/nebraska","yes","no","no","no","no","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/nevada","yes","yes","no","yes","yes","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/new-mexico","yes","no","no","yes","yes","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/new-york","yes","no","no","no","no","yes" },
                                            { "https://improvingliteracy.org/state-of-dyslexia/ohio","yes","no","no","no","no","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/oklahoma", "yes","no","no","no","no","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/oregon","yes","yes","yes","yes","no","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/south-carolina", "yes","no","no","yes","no","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/south-dakota","no","no","no","no","no","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/tennessee","yes","yes","no","no","yes","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/texas", "yes","yes","yes","yes","yes","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/washington", "yes","yes","no","no","yes","yes"},
                                            {"https://improvingliteracy.org/state-of-dyslexia/wisconsin","no","no","no","no","no","yes" },
                                            {"https://improvingliteracy.org/state-of-dyslexia/wyoming","yes","yes","no","no","no","yes" }};
        #endregion


        [TestInitialize]
        public void SetUpDriver()
        {
            GCDriver = new ChromeDriver();
        }
        //[TestMethod]
        //public void TestStateSummaryBox()
        //{
        //    GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        //    int count = StateDyslexiaLegArray.GetLength(0)-1;

        //    for (int i = 0; i <= count; i++)
        //    {
        //        GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);

        //        Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);




        //        Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
        //        int j = 1;

        //        string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
        //        AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
        //        j++;

        //        string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
        //        AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
        //        j++;

        //        string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
        //        AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
        //        j++;

        //        string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
        //        AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
        //        j++;

        //        string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
        //        AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
        //        j++;

        //        string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
        //        AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
        //        j++;

        //    }
        //}
        [TestMethod]
        public void TestAlabama()
        {
            int i = 0;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);

            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
            Assert.AreEqual("Alabama", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestAlaska()
        {
            int i = 1;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);

            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
            Assert.AreEqual("Alaska", GCDriver.FindElement(By.Id("page-title")).Text);

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestFlorida()
        {
            int i = 2;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
            Assert.AreEqual("Florida", GCDriver.FindElement(By.Id("page-title")).Text);

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestKentucky()
        {
            int i = 3;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
            Assert.AreEqual("Kentucky", GCDriver.FindElement(By.Id("page-title")).Text);

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestMaine()
        {
            int i = 4;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
            Assert.AreEqual("Maine", GCDriver.FindElement(By.Id("page-title")).Text);

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestMaryland()
        {
            int i = 5;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
            Assert.AreEqual("Maryland", GCDriver.FindElement(By.Id("page-title")).Text);
            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestMass()
        {
            int i = 6;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
            Assert.AreEqual("Massachusetts", GCDriver.FindElement(By.Id("page-title")).Text);

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestMinnesota()
        {
            int i = 7;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Minnesota", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestMontana()
        {
            int i = 8;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Montana", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestNewHampshire()
        {
            int i = 9;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }
            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("New Hampshire", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestNewJersey()
        {
            int i = 10;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("New Jersey", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestNorthCarolina()
        {
            int i = 11;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("North Carolina", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestNorthDakota()
        {
            int i = 12;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("North Dakota", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestPenn()
        {
            int i = 13;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Pennsylvania", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestPuertoRico()
        {
            int i = 14;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);

            Assert.AreEqual("Puerto Rico", GCDriver.FindElement(By.Id("page-title")).Text);
            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestRhodeIsland()
        {
            int i = 15;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Rhode Island", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestUtah()
        {
            int i = 16;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Utah", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestVermont()
        {
            int i = 17;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Vermont", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestVirginia()
        {
            int i = 18;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Virginia", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestWestVirginia()
        {
            int i = 19;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("West Virginia", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestArizona()
        {
            int i = 20;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Arizona", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestArkansas()
        {
            int i = 21;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Arkansas", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestCalifornia()
        {
            int i = 22;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("California", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestColorado()
        {
            int i = 23;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Colorado", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestConnecticut()
        {
            int i = 24;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Connecticut", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestDelaware()
        {
            int i = 25;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Delaware", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestGeorgia()
        {
            int i = 26;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Georgia", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestHawaii()
        {
            int i = 27;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Hawaii", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestIdaho()
        {
            int i = 28;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Idaho", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestIllinois()
        {
            int i = 29;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Illinois", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestIndiana()
        {
            int i = 30;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Indiana", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestIowa()
        {
            int i = 31;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Iowa", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestKansas()
        {
            int i = 32;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Kansas", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestLouisiana()
        {
            int i = 33;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Louisiana", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestMichigan()
        {
            int i = 34;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Michigan", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestMississippi()
        {
            int i = 35;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Mississippi", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestMissouri()
        {
            int i = 36;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Missouri", GCDriver.FindElement(By.Id("page-title")).Text);
            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestNebraska()
        {
            int i = 37;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Nebraska", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestNevada()
        {
            int i = 38;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Nevada", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestNewMexico()
        {
            int i = 39;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("New Mexico", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestNewYork()
        {
            int i = 40;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("New York", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestOhio()
        {
            int i = 41;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Ohio", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestOklahoma()
        {
            int i = 42;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Oklahoma", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestOregon()
        {
            int i = 43;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Oregon", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestSouthCarolina()
        {
            int i = 44;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("South Carolina", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestSouthDakota()
        {
            int i = 45;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("South Dakota", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestTennessee()
        {
            int i = 46;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Tennessee", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestTexas()
        {
            int i = 47;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Texas", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestWashington()
        {
            int i = 48;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Washington", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestWisconsin()
        {
            int i = 49;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);

            Assert.AreEqual("Wisconsin", GCDriver.FindElement(By.Id("page-title")).Text);
            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }
        [TestMethod]
        public void TestWyoming()
        {
            int i = 50;

            GCDriver.Navigate().GoToUrl(StateDyslexiaLegArray[i, 0]);
            try
            {
                GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img"));
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.IsTrue(false);
            }

            Assert.AreEqual("Summary", GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[2]/div[1]/div/span[1]")).Text);
            Assert.AreEqual("Wyoming", GCDriver.FindElement(By.Id("page-title")).Text);

            Console.WriteLine("Starting test for" + StateDyslexiaLegArray[i, 0]);
            int j = 1;

            string hasLegislation = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[2]")).Text;
            AreTheSame(hasLegislation, StateDyslexiaLegArray[i, j]);
            j++;

            string hasScreening = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[4]")).Text;
            AreTheSame(hasScreening, StateDyslexiaLegArray[i, j]);
            j++;

            string hasPreService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[6]")).Text;
            AreTheSame(hasPreService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasInService = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[8]")).Text;
            AreTheSame(hasInService, StateDyslexiaLegArray[i, j]);
            j++;

            string hasIntervention = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[10]")).Text;
            AreTheSame(hasIntervention, StateDyslexiaLegArray[i, j]);
            j++;

            string hasSIMR = GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/span[11]/p/span[2]")).Text;
            AreTheSame(hasSIMR, StateDyslexiaLegArray[i, j]);
            j++;
        }

        public void AreTheSame(string fromSite, string fromArray)
        {
            bool flag = true;
            char letter = fromArray[0];

            letter = char.ToUpper(letter);
            string firstLetter = letter.ToString();
            fromArray = fromArray.Remove(0, 1);
            fromArray = fromArray.Insert(0, firstLetter);
            if (fromSite == fromArray)
                flag = true;
            else
                flag = false;
            Assert.IsTrue(flag);

        }
        [TestCleanup]
        public void CleanUp()
        {
            GCDriver.Quit();
        }
    }
}

