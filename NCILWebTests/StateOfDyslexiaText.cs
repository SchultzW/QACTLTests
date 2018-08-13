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
    public class StateOfDyslexiaText
    {
        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {

            GCDriver = new ChromeDriver();
            
            //GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [TestMethod]
        public void AlabamaText()
        {
          GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/alabama");
          Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("In 2015, the Alabama legislature passed a resolution requiring the Alabama Administrative Code to be amended such that it addressed dyslexia education. Amendments were approved in October of 2015. The amendments make provisions for the use of Response to Intervention (RTI), the creation of problem-solving teams at the district level, the screening of students with dyslexia, the definition of dyslexia, dyslexia training for classroom teachers, evidence-based interventions, and dyslexia interventionists."));
          Assert.IsTrue(GCDriver.FindElement(By.LinkText("Alabama Dyslexia Resolution")).Text.Equals("Alabama Dyslexia Resolution"));
         GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("'Alabama law specifies that screening should be conducted using \"screening instruments currently in place for use in public schools.\" The Alabama State Department of Education (ALSDE) suggests that students in grades 1-12 \"who score below district benchmarks on the universal screener (e.g., STAR, ACT Aspire, and Global Scholar) should be further screened for characteristics of dyslexia.\" Similarly, kindergarten students who score below benchmark on the winter or spring benchmark period for the universal screener should be further screened for characteristics of dyslexia. ALSDE does not endorse or support specific screeners. However, ALSDE provides a list of skills that must be screened. These skills are: accuracy of word reading in on-grade level text, spelling skills, phonemic decoding efficiency skills, and sight word reading efficiency skills.'");
         IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("tr"));
            List<string> text = new List<string> {"State Recognized Screeners",
                "AIMSweb","CORE Guided High Frequency Word Survey","Core Phonics Survey","Developmental Spelling Analysis",
                "Diagnostic Spelling Test","DIBELS 6th Edition","DIBELS Next","easyCBM","Lexercise",
                "MASI-R","PALS-K","ReadWorks","San Diego Quick Assessment","Test of Written Spelling-5",
                "TOWRE-2","State Approved Professional Development","Alabama Reading Initiative","Shelton Academic Reading Academy",
                "Possible Interventions","Helping Students with Dyslexia and Dysgraphia Make Connections","Language!","Lexia Reading Core5",
                "Mindplay Virtual Reading Coach","Project Read","Reading Excellent Word Attack and Rate Development Strategies","Spalding Writing Road to Reading",
                "Specialized Program Individualizing Reading Excellence","Take Flight","Verticy-Phonics/Spelling","Wilson Reading System"};
            int i = 0;
            foreach(IWebElement element in elements)
            {
                Assert.IsTrue(element.Text.Equals(text[i]));
                i++;
            }
          Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Alabama does not have pre-service legislation related to dyslexia."));
          Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("According to law, \"... problem-solving teams will analyze screening and progress monitoring data to assist teachers in planning and implementing appropriate instruction and evidence-based interventions for all students with academic and/or behavioral difficulties, including those students who exhibit the characteristics of dyslexia. Guidance may include suggestions of appropriate tiered interventions, dyslexia specific interventions, academic accommodations as appropriate, and access to assistive technology. The dyslexia-specific intervention, as defined in AAC Rule 290-3-1-02(20),(f) and described in the Alabama Dyslexia Resource Guide, shall be provided by an individual who has expertise in providing dyslexia-specific interventions. The PST will notify the parents of the results of the dyslexia-specific screening, will provide parents with a copy of the goals of the dyslexia-specific intervention plan, and with data-based documentation regarding the student's progress on a regular basis. Independent dyslexia evaluations provided by a parent or guardian to the PST must be considered by the members of the PST. Dyslexia-specific intervention shall mean evidenced-based, specialized reading, writing, and, spelling instruction that is multisensory in nature equipping students to simultaneously use multiple senses (vision, hearing, touch, and movement). Dyslexia-specific intervention employs direct instruction of systematic and cumulative content. The sequence must begin with the easiest and most basic elements and progress methodically to more difficult material. Each step must also be based on those already learned. Concepts must be systematically reviewed to strengthen memory. Components of dyslexic-specific intervention include instruction targeting phonological awareness, sound-symbol association, syllable structure, morphology, syntax, and semantics. Dyslexia interventionist refers to the teacher or individual who provides dyslexia-specific intervention. The dyslexia interventionist shall have successfully completed a certification training ...\""));
          
        }
    }
}
