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
    public class GlossaryPages
    {

        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {

            GCDriver = new ChromeDriver();
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/glossary");
            //GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [TestMethod]
        public void AcademicLanguage()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/academic-language']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The formal language common in books and at school that students need to understand and communicate in academic disciplines.");
            IsElementPresentLinkText("Succeeding in School: Essential Features of Literacy Development");
            IsElementPresentCSS(".field.field-name-field-infographic");

        }
        [TestMethod]
        public void Accuracy()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/accuracy']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to read words correctly.");
            IsElementPresentLinkText("Learning to Read: “The Simple View of Reading”");
            IsElementPresentCSS(".field.field-name-field-infographic");

        }
        [TestMethod]
        public void AlphabetKnowledge()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/alphabet-knowledge']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to name letters and know their sounds.");
         

        }
        [TestMethod]
        public void AlphabetPrinciple()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/alphabetic-principle']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The idea that letters and groups of letters match individual sounds in words.");
            IsElementPresentLinkText("The Alphabetic Principle: From Phonological Awareness to Reading Words");
            IsElementPresentCSS(".field.field-name-field-infographic");
            IsElementPresentLinkText("What’s the best way to teach the Alphabetic Principle?");
            IsElementPresentLinkText("Enhancing the Core: Alphabetic Principle");
            IsElementPresentLinkText("Reading Basics Webinar");

        }
        [TestMethod]
        public void AuditoryPerception()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/auditory-perception']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to understand what you hear.");


        }
        [TestMethod]
        public void AuditoryProcessing()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/automaticity']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to read a word correctly and instantly.");


        }
        [TestMethod]
        public void Blending()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/blending']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Reading words from left to right by linking each letter or group of letters to their sounds.");


        }
        [TestMethod]
        public void CognitiveProcessing()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/cognitive-processing']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Brain-based activities that influence learning, including attention, memory and reasoning.");


        }
        [TestMethod]
         public void ConnectedText()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/connected-text']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A group of sentences that relate to one another.");


        }
        [TestMethod]
        public void DecodableWords()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/decodable-words']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Words that sound the way they are spelled or can be sounded out because they have letter-sound relationships  already learned.");


        }
        [TestMethod]
        public void Decoding()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/decoding']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Using your knowledge of letter-sound relationships to sound out words.");


        }
        [TestMethod]
        public void Diagnosis()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/diagnosis']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Identification of a disorder determined by a medical or educational professional.");
            IsElementPresentLinkText("Can a young child (under age 6) be diagnosed with dyslexia or at that age is the focus on recognizing warning signs?");

        }
        [TestMethod]
        public void Dyscalculia()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/dyscalculia']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A neurologically based specific learning disability in math, such as difficulty making sense of and working with numbers.");


        }
        [TestMethod]
        public void Dysgraphia()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/dysgraphia']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A neurologically based specific learning disability in writing, such as difficulty with spelling, handwriting, or recording your ideas.");


        }
        [TestMethod]
        public void Dyslexia()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/dyslexia']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A brain-based learning disability that specifically impairs a person's ability to read.");
            IsElementPresentLinkText("Defining Dyslexia");
            IsElementPresentLinkText("Federal Guidance on Dyslexia from the Office of Special Education and Rehabilitative Services");
            IsElementPresentLinkText("Dyslexia Fact Sheet");
            IsElementPresentLinkText("Information and Resources for Adolescents and Adults with Dyslexia - It's Never Too Late");
        }
        [TestMethod]
        public void EligibilityCategoryOrClassification()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/eligibility-category-or-classification']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("One or more of the categories identified in IDEA to qualify a child for special education services.");
            IsElementPresentLinkText("IDEA Definition of Learning Disability");
            IsElementPresentLinkText("The Individuals with Disabilities Education Act");
            IsElementPresentLinkText("Parental Rights Under IDEA");
           
        }
        [TestMethod]
        public void EvidenceBased()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/evidence-based']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("An intervention, tool, or practice that meets one of the four evidence levels in the federal Elementary and Secondary Education Act, as amended by ESSA (strong, moderate, promising, or demonstrates a rationale).");
            IsElementPresentLinkText("What Counts as Evidence? Making Decisions for Instruction and Intervention in an MTSS Framework");
            IsElementPresentLinkText("An SEA Guide for Identifying Evidence-Based Interventions for School improvementc");
            IsElementPresentLinkText("An LEA Guide for Identifying Evidence-Based Interventions for School improvement");

        }
        [TestMethod]
        public void ExecutiveFunctioning()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/executive-functioning']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Learning processes like the ability to plan, organize, problem-solve, sustain attention, and manage tasks and schedules.");


        }
        [TestMethod]
        public void ExplicitInstruction()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/explicit-instruction']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Teaching that is direct and step-by-step, including explaining and showing how to do something.");


        }
        [TestMethod]
        public void Expression()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/expression']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to read 'like you talk.' To change your voice and pause when reading to emphasize the meaning of the story.");


        }
        [TestMethod]
        public void ExpressiveLanguage()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/expression']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Language that you use to communicate.");


        }
        [TestMethod]
        public void Fluency()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/fluency']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to read words, phrases, sentences, and stories correctly, with enough speed, and expression.");
            IsElementPresentLinkText("Learning to Read: “The Simple View of Reading”");
            IsElementPresentLinkText("Does Your Kindergartner Read Smoothly Like This?");
            IsElementPresentLinkText("Does Your First Grader Read Smoothly Like This?");
            IsElementPresentLinkText("Does Your Second Grader Read Smoothly Like This?");
        }
        [TestMethod]
        public void Grammar()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/grammar']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The set of rules that explain how words are used and put together in a language.");   
           
        }
        [TestMethod]
        public void Grapheme()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/grapheme']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A printed letter or group of letters that represent a sound in a syllable or word.");
        }
        [TestMethod]
        public void HighFrequencyWords()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/high-frequency-words']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals(" Words that appear in print most often.");
        }
        [TestMethod]
        public void Identfication()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/identification']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A process used to determine whether a child has a  disability.");
            IsElementPresentLinkText("The Role of RTI in LD Identification webcast");
            IsElementPresentLinkText("IDEA Definition of Learning Disability");
            IsElementPresentLinkText("The Individuals with Disabilities Education Act");
        }
        [TestMethod]
        public void Intervention()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/intervention']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Additional small group or individualized instruction that is tailored to children's needs so they can make progress and be on track to meet grade level learning goals.");
            IsElementPresentLinkText("Is there any hope of my child actually catching up to his peers?");
            IsElementPresentLinkText("Expert Interview: Finding the Right Tutoring Program");
            IsElementPresentLinkText("What is Responsiveness to Intervention?");
            IsElementPresentLinkText("What Role do Parents Play in the RTI Process?");
        }
        [TestMethod]
        public void IndividualizedEdcuationalProgram()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/individualized-educational-program']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A written learning plan for special education services that is designed to meet the specific learning needs of a child.");
            IsElementPresentLinkText("Individualized Education Program (Spanish)");
            IsElementPresentLinkText("Individualized Education Program");
            
        }
        [TestMethod]
        public void IrregularWords()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/irregular-words']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Words that are hard to sound out because the letters and sounds do not match up (for example, said).");
          
        }
        [TestMethod]
        public void LanguageProcessing()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/language-processing']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to quickly and correctly match meaning to sound groups that form words, sentences and stories.");

        }
        [TestMethod]
        public void ListeningComprehension()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/listening-comprehension']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to understand what others read and say to you.");
            IsElementPresentLinkText("Learning to Read: “The Simple View of Reading”");
            IsElementPresentLinkText("Does Your Kindergartner Show Understanding Like This?");
            IsElementPresentLinkText("Does Your First Grader Show Understanding Like This?");
            IsElementPresentLinkText("Does Your Second Grader Show Understanding Like This?");
        }
        [TestMethod]
        public void Literacy()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/literacy']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to read and write well.");

        }
        [TestMethod]
        public void LiteracyRichEnviornment()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/literacy-rich-environment']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A place that encourages reading and writing, such as listening to stories read aloud, reading together, and talking about ideas.");

        }
        [TestMethod]
        public void Morphology()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/morphology']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The knowledge of word parts that have meaning, such as affixes, root, and base words.");

        }
        [TestMethod]
        public void MultiTieredSystemofSupport()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/multi-tiered-system-support']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A schoolwide framework that supports students who are struggling with reading, math, or social and emotional issues through different levels of intensity.");
            IsElementPresentLinkText("What is the relationship between MTSS and diagnosis of dyslexia? Does MTSS slow down the diagnosis?");
            IsElementPresentLinkText("The ABCs of RtI in Elementary School: A Guide for Families");
            IsElementPresentLinkText("The ABCs of RtI in Middle Schools: A Guide for Parents");
            IsElementPresentLinkText("A Family Guide to Response to Intervention");
        }
        [TestMethod]
        public void NonverbalLearningDisabilities()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/nonverbal-learning-disabilities']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A brain-based disorder that makes it hard to understand communication like body language, tone of voice, and facial expressions.");

        }
        [TestMethod]
        public void OralLanguage()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/oral-language']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The way you communicate with others through speaking and listening.");

        }
        [TestMethod]
        public void Orthography()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/orthography']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The knowledge that the written language is connected to oral language, including how to spell words.");

        }
        [TestMethod]
        public void Phoneme()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/phoneme']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The smallest sound part in spoken language, like /c/ in 'cat'.");

        }
        [TestMethod]
        public void PhonemicAwareness()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/phonemic-awareness']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to identify and play with individual sounds in spoken words.");
            IsElementPresentLinkText("Ask & Answer: Phonemic Awareness");
            IsElementPresentLinkText("Blending and Segmenting Games");
            IsElementPresentLinkText("Elkonin Boxes");
            IsElementPresentLinkText("Phonemic Awareness: Watch & Learn");

        }
        [TestMethod]
        public void Phonics()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/phonics']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Reading instruction on understanding how letters and groups of letters link to sounds to form letter-sound relationships and spelling patterns.");
            IsElementPresentLinkText("Does Your Kindergartner Decode Like This?");
            IsElementPresentLinkText("Does Your First Grader Decode Like This?");
            IsElementPresentLinkText("Does Your Second Grader Decode Like This?");
            

        }
        [TestMethod]
        public void PhonologicalAwareness()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/phonological-awareness']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to recognize that spoken words are made up of individual sound parts.");
            IsElementPresentLinkText("How We Learn to Read: The Critical Role of Phonological Awareness");
            IsElementPresentLinkText("Preschool Parent Practice Literacy Guides: Rhymes and Sound Awareness");
            IsElementPresentLinkText("Just Take 20 Rhyme Time Activity");


        }
        [TestMethod]
        public void PhonologicalProcessing()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/phonological-processing']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to quickly and correctly hear, store, recall, and make different speech sounds.");

        }
        [TestMethod]
        public void Pragmatics()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/pragmatics']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("How we use language to communicate.");

        }
        [TestMethod]
        public void PrintAwareness()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/print-awareness']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The understanding that what is read is linked to the words on the page, rather than to the pictures.");

        }
        [TestMethod]
        public void RapidAutomatizedNaming()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/rapid-automatized-naming']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to quickly name aloud information from memory, such as numbers, letters, objects, or colors.");

        }
        [TestMethod]
        public void ReadingComprehension()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/reading-comprehension']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to understand what you are reading.");
            IsElementPresentLinkText("Learning to Read: “The Simple View of Reading”");
            IsElementPresentLinkText("Does Your Kindergartner Show Understanding Like This?");
            IsElementPresentLinkText("Does Your First Grader Show Understanding Like This?");
            IsElementPresentLinkText("Does Your Second Grader Show Understanding Like This?");

        }
        [TestMethod]
        public void ReceptiveLanguage()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/receptive-language']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Language that you understand.");

        }
        [TestMethod]
        public void Scaffolding()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/scaffolding']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Teaching that provides temporary instructional support, like an example or feedback, during initial learning of a concept or skill.");

        }
        [TestMethod]
        public void Screening()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/screening']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Short processes to find students who need help in reading, writing, spelling, or math.");
            IsElementPresentLinkText("Learn the Signs, Act Early: Age 5 Milestones");
            IsElementPresentLinkText("Learn the Signs, Act Early: Video of Age 5 Milestones");
            IsElementPresentLinkText("Milestones of Early Literacy Development");
        }
        [TestMethod]
        public void SelfMonitoring()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/self-monitoring']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to think about what you are learning and understanding  while reading, including using a strategy when you are confused by a word or idea.");
        }
        [TestMethod]
        public void Semantics()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/semantics']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The part of language that has to do with the meaning of words, phrases, sentences, paragraphs.");

        }
        [TestMethod]
        public void SpecificLearningDisability()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/specific-learning-disability']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A disorder that makes it hard to understand or use language, such as difficulty with listening, thinking, speaking, reading, writing, spelling or calculating math.");

        }
        [TestMethod]
        public void Syntax()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/syntax']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The part of language that has to do with the grammatical forms and structure of sentences.");

        }
        [TestMethod]
        public void SystematicInstruction()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/systematic-instruction']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Teaching that has a carefully planned sequence, including building from easier to more difficult tasks and breaking down harder skills into smaller parts.");
            IsElementPresentLinkText("Practice Guides for Families: Getting Specific Guide");
        }
        [TestMethod]
        public void VisualAcuity()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/visual-acuity']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("The ability to see clearly.");
          
        }
        [TestMethod]
        public void VisualPerceptualMotorDeficit()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/visual-perceptualvisual-motor-deficit']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A disorder that makes it hard to draw or copy or understand information that you see.");

        }
        [TestMethod]
        public void Vocabulary()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/vocabulary']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("Knowing what words mean and how to say and use them correctly.");
            IsElementPresentLinkText("Can Your Kindergartner Figure Out the Meaning of New Words?");
            IsElementPresentLinkText("Can Your First Grader Figure Out the Meaning of New Words?");
            IsElementPresentLinkText("Can Your Second Grader Figure Out the Meaning of New Words?");
        }
        [TestMethod]
        public void WrittenLanguage()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/written-language']")).Click();
            GCDriver.FindElement(By.ClassName("lead")).Text.Equals("A form of communication that involves both reading and writing.");
            
        }
        [TestMethod]
        public void AskAnswerPhonemicAwareness()
        {


            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/glossary/module/ask-answer-phonemic-awareness");
            GCDriver.FindElement(By.LinkText("Download Phonemic-Awareness-Module-Transcript.pdf")).Click();
            System.Threading.Thread.Sleep(6000);
            Assert.IsTrue(CheckFileDownloaded("honemic-Awareness-Module-Transcript.pdf"));
            GCDriver.FindElement(By.PartialLinkText("Download Phonemic-Awareness-Module-Audio.mp4")).Click();
            System.Threading.Thread.Sleep(6000);
            Assert.IsTrue(CheckFileDownloaded("Phonemic-Awareness-Module-Audio.mp4"));
            GCDriver.FindElement(By.XPath("//*[@id='content']/div[2]"));
            IsElementPresentXpath("//*[@id='content']/div[2]");


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
        private static bool CheckFileDownloaded(string filename)
        {
            bool exist = false;
            string Path = System.Environment.GetEnvironmentVariable("USERPROFILE") + "\\Downloads";
            string[] filePaths = Directory.GetFiles(Path);
            foreach (string p in filePaths)
            {
                if (p.Contains(filename))
                {
                    FileInfo thisFile = new FileInfo(p);
                    //Check the file that are downloaded in the last 3 minutes
                    if (thisFile.LastWriteTime.ToShortTimeString() == DateTime.Now.ToShortTimeString() ||
                    thisFile.LastWriteTime.AddMinutes(1).ToShortTimeString() == DateTime.Now.ToShortTimeString() ||
                    thisFile.LastWriteTime.AddMinutes(2).ToShortTimeString() == DateTime.Now.ToShortTimeString() ||
                    thisFile.LastWriteTime.AddMinutes(3).ToShortTimeString() == DateTime.Now.ToShortTimeString())
                        exist = true;
                    File.Delete(p);
                    
                    break;
                }
            }
            return exist;

        }

        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }
    }
}
