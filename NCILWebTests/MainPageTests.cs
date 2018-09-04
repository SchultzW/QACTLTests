using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NCILWebTests
{
    [TestClass]
    public class MainPageTest
    {
        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {
            //var options = new ChromeOptions();
            //options.AddArgument("headless");
            GCDriver = new ChromeDriver();
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/");
        }

        [TestMethod]
        public void TestTitle()
        {
            //GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/");
           Assert.IsTrue( GCDriver.Title.Equals("National Center on Improving Literacy | Your source for improving outcomes for students with literacy-related disabilities, including dyslexia."));
            System.Diagnostics.Debug.WriteLine("testing the title");

        }
        [TestMethod]
        public void TestTagLineText()
        {
            Console.WriteLine("1 Testing Tagline Text");
            //GCDriver.FindElement(By.ClassName("tagline")).Text.CompareTo("Your source for improving outcomes for students with " +
            //                                                                   "literacy-related disabilities, including dyslexia.");
            Assert.IsTrue(TestingClass.TextCheckMethodClassName("Your source for improving outcomes for students with " +
                                                                                "literacy-related disabilities, including dyslexia.", "tagline",GCDriver));
            Assert.IsTrue(TestingClass.TextCheckMethodXPath("A Path to Success", "//*[@id='start']/div/div[1]/div/h2",GCDriver));
            //GCDriver.FindElement(By.XPath("//*[@id='start']/div/div[1]/div/h2")).Text.CompareTo("A Path to Success");
            Console.WriteLine("1 Testing Tagline Text complete");
        }
        [TestMethod]
        public void TestFlipBoxesText()
        {

            bool flag = false;

            Console.WriteLine("2 flip box caption test start");


            IList<IWebElement> flipBoxes = GCDriver.FindElements(By.ClassName("caption-content"));
            List<string> FlipBoxTrueTextList = new List<string>(3);
            FlipBoxTrueTextList.Insert(0, "Help your child learn to read and write with practical ideas and expert-approved strategies.");
            FlipBoxTrueTextList.Insert(1, "Find evidence-based professional development and effective approaches to screen, identify, and teach students with literacy-related difficulties, including dyslexia.");
            FlipBoxTrueTextList.Insert(2, "Develop and implement state and local structures, procedures and policies to address student challenges in learning to read and write.");

            for (int i = 0; i < flipBoxes.Count - 1; i++)
            {
                if (flipBoxes[i].Text.Contains(FlipBoxTrueTextList[i]))
                    flag = true;
                else
                    flag = false;
                Assert.IsTrue(flag);

            }
            Console.WriteLine("2 flip box caption test COMPLETE");

        }
        [TestMethod]
        public void FlipBoxFrontTextTest()
        {
            Console.WriteLine("3 Flipbox Front text test starting");
            bool flag = false;
            IList<IWebElement> flipBoxFront = GCDriver.FindElements(By.ClassName("front"));
            List<string> FrontTextTrue = new List<string>(3);

            FrontTextTrue.Insert(0, "For Parents & Families");
            FrontTextTrue.Insert(1, "For Schools & Districts");
            FrontTextTrue.Insert(2, "For State Agencies");
            for (int i = 1, j = 0; i < FrontTextTrue.Count - 1; i++, j++)
            {
                if (flipBoxFront[i].Text.Contains(FrontTextTrue[j]))
                    flag = true;
                else
                    flag = false;
                Assert.IsTrue(flag);
            }
            Console.WriteLine("3 Flipbox Front text test starting COMPLETE");
        }
        [TestMethod]
        public void KidZoneBoxTest()
        {
            Console.WriteLine("4 KidZone Box Test");
            GCDriver.FindElement(By.CssSelector(".lead.margin-bottom")).Text.CompareTo(" The Literacy Playground for Kids & Families!");
            Assert.IsTrue(TestingClass.TextCheckMethodClassName("LISTEN", "lime-text",GCDriver));
            Assert.IsTrue(TestingClass.TextCheckMethodClassName("READ", "pink-text",GCDriver));
            Assert.IsTrue(TestingClass.TextCheckMethodClassName("PLAY", "light-teal-text",GCDriver));
            Console.WriteLine("4 KidZone Box Test COMPLETE");



        }


        [TestMethod]
        public void TestToolsAndEventsText()
        {
            Console.WriteLine("5 Tools and Events Title test");
            IList<IWebElement> toolsEventsBoxeTitles = GCDriver.FindElements(By.ClassName("teal-text"));
            List<string> toolsAndEventsTrueTitle = new List<string>();
            toolsAndEventsTrueTitle.Add("Tools & Events");
            toolsAndEventsTrueTitle.Add("Resource Repository");
            toolsAndEventsTrueTitle.Add("Improving Literacy Briefs");
            toolsAndEventsTrueTitle.Add("State of Dyslexia");
            toolsAndEventsTrueTitle.Add("Ask an Expert");
            toolsAndEventsTrueTitle.Add("Learning Literacy Glossary");
            toolsAndEventsTrueTitle.Add("Events & Opportunities");
            bool flag = false;
            for (int i = 0; i < toolsEventsBoxeTitles.Count - 1; i++)
            {
                if (toolsEventsBoxeTitles[i].Text.Equals(toolsAndEventsTrueTitle[i]))
                    flag = true;
                else
                    flag = false;
                Assert.IsTrue(flag);

            }
            Console.WriteLine("5 Tools and Events Title test COMPLETE");


        }
        [TestMethod]
        public void ToolsAndEventsTextTest()
        {
            Console.WriteLine("6 Tools and Events Text test");
            bool flag = false;
            IList<IWebElement> toolsAndEventsText = GCDriver.FindElements(By.CssSelector(".lead.flex-text"));
            List<string> toolsandEventsTrueText = new List<string>();
            toolsandEventsTrueText.Add("Recommended websites, downloads, and videos from reliable sources.");
            toolsandEventsTrueText.Add("Research summaries and infographics written by our experts.");
            toolsandEventsTrueText.Add("Dyslexia legislation and related initiatives in the U.S.A.");
            toolsandEventsTrueText.Add("Our experts answer your literacy-related questions.");
            toolsandEventsTrueText.Add("Expand your knowledge of key literacy terms with definitions and interactive resources.");
            toolsandEventsTrueText.Add("Upcoming regional professional development, workshops, and conferences.");
            //this is the footer at the bottom of the page but has the same css locator, may as well test it now with these others
            toolsandEventsTrueText.Add("The National Center on Improving Literacy is a partnership among literacy experts, university researchers, " +
                                                     "and technical assistance providers, with  from the United States Department of Education.  ");

            for (int i = 0; i < toolsAndEventsText.Count - 1; i++)
            {
                if (toolsAndEventsText[i].Text.Equals(toolsandEventsTrueText[i]))
                    flag = true;
                else
                    flag = false;
                Assert.IsTrue(flag);

            }
            Console.WriteLine("6 Tools and Events Test Text COMPLETE");
        }
        [TestMethod]
        public void TestFooterText()
        {
            
            Console.WriteLine("7 Footer text test");
           Assert.IsTrue(TestingClass.TextCheckMethodCSS("Contact Us\r\nEmail Us\r\nFollow us on Facebook\r\nFollow us on Twitter\r\nSubscribe to our YouTube Feed\r\nShare\r\nShare on Facebook\r\n  Share on Twitter", ".footer-col.col-md-4",GCDriver));
            
            Assert.IsTrue(TestingClass.TextCheckMethodCSS("Stay Informed!\r\nEmail *", ".block-constant-contact.first.last.odd",GCDriver));

            Assert.IsTrue(TestingClass.TextCheckMethodClassName("The research reported here is funded by awards to the National Center on Improving Literacy from the Office of Elementary " +
                "and Secondary Education, in partnership with the Office of Special Education Programs (Award #: S283D160003). The opinions expressed are those of the authors" +
                " and do not represent views of OESE, OSEP, or the U.S. Department of Education.", "margin-top",GCDriver));
           
           Assert.IsTrue(TestingClass.TextCheckMethodClassName("Copyright © 2018 National Center on Improving Literacy  Terms and Conditions | Privacy Policy | Accessibility", "footer-below",GCDriver));
            

            Console.WriteLine("7 footer text test COMPLETE");
        }
 
        [TestMethod]
        public void  KidZoneLink()
        {

            GCDriver.FindElement(By.CssSelector("[href*='/kid-zone']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Kid Zone! | Kid Zone! National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".kid-theme.page__title")).Text.Equals("KID ZONE!"));
            //By.CssSelector("[href*='Vacancies.aspx?param=apply:16']")
        }
        [TestMethod]
        public void ResourceRepo()
        {
            //GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElement(By.LinkText("Find Resources")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Resource Repository | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("Resource Repository"));
        }
        [TestMethod]
        public void ImprovingLitBriefs()
        {
            GCDriver.FindElement(By.LinkText("Read Briefs")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Improving Literacy Briefs | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("Improving Literacy Briefs"));
        }
        [TestMethod]
        public void SateOfDyslexia()
        {
            GCDriver.FindElement(By.LinkText("Explore the Map")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("State of Dyslexia | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("State of Dyslexia"));
        }
        [TestMethod]
        public void AskAnExpert()
        {
            GCDriver.FindElement(By.LinkText("Ask Us")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Ask an Expert | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("Ask an Expert"));
        }
        [TestMethod]
        public void LearningLitGlossary()
        {
            GCDriver.FindElement(By.LinkText("Browse Terms")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Learning Literacy Glossary | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("Learning Literacy Glossary"));
        }
        [TestMethod]
        public void EventsAndOpportunites()
        {
            GCDriver.FindElement(By.LinkText("View Events")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Events & Opportunites | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("Events & Opportunites"));
        }
        [TestMethod]
        public void AboutUs()
        {
            GCDriver.FindElement(By.LinkText("Learn More About Us")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("About Us | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("About Us"));
        }
        [TestMethod]
        public void ContactUs()
        {
            GCDriver.FindElement(By.LinkText("Email Us")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Contact | National Center on Improving Literacy"));
            //Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("Contact | National Center on Improving Literacy"));
            GCDriver.FindElement(By.Id("page-title")).Text.Equals("Contact");
           

        }
        [TestMethod]
        public void Facebook()
        {
            GCDriver.FindElement(By.LinkText("Follow us on Facebook")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("National Center on Improving Literacy - Home | Facebook"));
            //Assert.IsTrue(GCDriver.FindElement(By.Id("seo_h1_tag")).Text.Equals("National Center on Improving Literacy"));
        }
        [TestMethod]
        public void Twitter()
        {
            GCDriver.FindElement(By.LinkText("Follow us on Twitter")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Improving Literacy (@NCILiteracy) | Twitter"));
            // Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".page__title")).Text.Equals("Contact | National Center on Improving Literacy"));
        }
        [TestMethod]
        public void Youtube()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElement(By.LinkText("Subscribe to our YouTube Feed")).Click();
            //Assert.IsTrue(GCDriver.Title.Equals("Improving Literacy (@NCILiteracy) | Twitter"));
             Assert.IsTrue(GCDriver.FindElement(By.Id("channel-title")).Text.Equals("National Center on Improving Literacy"));
        }


    
        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }

    }
}

