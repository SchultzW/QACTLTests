using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace NCILWebTests
{
    [TestClass]
    public class AskAnExpert
    {

        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {
            var options = new ChromeOptions();
            options.AddArgument("headless");
            GCDriver = new ChromeDriver(options);
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/ask-an-expert");
        }
        [TestMethod]
        public void TestTitle()
        {
            Assert.IsTrue(GCDriver.Title.Equals("Ask an Expert | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.ClassName("page__title")).Text.Equals("Ask an Expert"));
        }
        [TestMethod]
        public void ScreeningAndID1()
        {
            GCDriver.FindElement(By.LinkText("Can a young child (under age 6) be diagnosed with dyslexia or at that age is the focus on recognizing warning signs?")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Can a young child (under age 6) be diagnosed with dyslexia or at that age is the focus on recognizing warning signs? | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.Id("page-title")).Text.Equals("Can a young child (under age 6) be diagnosed with dyslexia or at that age is the focus on recognizing warning signs?"));
            TestingClass.IsElementPresentClassName("action",GCDriver);
            TestingClass.IsElementPresentClassName("figure",GCDriver);
            TestingClass.IsElementPresentLinkText("Related Resources",GCDriver);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[2]/div/div/div[1]/div/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]")).Text.Equals("Submitted by: Parents & Families\r\nPosted on: 02/13/2018 - 3:14pm\r\nTopic: Identification\r\nAnswer\r\nThis is an excellent question. Whether children can be identified early (under age 6) and treated for dyslexia depends, in part, on whether we consider the symptoms of dyslexia to be “expected” or “unexpected” in a child. The International Dyslexia Association (Lyon et al., 2003) defines dyslexia as a specific learning disability that is neurological in origin. It is characterized by difficulties with accurate word recognition, fluent word recognition, or both, and by poor spelling and decoding abilities. These difficulties typically result from a deficit in the phonological component of language that is often unexpected in relation to other cognitive skills and the provision of effective classroom instruction.\r\nIf we consider dyslexia to be an “unexpected” difficulty in a child’s ability to develop word reading and spelling skills then identification is typically operationalized by the presence of a significant discrepancy between a child’s word reading and spelling achievement and other cognitive skills, often measured via an IQ test. This identification practice requires a child to fall significantly below their potential and that of peers on word reading, spelling, or both before they can be identified as having dyslexia.  This is often referred to as a “wait-to-fail” model of identification.\r\nHowever, if dyslexia is defined as an “expected” difficulty, based on neural-cognitive processing deficits underlying reading and spelling development, we can move away from discrepancy-based definitions of dyslexia and focus on early identification and treatment of children with dyslexia either prior to the onset of formal reading instruction or soon after instruction is initiated. This allows for early evidence-based intervention for reading problems to be initiated in the primary grades before children with dyslexia fall behind their peers.\r\nThe challenge with early screeners or assessments for dyslexia is that in order to detect the subtle early signs of dyslexia, they tend to over identify children as at risk (i.e., false positives). False positives occur when children score poorly on a dyslexia screener but still develop typical reading and spelling skills. This is because measures of phonological processing and early print awareness, often used to identify children with dyslexia prior to reading instruction, are confounded by a child’s linguistic and cognitive development as well as opportunities and experiences to learn. While cognitive psychologists and neuroscientists continue to identify important behavioral and neuro markers associated with dyslexia to reduce the number of false positives when screening children under 6 years of age, current false positive rates are unacceptably high. To decrease false positives associated with early screening for dyslexia, it is often recommended that diagnosis for dyslexia take place after children have had some experience with learning to read. However, this practice again tends to delay the opportunity for early intervention before children begin to fail.\r\nA different way to think about dyslexia in young children is to use multiple indicators and a multi-level approach to gauge a child’s risk for dyslexia. This would take into account important linguistic and cognitive developmental milestones along with other important factors such as family history of dyslexia to identify different levels of risk. In such an approach, children with multiple risk factors would be considered at greater risk for developing dyslexia and therefore should receive intensive evidence-based intervention before or simultaneously with the onset of formal reading instruction. Those with fewer indicators and less elevated risk should be monitored closely to gauge their response to classroom instruction. This allows intervention to proceed before the diagnosis of dyslexia but certainly should not take the place of a thorough diagnostic evaluation for dyslexia.\r\nReferences\r\nThe International Dyslexia Association. (2014). IDA dyslexia handbook: What every family should know. Baltimore, MD: The International Dyslexia Association.\r\nLyon, G.R., Shaywitz, S.E., & Shaywitz, B.A. (2003). A definition of dyslexia. Annals of Dyslexia, 53, 1–14."));
        }
      
        [TestMethod]
        public void ScreeningAndID2()
        {
            GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.FindElement(By.LinkText("What is the relationship between MTSS and diagnosis of dyslexia? Does MTSS slow down the diagnosis?")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("What is the relationship between MTSS and diagnosis of dyslexia? Does MTSS slow down the diagnosis? | National Center on Improving Literacy"));
            TestingClass.IsElementPresentClassName("action",GCDriver);
            TestingClass.IsElementPresentClassName("figure",GCDriver);
            TestingClass.IsElementPresentLinkText("Related Resources",GCDriver);
        }
        [TestMethod]
        public void LegislationAndPolicy()
        {
            GCDriver.Manage().Window.Maximize();
            GCDriver.FindElement(By.XPath("//*[@id='ui-accordion-1-header-1']/a")).Click();
            System.Threading.Thread.Sleep(6000);
            WaitUntilElementClickable(By.LinkText("Does Special Education law include dyslexia?"));
            GCDriver.FindElement(By.LinkText("Does Special Education law include dyslexia?")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Does Special Education law include dyslexia? | National Center on Improving Literacy"));
            TestingClass.IsElementPresentClassName("action",GCDriver);
            TestingClass.IsElementPresentClassName("figure",GCDriver);
            TestingClass.IsElementPresentLinkText("Related Resources",GCDriver);
        }
        [TestMethod]
        public void ReadingIntervention1()
        {

            GCDriver.Manage().Window.Maximize();
            GCDriver.FindElement(By.XPath("//*[@id='ui-accordion-1-header-2']")).Click();
            System.Threading.Thread.Sleep(6000);
            GCDriver.FindElement(By.LinkText("Is there any hope of my child actually catching up to his peers?")).Click();
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[2]/div/div/div[1]/div/img", GCDriver);
                                                
            TestingClass.IsElementPresentClassName("action", GCDriver);
            TestingClass.IsElementPresentClassName("figure", GCDriver);
            TestingClass.IsElementPresentLinkText("Related Resources", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p")).Text.Equals("Yes, students and children who get explicit and systematic evidence-based intervention often are able to meet grade level expectations and certainly accelerate their learning. And the more that they accelerate their learning with those good interventions the better they're able to access the core classroom instruction that's occurring at their grade level and with their peers. And many many students achieve that and are successful readers. It's possible that they may need the support and the intervention throughout their schooling to maintain that and to be successful, but many students can reach those levels."));

        }
        [TestMethod]
        public void ReadingIntervention2()
        {
            GCDriver.Manage().Window.Maximize();
            GCDriver.FindElement(By.XPath("//*[@id='ui-accordion-1-header-2']")).Click();
            System.Threading.Thread.Sleep(6000);
            GCDriver.FindElement(By.LinkText("What are the characteristics of effective literacy instruction?")).Click();
            TestingClass.IsElementPresentClassName("action", GCDriver);
            TestingClass.IsElementPresentClassName("figure", GCDriver);
            TestingClass.IsElementPresentLinkText("Related Resources", GCDriver);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[2]/div/div/div[1]/div/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[1]")).Text.Equals("Effective instruction for students who struggle with reading should be systematic. It should be systematic in that it follows a scope and sequence that builds in level of difficulty and complexity while also building in time for review for students to practice skills they have already learned."));

        }
        [TestMethod]
        public void ReadingIntervention3()
        {
            GCDriver.Manage().Window.Maximize();
            GCDriver.FindElement(By.XPath("//*[@id='ui-accordion-1-header-2']")).Click();
            System.Threading.Thread.Sleep(6000);
            GCDriver.FindElement(By.LinkText("What do you suggest using to support the argument to a school that a dyslexic student needs an Orton-Gillingham based program as part of their IEP? What research or information shows that Orton-Gillingham is the best approach for dyslexia?")).Click();
            TestingClass.IsElementPresentClassName("action", GCDriver);
            TestingClass.IsElementPresentClassName("figure", GCDriver);
            TestingClass.IsElementPresentLinkText("Related Resources", GCDriver);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[2]/div/div/div[1]/div/img", GCDriver);
            //here
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]")).Text.Equals("Submitted by: Parents & Families\r\nPosted on: 01/29/2018 - 1:50pm\r\nTopic: Dyslexia, Interventions\r\nAnswer\r\nFor any IEP, it is critical to ensure that all decisions about instructional services are based on the individual student’s data and needs. First, the team should review the data from the evaluation, observation and classroom performance, including any data regarding the student’s response to instruction and interventions. The most effective way to prepare an IEP is through this type of comprehensive review of a student's needs - understanding what has been tried that hasn't worked, and what instructional approaches should be tried based on the student's presenting concerns. There should be a clear connection – and hypothesis – regarding the student’s presenting concerns and the recommended instructional programming.\r\nOrton-Gillingham approaches are research-based, not evidence-based. This is an important distinction. Evidence based programs means that there have been studies (typically a randomized-controlled trial) that report on the program’s effectiveness for the target population compared to another instructional approach. To my knowledge, there are no studies that provide evidence for Orton-Gillingham approaches’ effectiveness relative to another type of instructional intervention.\r\nResearch based programs are those that have been developed by drawing on the existing research base. In the case of Orton-Gillingham methods, Orton-Gillingham approaches are informed by the research suggesting multi-sensory approaches are effective means of supporting students with dyslexia.\r\nReferences\r\nWhat Works Clearinghouse Intervention Report (July 2010). Orton-Gillingham-based strategies. Washington, DC: U.S. Department of Education, Institute of Education Sciences, National Center for Education Evaluation and Regional Assistance, What Works Clearinghouse. https://ies.ed.gov/ncee/wwc/Intervention/737"));
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[3]/div/div[1]/h3/a", GCDriver);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[4]/div/div[1]/h3/a", GCDriver);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[5]/div/div[1]/h3/a", GCDriver);



        }
        [TestMethod]
        public void ReadingIntervention4()
        {
            GCDriver.Manage().Window.Maximize();
            GCDriver.FindElement(By.XPath("//*[@id='ui-accordion-1-header-2']")).Click();
            System.Threading.Thread.Sleep(6000);
            GCDriver.FindElement(By.LinkText("What’s the best way to teach the Alphabetic Principle?")).Click();
            TestingClass.IsElementPresentClassName("action", GCDriver);
            TestingClass.IsElementPresentClassName("figure", GCDriver);
            TestingClass.IsElementPresentLinkText("Related Resources", GCDriver);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[2]/div/div/div[1]/div/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]")).Text.Equals("Submitted by: Schools & Districts\r\nPosted on: 06/20/2018 - 3:04pm\r\nTopic: Beginning Reading\r\nAnswer\r\nAlphabetic principle is the idea that letters, and groups of letters, match individual sounds in words. The ability to apply these predictable relationships to familiar and unfamiliar words is crucial to reading.\r\nLetter-sound correspondence, or the relationship of the letters in the alphabet to the sounds they produce, is a key component of the alphabetic principle and learning to read. To teach letter sound correspondence, work with a few sounds at a time by teaching each letter of the alphabet and its corresponding sound. For each letter-sound relationship, instruction should include naming the letter or letters that represent the sound and it should associate a picture cue of an object with the target sound to help students remember the relationship between the letter and the sound (i.e., an image of a pig, the printed letter p, and the teacher orally stating the sound for /p/).\r\nAdditionally, incorporating a short story that incorporates the sound and has a picture of an object with the target sound and letter helps students remember the picture and the sound when they encounter the letter in print. For example, if students are learning the letter and sound for ‘p’ with an image of a pig as the picture cue, the accompanying story may be “Polly Pig likes to eat pizza and play with her pals.” When teaching the relationship between each letter and its corresponding sound, introduce the letter in uppercase and lowercase. Multiple practice opportunities with letter-sound relationships should be provided daily to teach new letter-sound relationships and to review letters and sounds previously taught.\r\nThere is no specific agreed upon instructional sequence for introducing letter-sound relationships; however, relationships that enable students to begin reading words as quickly as possible should be introduced earliest in instruction. When teaching new letter-sound relationships, begin with letter-sound relationships of high utility (such as m, a, and s) so students can begin working with words as soon as possible. Stagger letter-sound relationships that are auditorily confusing (such as b and v) or visually similar (such as b and d) to promote mastery of one before introducing the confusing counterpart to students.  After students master sounds spelled with one letter, more complex letter-sound relationships such as ‘sh’ for /sh/, ‘a_e’ for /a/, and ‘igh’ for /i/ can be introduced.\r\nOnce students have learned a few letter-sound relationships, they can begin to read regular words, or words that follow the phonetic rules and can be sounded out (e.g.; cat, box, bet), containing the letters and sounds they have learned. Irregular words, or words that do not follow phonic rules, such as “said” and “was,” would not be taught using blending strategies. Instead students would be taught to read those words as whole words, or by sight, rather than using a “sound it out” approach. Strategies for blending or, reading words from left to right by linking each letter or group of letters to their sounds, can be taught to help students decode regular words. One such strategy is encouraging students to read words without stopping between sounds. Students can be encouraged to “keep their motor running” (keep their voices on) or to “not stop between sounds” as they say the sounds in a word to read the word. After students have blended the sounds together to read the word, they should read the word the “fast” way, or in a fluent voice without holding each sound. As students become more fluent, they should do the blending work in their heads without saying sounds aloud and only read the word aloud in a quick, fluent voice. \r\nContinuous and stop sounds contribute to the difficulty of the blending task. Continuous sounds are sounds that can be held without being distorted (e.g., /n/, /s/ and /f/), so they are easier to hold and blend together when students are first learning to blend sounds and read words. Stop sounds are made with quick puffs of air and cannot be held without becoming distorted (e.g, /b/, /p/, and /k/.) Most students are successful with blending words containing both continuous and stop sounds. Some students may struggle with blending words with a mix of continuous and stop sounds. To support students who struggle with blending words with both continuous and stop sounds, the following sequence explains the progression of blending from easiest (1) to most difficult (4). Using only words in one level and checking for student mastery before moving to the next level in the sequence will provide scaffolding for students who need additional support with blending sounds to read words.\r\nWords that follow the consonant-vowel-consonant (CVC) pattern and contain all continuous sounds (e.g.; man, run, rim, win);\r\nWords that follow the CVC pattern with a stop sound at the end of the word (e.g.; sap, mat, fit, lot);\r\nWords that follow the CVC pattern with a stop sound at the beginning of the word (e.g.; top, pan, big, ten);\r\nWords that follow the consonant-vowel-consonant-consonant (CCVC) pattern with a blend at the beginning that includes a stop sound (e.g.; step, skit, spot, spun)\r\nAfter students have mastered blending words that follow CVC and CCVC spelling patterns, words with more advanced spelling patterns, such as vowel-consonant-silent e (e.g.; a_e, o_e) and vowel sounds spelled with more than one letter (e.g.; ai, igh), can be introduced. As more complex spelling patterns and words are taught, teach students to recognize the vowel pattern and corresponding sound in the word to assist with decoding the word.\r\nTo build awareness of how letters and their sounds are connected to spelling and pronunciation, word-building activities such as word ladders (Figure 1.1) and sound boxes (Figure 1.2) should be integrated into literacy instruction. As word building activities are embedded into instruction, begin with words that contain simple patterns such as VC (e.g. am) and CVC spelling patterns. After students master simple spelling patterns, gradually incorporate more advanced words as students learn more advanced spelling patterns (e.g.; vowel-consonant-silent e, vowel patterns spelled with more than one letter.)\r\n  When students understand the alphabetic principle and are able to apply what they know about letter-sound correspondence to translate printed letters and letter combinations into the sounds they make, they are able to accurately read a vast number of words-including words they have never encountered in text.\r\nWords that Follow the CVC Spelling Pattern*\r\nWords that Follow the CCVC Spelling Pattern\r\nAll Continuous Sounds\r\nStop Sound at the End\r\nStop Sound at the Beginning\r\nBeginning Blend Includes a Stop Sound\r\nman\r\nran\r\nyam\r\nvan\r\nmen\r\nfin\r\nrim\r\nwin\r\nmom\r\nfun\r\nrun\r\nsum\r\nnap\r\nmap\r\nrag\r\nMeg\r\nfed\r\nrip\r\nlid\r\nrig\r\nrod\r\nfog\r\nrub\r\nnut\r\npan\r\ncan\r\njab\r\nbed\r\nten\r\nbig\r\ntip\r\nhid\r\npot\r\nhop\r\njug\r\ngum\r\nspat\r\nscam\r\nscat\r\nstep\r\nsped\r\nskit\r\nskip\r\nspin\r\nstop\r\nspot\r\nspun\r\nstud\r\n* Note: The lists above do not include all words for each level in the blending sequence, rather they are examples of some words for each level of the blending sequence. There are additional words that fit the spelling patterns and sound placements in the chart above that can be used in blending instruction. Words selected for blending instruction should be contingent upon the spelling pattern of the word (CVC/CCVC), type of sounds (stop and/or continuous) the word includes, placement of those sounds within the word, letters-sound relationships students have learned, and the student’s current level of knowledge within the blending sequence.\r\nReferences\r\nHarn, B., Simmons, D. C., & Kame’enui, E. J. (2003). Institute on Beginning Reading II: Enhancing alphabetic principle instruction in core reading instruction [PowerPoint slides]. Retrieved from http://oregonreadingfirst.uoregon.edu/downloads/instruction/big_five/enh...\r\nFoundational Skills to Support Reading for Understanding in Kindergarten Through 3rd Grade. U.S. Department of Education, Institute of Education Sciences, National Center for Education Evaluation and Regional Assistance, What Works Clearinghouse."));
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[3]/div/div/div[2]/div/div/a", GCDriver);
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[4]/div/div[1]/h3/a", GCDriver);

        }



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
