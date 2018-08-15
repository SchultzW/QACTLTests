using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NCILWebTests
{
    
    [TestClass]
    public class KidZonePlayTest
    {
        static IWebDriver GCDriver;
        List<string> gameTitle = new List<string>()
        { "Daniel Tiger Books","Electric Company Half Pipe Hoverball", "Electric Company Jessica's Joyride","Electric Company Jungle Jumble",
        "Electric Company Scrapyard Slice", "Martha Speaks True Stories", "Martha Speaks Word Spinner", "Match Letters", "Princess Presto's Spectacular Spelling Play",
            "Rhyme Time", "Sesame Street Abby's Sandbox Search", "Sesame Street Story Book Builder", "Sesame Street: Grover's Rhyme Time Train",
        "Super Why ABC Adventures: Alphabet", "Super Why Phonics Fair", "Super Why Saves the Day", "Super Why! Power to Read", "Word Girl Superhero Training"};

       
        

        [TestInitialize]
        public void SetUpDrivers()
        {
            var options = new ChromeOptions();
            options.AddArgument("headless");
            GCDriver = new ChromeDriver(options);
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/kid-zone/play");
        }
        [TestMethod]
        public void TitleTest()
        {
            Assert.IsTrue(GCDriver.Title.Equals("Explore Games to Play | Kid Zone ! National Center on Improving Literacy"));
        }
        [TestMethod]
        public void DanielTigerBooks()
        {
            int Count = 0;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count]+" | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3",GCDriver);
         
            GCDriver.FindElement(By.LinkText("Download App")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count]+" | National Center on Improving Literacy"));
            

        }
        [TestMethod]
        public void HalfpipeHoverball()
        {
            int Count = 1;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count]+" | National Center on Improving Literacy"));

            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count]+" | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void JessicasJoyride()
        {
            int Count = 2;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            Count++;
        }
        [TestMethod]
        public void JungleJumble()
        {
            int Count = 3;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void ScrapyardSlice()
        {
            int Count = 4;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void MarthaSpeaks()
        {
            int Count = 5;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            Count++;
        }
        [TestMethod]
        public void MarthaSpeaksWordSpiiner()
        {
            int Count = 6;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            Count++;
        }
        [TestMethod]
        public void MatchLetters()
        {
            int Count = 7;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void PrincessPresto()
        {
            int Count = 8;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void RhymeTime()
        {
            int Count = 9;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void AbbysSandboxSearch()
        {
            int Count = 10;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void StoryBookBuilder()
        {
            int Count = 11;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void SesameStRhymeTime()
        {
            int Count = 12;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void SuperWhyAdventures()
        {
            int Count = 13;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void SuperWhyPhonicsFair()
        {
            int Count = 14;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void SuperWhySavesTheDay()
        {
            int Count = 15;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            
        }
        [TestMethod]
        public void SuperWhyPowerToRead()
        {
            int Count = 16;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            Count++;
        }
        [TestMethod]
        public void WordGirlSuperHeroTrainign()
        {
            int Count = 17;
            GCDriver.FindElement(By.LinkText(gameTitle[Count])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            TestingClass.IsElementPresentCSS(".col-sm-3", GCDriver);
            
            GCDriver.FindElement(By.CssSelector(".btn.btn-action.btn-go")).Click();
            Assert.IsTrue(GCDriver.Title.Equals(gameTitle[Count] + " | National Center on Improving Literacy"));
            Count++;
        }

        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }
    }
}
