using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.UI;

namespace NCILWebTests
{
    [TestClass]
    public class ResourceRepository
    {
        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {

            GCDriver = new ChromeDriver();
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/resource-repository");
        }
        [TestMethod]
        public void TestTitle()
        {
          Assert.IsTrue(GCDriver.Title.Equals("Resource Repository | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.Id("block-block-7")).Text.Equals("Find recommended websites, downloads, and videos from reliable sources."));

        }
        [TestMethod]
        public void TestSearch()
        {
            GCDriver.FindElement(By.Id("edit-keys")).SendKeys("Bringing Literacy Strategies into Content Instruction");
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();
            GCDriver.FindElement(By.LinkText("Bringing Literacy Strategies into Content Instruction"));
            
        }
        [TestMethod]
        public void TestSearchInvalid()
        {
            //testing search function with invalid data
            GCDriver.FindElement(By.Id("edit-keys")).SendKeys("cat");
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();
            bool flag = true;
            try
            {
               if( GCDriver.FindElement(By.LinkText("cat")).Displayed)
                flag = true;
            }
            catch
            {
                flag = false;
            }
                
            Assert.IsFalse(flag);
            Assert.IsTrue(GCDriver.FindElement(By.ClassName("view-empty")).Text.Equals("No Resources Found\r\nTry removing filters to get more results."));

            
        }
        [TestMethod]
        public void FilterByAudiance()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElement(By.Id("edit-field-audience-tid-2")).Click();//parents and fam
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("10 Key Reading Practices for All Middle and High Schools"));
            GCDriver.FindElement(By.Id("edit-field-audience-tid-2")).Click();//parents and fam unclicked
            GCDriver.FindElement(By.Id("edit-field-audience-tid-3")).Click();//Schools click
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("A Classroom Scenario"));
            GCDriver.FindElement(By.Id("edit-field-audience-tid-3")).Click();//Schools unclick
            GCDriver.FindElement(By.Id("edit-field-audience-tid-4")).Click();//state agencies click
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.PartialLinkText("Academic Literacy Instruction for Adolescents: A Guidance Document from the Center on Instruction"));


        }
        [TestMethod]
        public void ByTopicAdvocacy()
        {

            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            GCDriver.FindElement(By.Id("edit-field-topic-tid-14")).Click();//advocacy click
            GCDriver.FindElement(By.ClassName("form-submit")).Click();//submit button
            GCDriver.FindElement(By.LinkText("3 Questions to Ask Before Downloading Apps for Kids"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
        }
        [TestMethod]
        public void ByTopicAssessments()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            GCDriver.FindElement(By.Id("edit-field-topic-tid-41")).Click();//assessments click
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("A Comprehensive K-3 Reading Assessment Plan: Guidance for School Leaders"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
        }
        [TestMethod]
        public void ByTopicBeginningReading()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            GCDriver.FindElement(By.Id("edit-field-topic-tid-50")).Click();//beginning reading click
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("A Child Becomes a Reader: Proven Ideas from Research for Parents (Kindergarten through Third Grade)"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
        }
        
    
        [TestMethod]
        public void ByTopicComprehension()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            GCDriver.FindElement(By.Id("edit-field-topic-tid-22")).Click();// comprehension
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("10 Key Reading Practices for All Middle and High Schools"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset
            
        }
        [TestMethod]
        public void ByTopicDyslexia()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            GCDriver.FindElement(By.Id("edit-field-topic-tid-15")).Click();//dyslexia
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("ACCESS Class Vocabulary Chart"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByTopicEnglishLearners()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            GCDriver.FindElement(By.Id("edit-field-topic-tid-28")).Click();//english learners
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Assessment and Data-Based Decision-Making"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByTopicEvidenceBased()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            GCDriver.FindElement(By.Id("edit-field-topic-tid-316")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("An LEA Guide for Identifying Evidence-Based Interventions for School improvement"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByTopicFluencyWithText()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            GCDriver.FindElement(By.Id("edit-field-topic-tid-64")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Content of Effective Reading Instruction"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByTopicGeneralLit()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            GCDriver.FindElement(By.Id("edit-field-topic-tid-309")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            //GCDriver.FindElement(By.LinkText("Content of Effective Reading Instruction"));
            Assert.IsTrue(GCDriver.FindElement(By.ClassName("view-empty")).Text.Equals("No Resources Found\r\nTry removing filters to get more results."));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            

        }
        [TestMethod]
        public void ByTopicIdentfication()
        {


            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));
            
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-63"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-63")).Click();//evidence based
            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
           
            GCDriver.FindElement(By.LinkText("Birth to Five: Watch Me Thrive"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByTopicIntervention()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));
            
            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-27"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-27")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("ACCESS Class Vocabulary Chart"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByTopicLanguageDevelopment()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-18"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-18")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("A Child Becomes a Reader: Proven Ideas from Research for Parents (Birth through Preschool)"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByLegislation()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-34"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-34")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("IDEA Definition of Learning Disability"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByPartnership()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-51"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-51")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Engaging Families from the Start"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByPhonicAwareness()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-21"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-21")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("A Child Becomes a Reader: Proven Ideas from Research for Parents (Birth through Preschool)"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByPhonics()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-23"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-23")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Activities for Young Children: Providing Practice for Development"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByPhonologicalAwareness()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-250"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-250")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Just Take 20 Rhyme Time Activity"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByProfessionalDevelopment()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-36"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-36")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Adolescent Literacy Planning Template #1"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByReadingDisabilities()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-71"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-71")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("ACCESS Class Vocabulary Chart"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByVocab()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-24"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-24")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("A Classroom Scenario"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByWriting()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
            WaitUntilElementClickable(By.Id("edit-field-topic-tid-19"));
            GCDriver.FindElement(By.Id("edit-field-topic-tid-19")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Activities that Build Writing Skills"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        //by resource type
        [TestMethod]
        public void ByActivity()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-62"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-62")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Advanced Phonics and Decoding: Perfecting Our Craft and Planning for the Future, 2nd-3rd Grades"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByArticle()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-59"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-59")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Nebraska's Technical Assistance Document on Dyslexia"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByAudio()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-313"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-313")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Building Academic Literacy Through Text Discussion"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByDocument()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-68"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-68")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("A Comprehensive K-3 Reading Assessment Plan: Guidance for School Leaders"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByGame()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-249"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-249")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Just Take 20 Letter Sounds Fluency: Help the Kids Find Their Skateboard!"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByGuide()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-311"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-311")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("An LEA Guide for Identifying Evidence-Based Interventions for School improvement"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByHandBook()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-60"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-60")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("10 Key Reading Practices for All Middle and High Schools"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByInfographic()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-61"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-61")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Just Take 20 20 Minutes Add Up!"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByInformationSheet()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-53"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-53")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("3 Questions to Ask Before Downloading Apps for Kids"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByLessonPlan()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-72"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-72")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Greek Myths: Vocabulary Lesson, Word List, and Riddle Poems"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByPresentation()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-67"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-67")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Enhancing the Core: Alphabetic Principle"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByTool()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-66"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-66")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("ACCESS Class Vocabulary Chart"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByVideo()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-57"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-57")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("A Classroom Scenario"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByWeninar()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-55"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-55")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Dyslexia and Phonological Processing"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByWebpage()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-65"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-65")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Alabama Department of Education Dyslexia"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        [TestMethod]
        public void ByWorkshop()
        {

            GCDriver.Manage().Window.Maximize();

            WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));

            GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
            WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-56"));
            GCDriver.FindElement(By.Id("edit-field-resource-type-tid-56")).Click();//evidence based
            GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
            GCDriver.FindElement(By.LinkText("Course Enhancement Module: Evidence-based Reading Instruction K-5"));
            GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        }
        //[TestMethod]
        //public void ByThree()
        //{

        //    GCDriver.Manage().Window.Maximize();

        //    WaitUntilElementClickable(By.Id("edit-submit-resource-repository"));
            
        //    WaitUntilElementClickable(By.Id("edit-field-audience-tid-2"));
        //    GCDriver.FindElement(By.Id("edit-field-audience-tid-2")).Click();
        //    GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
        //    GCDriver.FindElement(By.Id("edit-field-topic-tid-14")).Click();
        //    WaitUntilElementClickable(By.Id("edit-field-topic-tid-14"));
        //    GCDriver.FindElements(By.CssSelector(".fieldset-title"))[1].Click();
        //    GCDriver.FindElements(By.CssSelector(".fieldset-title"))[2].Click();
        //    WaitUntilElementClickable(By.Id("edit-field-resource-type-tid-62"));
        //    GCDriver.FindElement(By.Id("edit-field-resource-type-tid-62")).Click();//evidence based
        //    GCDriver.FindElement(By.Id("edit-submit-resource-repository")).Click();//submit button
        //    GCDriver.FindElement(By.LinkText("Just Take 20 A Dozen Questions to Ask Your Child's Language Arts Teacher"));
        //    GCDriver.FindElement(By.Id("edit-reset")).Click();//reset            
        //}
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









        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }
    }
}
