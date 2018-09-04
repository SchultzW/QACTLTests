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
            var options = new ChromeOptions();
            options.AddArgument("headless");
            GCDriver = new ChromeDriver();

            //GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }
        [TestMethod]
        public void AlabamaText()
        {
          GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/alabama");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
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
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Students with IEPs will be prepared to transition effectively and achieve improved post-school outcomes [i.e., students will be able to achieve positive post-school outcomes and engage in higher education and competitive employment opportunities]."));
          
        }
        [TestMethod]
        public void AlaskaText()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/alaska");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB 64 (under consideration)"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("This bill would create a dyslexia and literacy task force."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Alaska does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Alaska does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Alaska does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("Alaska does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Alaska will increase the graduation rates of students with disabilities who attend the 42 schools identified as focus and priority schools in FFY 2013 under the Statewide System of Supports."));
        }
        [TestMethod]
        public void Arizona()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/arizona");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("ARS 15-219, ARS 15-249, ARS 15-704"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("ARS 15-219 states that the “state board of education shall adopt rules to allow certificated teachers and administrators to count training regarding screening, intervention, accommodation, use of technology and advocacy for students with reading impairments, including dyslexia, as continuing education credits.” ARS 15-249 states that the “department of education may develop a dyslexia handbook.” ARS 15-704 describes screening, intervention, in-service requirements, and the oversight of instruction."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("According to ARS 15-704, “Each school district or charter school that provides instruction in kindergarten programs and grades one through three shall select and administer screening, ongoing diagnostic and classroom-based instructional reading assessments, including a motivational assessment, as defined by the state board of education, to monitor student progress. Each school shall use the diagnostic information to plan appropriate and effective intervention.”"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Arizona does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("According to ARS 15-704, “Each school district or charter school that provides instruction for pupils in kindergarten programs and grades one through three shall conduct a curriculum evaluation and adopt an evidence-based reading curriculum that includes the essential components of reading instruction. All school districts and charter schools that offer instruction in kindergarten programs and grades one through three shall provide ongoing teacher training based on evidence-based reading research.”"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("According to ARS 15-704, “A pupil in grade three who does not demonstrate proficiency on the reading standards measured by the statewide assessment administered pursuant to section 15-741 shall be provided core reading instruction and intensive, evidence-based reading instruction as defined by the state board of education until the pupil meets these standards.”"));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[18]")).Text.Equals("1. \"Essential components of reading instruction\" means explicit and systematic instruction in the following: (a) Phonemic awareness. (b) Phonics. (c) Vocabulary development. (d) Reading fluency. (e) Reading comprehension."));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[19]")).Text.Equals("2. \"Evidence-based reading research\" means research that demonstrates either: (a) A statistically significant effect on improving student outcomes or other relevant outcomes based on either: (i) Strong evidence from at least one well-designed and well-implemented experimental study. (ii) Moderate evidence from at least one well-designed and well-implemented quasi-experimental study. (iii) Promising evidence from at least one well-designed and well-implemented correlational study with statistical controls for selection bias. (b) A rationale based on high-quality research findings or positive evaluation that an activity, strategy or intervention is likely to improve student outcomes or other relevant outcomes and that includes ongoing efforts to examine the effects of these activities, strategies or interventions."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[20]")).Text.Equals("3. \"Reading\" means a complex system of deriving meaning from print that requires all of the following: (a) The skills and knowledge to understand how phonemes or speech sounds are connected to print. (b) The ability to decode unfamiliar words. (c) The ability to read fluently. (d) Sufficient background information and vocabulary to foster reading comprehension. (e) The development of appropriate active strategies to construct meaning from print. (f) The development and maintenance of a motivation to read.”"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p[1]")).Text.Equals("Targeted sites will increase the performance of students with disabilities in grades 3-5 on the English/Language Arts (ELA) state assessment from 6.4% to 12.99% to meet the state proficiency average for students with disabilities in grades 3-5."));

        }
        [TestMethod]
        public void Arkansas()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/arkansas");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Arkansas Senate Bill 788 and Act 1294"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("In 2015, Arkansas passed SB 788. The bill (a) defines dyslexia, (b) establishes screening requirements, (c) establishes evidence-based screening requirements, (d) creates a dyslexia specialist position at the Arkansas Department of Education, (e) outlines professional development requirements, and (f) calls for a plan to collaborate with institutions of higher education for teacher training."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Screening is required for: 1) Each student in kindergarten through grade two (K-2); 2) Kindergarten through grade 2 (K-2) students who transfer to a new school and have not been screened; 3) Kindergarten through grade 2 (K-2) students who transfer from another state and cannot present documentation that the student has had similar screening; 4) A student in grade three or higher experiencing difficulty, as noted by a classroom teacher. Students with sensory impairments, extant dyslexia diagnoses, or severe cognitive impairments may be exempt."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("Screeners must measure: phonological and phonemic awareness, sound-symbol recognition, alphabet knowledge, decoding skills, and rapid naming skills. Recognized screeners include: DIBELS, AIMSWeb, Istation ISIP, NWEA Skills Checklist, Lakeshore: Alphabet Letter Identification, Core Literacy Library: Phoneme Segmentation Test, Scholastic: CORE Phonics Survey, Decode: Consonant Blends and Digraphs, FCRR: Oral Reading Fluency Passages, Ultimate Phonics Reading Test, Arkansas Rapid Naming Screener (AR-RAN), Word Journeys, and Words Their Way. See the state handbook for specific grade-level and content correspondences."));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("According to the state dyslexia resource guide, \"No later than the 2015-2016 school year, the Department of Education shall collaborate with the Department of Higher Education to ensure that all teacher education programs offered at state-supported institutions of higher education provide professional awareness of the characteristics of dyslexia and evidence-based interventions and accommodations for dyslexia. Professional development providers interested in delivering this professional awareness piece should apply for ADE approval through the Arkansas Professional Development Submission and Management System (PDSAM)."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("By fiscal year, 2015, at least one staff member at each education service cooperative is trained as a dyslexia specialist to provide necessary information and support to school districts; and each teacher must receive professional development on the characteristics of dyslexia and evidence-based interventions and accommodations for dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("If the initial screener, level I, or level II screener indicates the characteristics of dyslexia, the Response to Intervention process shall be used. The law indicates that intervention may include \"Explicit, direct instruction that is systematic, sequential, and cumulative and follows a logical plan of presenting the alphabetic principle that targets the specific needs of the student without presuming prior skills or knowledge of the student; [...].\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Arkansas's SSIP is aimed at improving literacy amongst students with disabilities. It focuses on improving (a) professional development and technical assistance structures, and the use of multi-tiered systems of support. The SIMR is to improve the percent of students with disabilities who reach proficient on the state assessment."));

        }
        [TestMethod]
        public void California()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/california");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("California Assembly Bill 1369 and Chapter 647"));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Assembly Bill 1369 requires \"the Superintendent of Public Instruction to develop, and to complete in time for use no later than the beginning of the 2017-18 academic year, program guidelines for dyslexia to be used to assist regular education teachers, special education teachers, and parents to identify and assess pupils with dyslexia, and to plan, provide, evaluate, and improve educational services, as defined, to pupils with dyslexia.\" The bill also requires \"the Superintendent to disseminate the program guidelines through the State Department of Education's Internet Web site and to provide technical assistance regarding their use and implementation to specified persons. Existing regulations adopted by the State Board of Education include specific basic psychological processes in the definition of 'specific learning disability.'\" This bill requires \"the state board to include 'phonological processing' in that description of basic psychological processes.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("AB 1369 states, \"Existing law requires all children with disabilities residing in the state, regardless of the severity of their disabilities, and who are in need of special education and related services, to be identified, located, and assessed. Existing law provides that a pupil who is assessed as being dyslexic and meets certain eligibility criteria for the federal Individuals with Disabilities Education Act category of specific learning disabilities is entitled to special education and related services.\" AB 1369 charges the Superintendent with developing guidelines that \"assess pupils with dyslexia, and to plan, provide, evaluate, and improve educational services to pupils with dyslexia. For purposes of this section, 'educational services' means an evidence-based, multisensory, direct, explicit, structured, and sequential approach to instructing pupils who have dyslexia.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("California does not have pre-service legislation related to dyslexia."));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("California does not have in-service legislation related to dyslexia"));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("AB 1369 states, \"Existing law requires all children with disabilities residing in the state, regardless of the severity of their disabilities, and who are in need of special education and related services, to be identified, located, and assessed. Existing law provides that a pupil who is assessed as being dyslexic and meets certain eligibility criteria for the federal Individuals with Disabilities Education Act category of specific learning disabilities is entitled to special education and related services.\" AB 1369 charges the Superintendent with developing guidelines that \"assess pupils with dyslexia, and to plan, provide, evaluate, and improve educational services to pupils with dyslexia. For purposes of this section, 'educational services' means an evidence-based, multisensory, direct, explicit, structured, and sequential approach to instructing pupils who have dyslexia.\""));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("California's SIMR is the proficiency rate on California's statewide examinations in English-language arts and math among SWD who are also ELs, foster youth, and/or students eligible for free and reduced-price meals."));

        }
        [TestMethod]
        public void Colorado()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/colorado");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]/a")).Text.Equals("House Bill 08-1223"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("This bill expands the authority of the Colorado Department of Education such that it is authorized to provide technical assistance related to the screening and education of students with dyslexia. Provisions are not requirements."));
            GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Screening recommendations are described in the state guidelines for identifying students with disabilities.");
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("tr"));
            List<string> text = new List<string> { "State Recognized Screeners","CTOPP-2", "DIBELS 6th Edition", "DIBELS Next", "easyCBM", "TOSCRF", "TOSWRF", "TOWRE-2" };
            int i = 0;
            foreach (IWebElement element in elements)
            {
                Assert.IsTrue(element.Text.Equals(text[i]));
                i++;
            }
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Colorado does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Colorado does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("Colorado does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".field.field-name-field-litearcy-related-simr")).Text.Equals("Colorado's SSIP states, \"Students in first grade who are identified at the beginning of the school year as Well Below Benchmark according to the DIBELS Next Assessment, will significantly improve their reading proficiency as indicated by a decrease in the percentage of students who are identified at the end of the school year as Well Below Benchmark.\" This goal applies to students in 20 project schools discussed in the SSIP."));
           
        }
        [TestMethod]
        public void Connecticut()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/connecticut");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("SB1054, HB7254, Public Act 14-39, Public Act 15-97, Public Act 16-92, and Public Act 17-3"));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[5]")).Text.Equals("Public Act 14-39 defines dyslexia as a specific learning disability and adds dyslexia detection, recognition, and evidenced-based interventions to programming for teacher preparation leading to Certification. PA 15-97 requires the Commissioner of Education to designate an employee to provide information to parents and regional boards of education regarding dyslexia and equates the definition of dyslexia with that in the Department of Education's IEP Manual. The act also sets forth in-service and pre-service training requirements and charges the Department of Education to develop or approve a reading assessment which includes \"identifying, in whole or in part, students at risk for dyslexia . . . or other reading-related learning disabilities.\" PA 16-92 and PA 17-3 set forth training requirements for individuals seeking credentials in remedial reading, remedial language arts, reading consultants, and special education such that applicants must have completed a program of study in the diagnosis and remediation of reading and language arts that includes supervised practicum hours and instruction in the detection and recognition of, and evidence-based structured literacy interventions for, students with dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Universal screening does not seem to be required by law. However, it appears to be Connecticut policy."));
          Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("According to Public Act 14-39, \"On and after July 1, 2006, any program of teacher preparation leading to professional certification shall include, as part of the curriculum, instruction in literacy skills and processes that reflects current research and best practices in the field of literacy training. Such instruction shall (1) be incorporated into requirements of student major and concentration, and (2) on and after July 1, 2015, include the detection and recognition of, and evidence-based interventions for, dyslexia.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("To our knowledge, no law specifically requires professional development related to dyslexia. However, the Connecticut State Department of Education (CSDE) identifies learning opportunities related to dyslexia. Moreover, endorsements in special education and areas related to remedial reading now require supervised practicum hours and instruction in the detection and recognition of, and evidence-based structured literacy interventions for, students with dyslexia. Thus, there is de facto requirement that applicants will have undergone dyslexia training."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[20]")).Text.Equals("Public Act 14-39 does not specifically state that students must receive an intervention based on the results of universal screening. However, CSDE recommends a structured literacy intervention if students are deemed to be at-risk after universal screening."));
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("tr"));
            List<string> text = new List<string> { "Possible Interventions", "Orton-Gillingham", "Multi-Sensory", "Explicit Phonics", "Wilson Language Training Program", "Lindamood Bell Instruction"};
            int i = 0;
            foreach (IWebElement element in elements)
            {
                Assert.IsTrue(element.Text.Equals(text[i]));
                i++;
            }

           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p[1]")).Text.Equals("The SIMR is to \"increase the reading performance of all third-grade students with disabilities statewide, as measured by Connecticut's Approved ESEA Flexibility Performance Index.\""));



        }
        [TestMethod]
        public void Delaware()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/delaware");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Delaware Chapter 300 / Senate Bill 229"));
          Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("SB 229 allows that students with severe dyslexia can waive the state assessment. This bill amends Chapter 1, Title 14 of the Delaware Code such that it is implied that dyslexia is a specific learning disability. (See also: 922 Children with Disabilities Subpart A, Purposes and Definitions). The bill states, \"With respect to any child with a disability who is not beginning to read by age seven, each IEP prepared for such student until that student is beginning to read shall (a) enumerate the specific, evidence-based interventions that are being provided to that student to address the student's inability to read, and (b) provide for evidence-based interventions through extended year services during the summer absent a specific explanation in the IEP as to why such services are inappropriate.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Delaware does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Delaware does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Delaware does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("Delaware does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Delaware's SIMR is to improve literacy proficiency amongst students with disabilities. To achieve this goal, the state aims to use strategies including: implementation science principles and diagnostic assessment. DIBELS and STARS are included as formative measures in the SSIP evaluation plan."));


        }
        [TestMethod]
        public void Florida()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/florida");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB7029, State Board of Education Rule 6A-6.03018, and HB7069"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("HB7029 provides that students with dyslexia are eligible for a scholarship to attend a school other than the one assigned. HB7069 amends several preexisting education laws, some of which are related to literacy and dyslexia. The law allocates funds to provide an additional hour of research-based reading instruction to the 300 lowest performing elementary schools based on state assessment results, as well as certain supplementary objectives (e.g., professional development to provide intervention). Annually, school districts shall submit a K-12 comprehensive reading plan. The plan must describe reading intervention strategies. Statewide kindergarten screening shall provide objective data concerning each student's readiness for kindergarten. Any student in kindergarten through grade 3 who exhibits substantial reading deficiency as determined in paragraph 5(a) must be covered by a federally required plan (e.g., IEP), an individual progress monitoring plan, or both. Parents shall be notified in writing if their child has been identified as having a substantial reading difficulty, and the current and potential options for remediation. The law also eliminates social promotion, except for good cause (e.g., student received intensive reading instruction for 2 or more years); calls for the revision of professional development standards and teacher preparation practices; and sets requirements for core instructional materials."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Under section (11) Students with Reading Deficiencies of HB7029, Florida requires statewide screening in kindergarten that must be used to identify students in need of intervention and support pursuant to FS 1008.25."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("HB7069 amends the uniform core curricula and candidate assessment to include: Scientifically researched and evidence-based reading instructional strategies that improve reading performance for all students, including explicit, systematic, and sequential approaches to teaching phonemic awareness, phonics, vocabulary, fluency, and text comprehension and multi-sensory intervention strategies."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Florida's Department of Education has adjusted its professional development standards and certification and approval requirements such that any applicant for renewal of a professional certificate in any area of certification identified by State Board of Education rule that includes reading instruction or intervention for any students in kindergarten through grade 6, with a beginning validity date of July 1, 2020, or thereafter, must earn a minimum of 2 college credits or the equivalent inservice points in the use of explicit, systematic, and sequential approaches to reading instruction, developing phonemic awareness, and implementing multisensory intervention strategies. Such training must be provided by teacher preparation programs under s. 1004.04 or s. 1004.85 or approved school district professional development systems under s. 1012.98. School districts are required to training for reading coaches, classroom teachers and school administrations in methods of identifying conditions such as dyslexia, instructional techniques that are proven to improve reading performance and using data to make instructional decisions based on individual student needs; and the new the Department's new certification renewal requirements."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("Florida now requires several forms of intervention, including intensive interventions for students in kindergarten through grade 12 identified as having a reading deficiency on the statewide assessment."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Florida's SIMR is to increase the statewide graduation rate of students with disabilities and close the graduation gap."));

        }
        [TestMethod]
        public void Georgia()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/georgia");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("SR743"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Georgia has signed several laws defining and recognizing the importance of dyslexia, as well as its relevance to education."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Georgia does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Georgia does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Georgia does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("Georgia does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Georgia's SIMR is to increase the statewide graduation rate of students with disabilities and close the graduation gap."));


        }
        [TestMethod]
        public void Hawaii()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/hawaii");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Hawaii does not have dyslexia legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Hawaii Senate Bill 2217 authorized the Hawaiian Department of Education to provide technical assistance related to dyslexia, but these provisions were subsequently repealed."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[5]")).Text.Equals("SRC120, passed in 2013, defines dyslexia, and calls for a comprehensive plan that investigates the implementation of the following items: promoting awareness of dyslexia, making available professional development, and requiring a minimum of one reading specialist per school. The law further calls for an evaluation that addresses the percent of students with dyslexia, screening and assessment practices, the amount of time dedicated to core reading instruction, and the number of schools with reading specialists."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("Hawaii does not require screening."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Previous legislation established a committee to investigate support for students with dyslexia in Hawaii. Read more in this report. However, the law does not require screening, and the Hawaiian Department of Education does not address dyslexia screening on its webpage."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("Hawaii does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("Hawaii does not require in-service training related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[18]")).Text.Equals("Hawaii does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Hawaii's SIMR includes: (a) Increase the median growth percentile of 4th Grade students with disabilities with the eligibility category of Specific Learning Disability, Other Health Impairment, and Speech and Language Impairment on the statewide assessment for reading (English Language Arts/Literacy); and (b) Increase the percentage of 3rd grade and 4th grade students with the eligibility category of Specific Learning Disability, Other Health Impairment, and Speech and Language Impairment who are proficient on the statewide assessment for reading (English Language Art/Literacy)."));


        }
        [TestMethod]
        public void Idaho()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/idaho");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Idaho does not have dyslexia legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[6]")).Text.Equals("Idaho does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Idaho does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("Idaho does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("Idaho does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Increase the number of 4th grade students in Idaho who are proficient in literacy as measured by the state summative assessment, currently ISAT by Smarter Balance."));



        }
        [TestMethod]
        public void Illinois()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/illinois");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Public Act 98-0705"));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Synopsis as Introduced: \"Amends the School Code. Requires the State Board of Education to distribute to each school board information on screening instruments available to identify students who exhibit potential indicators of dyslexia and other reading disabilities. Requires a school board to select and implement age-appropriate screening instruments for the early diagnosis of dyslexia and other reading disabilities and to ensure that each kindergarten student enrolled in the school district is screened for dyslexia and other reading disabilities. Requires the State Board to develop and distribute to each school board guidance on appropriate intervention strategies for students diagnosed with dyslexia or other reading disabilities. Provides that, in the event that a student is determined to exhibit potential indicators of dyslexia or another reading disability, the school board shall ensure that the student receives a comprehensive assessment for the learning disorder and, in the event that a diagnosis is confirmed, the school board shall provide appropriate intervention strategies to the student. Sets forth requirements concerning professional development related to reading disabilities, the incorporation of the International Dyslexia Association's definition of dyslexia into administrative rules, and an additional written test for certain educator licensure candidates. Effective immediately.\""));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("As the Illinois State Board of Education (ISBE) website states, \"Public Act 98-0705PDF Document required the State Board of Education, subject to appropriation or the availability of private donations, to establish an advisory group to develop a training module or training modules to provide education and professional development to teachers, school administrators, and other educational professional regarding multi-sensory, systematic, and sequential instruction in reading. Although no funding was appropriated for this advisory group, the Board decided to convene a group of stakeholders to discuss this important topic and review existing programs. The stakeholder group created a 'Reading Intervention Toolkit' based on their reviews. The group encourages schools and districts to utilize the Program and Methods section of the toolkit as a rubric to assess their own interventions and needs in order to provide appropriate targeted reading intervention as determined by screenings/diagnostic assessments and progress monitoring.\" It can be noted that ISBE recommends universal screening three times per year. See Understanding Dyslexia andReading Instruction Best Practices Related to Dyslexia for more information."));
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("tr"));
            List<string> text = new List<string> { "State Recognized Screeners", "CTOPP2", "CORE Graded High Frequency Word Survey", "Family History", "Informal Reading Inventory", "Nonsense Word Fluency", "Oral Reading Fluency", "Phonics Survey", "Phonological Awareness Screener", "Phonics Screener for Intervention", "Phonological Awareness Test-PAT2", "Lexercise Dyslexia Screener", "Really Great Reading Phonics Boost Skill Assessment", "TOSWRF", "TOWRE", "WADE"};
            int i = 0;
            foreach (IWebElement element in elements)
            {
                Assert.IsTrue(element.Text.Equals(text[i]));
                i++;
            }
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Public Act 98-0705 states, \"Beginning on January 1, 2016, in addition to any other requirements set forth by the State Board of Education under Article 21B of this Code, candidates for licensure requesting a preschool through grade 3 endorsement, elementary school endorsement, or reading specialist endorsement shall pass a written test that includes, at a minimum, the following topics: (1) the foundations of teaching reading; (2) the basic rules of phonology, morphology, syntax, and semantics of the English language; (3) the diagnosis of reading difficulties; (4) the development of reading comprehension; and (5) reading assessment. The State Board of Education shall adopt rules to effectuate this subsection (g), including any rules specifying additional topics deemed appropriate for inclusion on the written test.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Beginning on September 1, 2016. The State Board of Education shall, as part of the professional development requirements for public-school teachers, require each public school teacher to complete at least 20 hours of professional development instruction on the screening, intervention, accommodation, and use of technology for students with reading disabilities, including dyslexia, during each 5-year renewal cycle. Beginning in the 2014-2015 school year, the State Board of Education shall provide professional development opportunities related to reading disabilities, including dyslexia, to school district personnel. The professional development must be provided to general education, special education, and English as a second language teachers, instructional support staff, administrators, supervisors, child study team members, and speech and language specialists. The professional development opportunities must be designed to account for the various manners in which different school district personnel interact with or develop instructional programs for students with reading disabilities."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("Illinois does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("The percentage of 3rd-grade students with disabilities who are proficient or above the grade level standard on the state English-language arts assessment will increase."));

        }
        [TestMethod]
        public void Indiana()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/indiana");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB1108 and PL105");
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[5]")).Text.Equals("This law defines dyslexia, states that education service centers may offer training programs on screening for dyslexia and intervention, and that teacher education programs shall include content that prepares candidates to recognize dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Indiana does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("\"A teacher preparation program shall include content within the curriculum that prepares teacher candidates to recognize that a student who is not progressing at a normal rate related to reading may need to be referred to the school's multidisciplinary team to determine the student's special learning needs, including learning needs related to dyslexia.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("Indiana does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[21]")).Text.Equals("Indiana does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p[1]")).Text.Equals("Indiana will increase reading proficiency achievement on Indiana's IREAD-3 assessment by at least .5% each year for third-grade students with disabilities eligible for free/reduced lunch attending elementary schools within the State Development Network Districts."));

        }
        [TestMethod]
        public void Iowa()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/iowa");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("SF2319, SF2196, and Iowa Administrative Code (IAC)"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("SF2319 defines dyslexia, and authorizes technical assistance and professional development related to dyslexia. SF2196 describes literacy requirements for teacher preparation programs."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[5]")).Text.Equals("IAC requires any practitioner seeking a reading endorsement to have 24 semester hours in reading that include the definition of dyslexia; and appropriate interventions, remediation, assistive technology, and accommodations for students with dyslexia. Practitioners must also demonstrate knowledge of signs and symptoms of dyslexia and other reading difficulties; reading theory; various aspects of language development (e.g., phonological awareness, morphology) and the ability to integrate literacy instruction into content areas for subgroups of students, including students with dyslexia. IAC also outlines teacher preparation requirements related to dyslexia, and requirements for an elementary school teaching endorsement, the latter of which requires 9 training hours in areas including but not limited to phonemic awareness, and the assessment and diagnosis of student literacy, including the signs and symptoms of dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("Iowa does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Iowa Administrative Code now has various dyslexia-related training requirements for practitioners. Specific requirements vary by practitioner type."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("Iowa does not have in-service legislation related to dyslexia. However, individuals seeking endorsements in specific areas such as reading will need to complete dyslexia-specific training."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]")).Text.Equals("Iowa's SIMR is to increase the percent of third-grade readers that are proficient by the end of third grade."));


        }
        [TestMethod]
        public void Kansas()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/kansas");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Kansas does not have dyslexia legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Kansas does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Kansas does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("Kansas does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("According to the SSIP, the percentage of students with disabilities who score at grade level benchmark on AIMSweb reading assessment for Kindergarten through 5th grades in the targeted buildings will increase to 37.50% by 2018."));


        }
        [TestMethod]
        public void Kentucky()
        {

            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/kentucky");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB69 and HB307"));
            GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("KRS Chapter 158 defines \"dyslexia,\" \"phonemic awareness,\" and \"scientifically based research\". It requires the Kentucky Board of Education to promulgate regulations and technical assistance for district-wide reporting on the use of K-3 response-to-intervention implementation in reading by August 1, 2013. HB307 (not yet ratified) establishes additional screening, multisensory intervention, teacher preparation, professional development and technical assistance authorizations and requirements.");
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Kentucky does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Kentucky does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Kentucky does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("Kentucky does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("Kentucky law 158.305 requires the Kentucky Department of Education to provide technical assistance on response to intervention and dyslexia. However, intervention is not required by law."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("The SSIP states, \"To increase the percentage of students with disabilities performing at or above proficient in middle school math, specifically at the 8th grade level, with emphasis on reducing novice performance, by providing professional learning, technical assistance and support to elementary and middle school teachers around implementing, scaling and sustaining evidence-based practices in math\"."));


        }
        [TestMethod]
        public void Louisiana()
        {

            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/louisiana");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]/a")).Text.Equals("Louisiana Title 28 Education Part XXXV"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Unlike most states, Louisiana has had state law on dyslexia since at least the 1990s. Current policies are the culmination of a piecemeal process too lengthy to describe in detail here. Most provisions are described under Title 28 of Louisiana's Laws."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Every public-school student in grades kindergarten through third should be screened at least once for the existence of impediments to a successful school experience, unless objected to by his or her parents. Such impairments include: dyslexia and related disorders; attention deficit disorder; social and environmental factors that may put a child at risk. At any time outside of grade level screenings, students may also be screened if referred to the SBLC and the committee deems such screening to be appropriate."));
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("tr"));
            List<string> text = new List<string> { "State Recognized Screeners", "AIMSweb", "DIBELS 6th Edition", "DIBELS Next", "STAR", "STEEP Advanced Literacy", "Fontas and Pinnell Initial Sounds", "Phonograms", "Oral Reading Rate, and Reading Comprehension", "FAST", "SRI", "HMH", "STEP", "See also Louisiana Title 28 which lists additional screeners.", "Possible Interventions", "Alphabetic Phonics", "Intermediate Essential Language Structures Program", "Language!", "Language Circle", "Slingerland", "Wilson Language Training" };

            int i = 0;
            foreach (IWebElement element in elements)
            {
                Assert.IsTrue(element.Text.Equals(text[i]));
                i++;
            }
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Louisiana does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Screening specialists require 18 clock hours of training in the following areas: characteristics of ADHD; characteristics of dyslexia; characteristics of social and emotional Risk Factors; use of appropriate screening instruments; administration and interpretation of LEA-selected screening instruments; operation and administration of building-level committee; selection of classroom strategies, accommodations, and modifications; and child advocacy. See Title 28, which describes the guidelines and regulations concerning the implementation of Louisiana's dyslexia law for details: Title 28 Education"));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("The law states, \"In accordance with the program adopted by the board, the city and parish school boards shall provide remediation for children with dyslexia or related disorders in an appropriate multi-sensory, intensive phonetic, synthetic to analytic phonics, linguistic, meaning based, systematic, language-based regular education program. For those students who are not dyslexic and who do not qualify for special education services, other appropriate programs shall be offered to remediate their particular physical or educational disorders.\""));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Louisiana's SiMR is \"to increase English Language Arts proficiency (basic and above) rates on statewide assessments for students with disabilities in third through fifth grades, in nine Local Education Agencies across the state.\""));


        }
        [TestMethod]
        public void Maine()
        {
            
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/maine");
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("tr"));
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Maine HP016301 and LD231"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("HP016301 defines dyslexia, requires screening, and establishes a dyslexia consultant at the department of education."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("As Maine Department of Education states, Maine law 20-A M.S.R. 4701-B requires school administrative units to screen students in kindergarten through second grade who have difficulty in these areas: A. Phonological and phonemic awareness; B. Sound-symbol recognition; C. Alphabet knowledge; D. Decoding skills; E. Rapid naming skills; and F. Encoding skills. However, the Maine Department of Education recommends universal screening for all students in kindergarten through second grade."));
            List<string> text = new List<string> { "State Recognized Screeners", "AIMSweb", "DIBELS 6th Edition", "easyCBM", "PALS-K", "Test of Written Spelling-5", "FAR", "PAR", "RAN/RAS. Fastbridge Learning", "Shaywitz Dyslexia Screener"};

            int i = 0;
            foreach (IWebElement element in elements)
            {
                Assert.IsTrue(element.Text.Equals(text[i]));
                i++;
            }
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Maine does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("March 1, 2016, and updated annually thereafter a plan that: A. Implements dyslexia awareness training for teachers; B. Implements professional development in evidence-based screening practices; and C. Identifies needs of school administrative units for implementing evidence-based practices and response to scientific, research-based intervention strategies for reading and language-based learning difficulties."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[18]")).Text.Equals("Maine law 20-A M.S.R. 4701-B does not specifically require intervention based on screening results. However, the Dyslexia Coordinator created by the law shall \"assist the department in complying with the provisions of this section and the general education interventions required in the department's special education rules as they pertain to students struggling with reading or showing early indicators of reading difficulty.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Students with disabilities in grades 3-8 will demonstrate improved math proficiency as measured by math scores on the State assessment in a subset of schools wherein the total student population demonstrates proficiency at or above the State average but where substantial achievement gaps (15-32 points) exist between students with disabilities and their general education peers."));


        }
        [TestMethod]
        public void Maryland()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/maryland");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Maryland HB278 and HB 1264"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[5]")).Text.Equals("These bills establish committees to study dyslexia education in Maryland, and to develop plans of action."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Maryland does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Maryland does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("Maryland does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[21]")).Text.Equals("Maryland does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[23]")).Text.Equals("The state provides Local Priority Flexibility Funds to each local school system to apply to locally driven student performance work. Several local school systems have used these funds to support the training of teachers and to create a trainer of trainer model for structured literacy."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p[1]")).Text.Equals("The Maryland Part B State-identified Measurable Result (SIMR) is to increase the mathematics proficiency of students with disabilities in grades 3-5 in six (6) LSSs."));




        }
        [TestMethod]
        public void Massachusetts()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/massachusetts");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Massachusetts does not have dyslexia legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[6]")).Text.Equals("Massachusetts does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Massachusetts does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("Massachusetts does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("Massachusetts does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("The SSIP states that, \"Massachusetts Part C/Early Intervention (EI) system will focus its efforts on improving the statewide percentage of children showing positive growth in Child Outcome 1: social-emotional skills (including social relationships), as measured by Summary Statement 1 in the State's Performance Plan.\""));


        }
        [TestMethod]
        public void Michigan()
        {

            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/michigan");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Michigan does not have dyslexia legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[6]")).Text.Equals("Michigan does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Michigan does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("Michigan does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("Michigan does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("The SIMR is to improve the percent of K-3 students with an Individualized Education Program (IEP) in participating schools who achieve benchmark status in reading as defined by a Curriculum Based Measurement."));



        }
        [TestMethod]
        public void Minnesota()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/minnesota");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("120B.12"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("This law contains provisions concerning the identification of reading difficulties, parent involvement and notification, intervention, staff development, local literacy plans, and assessment."));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("According to Subd. 2 (Identification; report) of Minnesota statutes, \"(a) Each school district shall identify before the end of kindergarten, grade 1, and grade 2 students who are not reading at grade level before the end of the current school year and shall identify students in grade 3 or higher who demonstrate a reading difficulty to a classroom teacher. Reading assessments in English, and in the predominant languages of district students where practicable, must identify and evaluate students' areas of academic need related to literacy. The district also must monitor the progress and provide reading instruction appropriate to the specific needs of English learners. The district must use a locally adopted, developmentally appropriate, and culturally responsive assessment and annually report summary assessment results to the commissioner by July 1. The district also must annually report to the commissioner by July 1 a summary of the district's efforts to screen and identify students with: (1) dyslexia, using screening tools such as those recommended by the department's dyslexia and literacy specialist\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("See the state department of education website for current information on screeners."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Minnesota does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("According to state law, Each district shall use the data under subdivision 2 to identify the staff development needs so that: (1) elementary teachers are able to implement comprehensive, scientifically based reading and oral language instruction in the five reading areas of phonemic awareness, phonics, fluency, vocabulary, and comprehension as defined in section 122A.06, subdivision 4, and other literacy-related areas including writing until the student achieves grade-level reading proficiency; (2) elementary teachers have sufficient training to provide comprehensive, scientifically based reading and oral language instruction that meets students' developmental, linguistic, and literacy needs using the intervention methods or programs selected by the district for the identified students; (3) licensed teachers employed by the district have regular opportunities to improve reading and writing instruction; (4) licensed teachers recognize students' diverse needs in cross-cultural settings and are able to serve the oral language and linguistic needs of students who are English learners by maximizing strengths in their native languages in order to cultivate students' English language development, including oral academic language development, and build academic literacy; and (5) licensed teachers are well trained in culturally responsive pedagogy that enables students to master content, develop skills to access content, and build relationships."));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("According to state law, \"For each student identified under subdivision 2, the district shall provide reading intervention to accelerate student growth and reach the goal of reading at or above grade level by the end of the current grade and school year. District intervention methods shall encourage family engagement and, where possible, collaboration with appropriate school and community programs. Intervention methods may include, but are not limited to, requiring attendance in summer school, intensified reading instruction that may require that the student be removed from the regular classroom for part of the school day, extended-day programs, or programs that strengthen students' cultural connections.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Minnesota's SIMR is to improve graduation rates for Black and American Indian students."));



        }
        [TestMethod]
        public void Mississippi()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/mississippi");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB 1031, HB950, and HB1046"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("This law establishes the Mississippi dyslexia therapy scholarship; defines dyslexia; requires that all compulsory-school-age children be screened for dyslexia during the period between the spring of kindergarten and the fall of grade 1 and other appropriate times as deemed necessary; requires that students receive comprehensive academic evaluations by trained diagnosticians in the diagnosis of dyslexia if screening indicates risk of dyslexia; requires the Department of Education to submit an annual report to the legislature summarizing student performance, student assessments, funding and any recommended changes; and prescribes dyslexia qualifications for administrative and instructional personnel."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("According to HB 1031, (1) \"(a) Each local school district shall adopt a policy to ensure that students will be screened in the Spring of kindergarten and the Fall of Grade 1. The component of the screening must include: (i) Phonological awareness and phonemic awareness; (ii) Sound symbol recognition; (iii) Alphabet knowledge; (iv) Decoding skills; (v) Encoding skills; and (vi) Rapid naming. (b) If a student fails the screener, the parent or legal guardian will be notified of the results of the screener. Subsequent dyslexia evaluations may be administered by licensed professionals, including: (i) Psychologists, licensed under Chapter 31, Title 73, Mississippi Code of 1972; (ii) Psychometrists, licensed by the Mississippi Department of Education; (iii) Speech Language Pathologists, licensed under Chapter 38, Title 73, Mississippi Code of 1972. (c) If a student fails the screener, the school district, in its discretion, may perform a comprehensive dyslexia evaluation, such evaluation must be administered by any of the licensed professionals identified under paragraph (b) of this subsection. (d) If a parent or legal guardian of a student who fails the dyslexia screener exercises the option to have a subsequent evaluation performed, such evaluation shall be administered by any of the licensed professionals identified under paragraph (b) of this subsection, and the resulting diagnosis of the subsequent evaluation must be accepted by the school district for purposes of determining eligibility for placement within a dyslexia therapy program within the current school or to receive a Mississippi Dyslexia Therapy Scholarship for placement in a dyslexia program in another public school or nonpublic special purpose school.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("Visit the state department of education website for up-to-date information about screeners."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Mississippi does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("Mississippi does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("The Mississippi Department of Education (MDE) notes that training is required for dyslexia specialists, but such training is not required by law. For general recommendations, see: Mississippi Best Practices Dyslexia Handbook"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[18]")).Text.Equals("Mississippi does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[19]")).Text.Equals("Though not required by state law, interventions should be multisensory, systematic, specific language-based instructional programs. See the MDE handbook for details."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("The SSIP states that Mississippi will increase the percentage of third-grade students with Specific Learning Disability and Language/Speech rulings in targeted districts who score proficient or higher on the regular statewide reading assessment to 68 percent by FFY 2018."));


        }
        [TestMethod]
        public void Missouri()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/missouri");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]/a")).Text.Equals("Missouri SB 638"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Senate Bill 638 requires the Department of Elementary and Secondary Education to develop guidelines for the appropriate screening of students for dyslexia and related disorders and to develop the necessary classroom support for such students. It also defines dyslexia and creates in-service requirements."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("By December 31, 2017, the Department of Elementary and Secondary Education shall develop guidelines for the appropriate screening of students for dyslexia and related disorders and the necessary classroom support for students with dyslexia and related disorders. Such guidelines shall be consistent with the findings and recommendations of the task force created under section 633.420.6. In the 2018-19 school year and subsequent years, each public school, including each charter school, shall conduct dyslexia screenings for students in the appropriate year consistent with the guidelines developed by the Department of Elementary and Secondary Education."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("Please visit the state department of education website for a list of current screeners."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Missouri does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("The Dyslexia Taskforce created by HB 2378 is to develop in-service and preservice activities to address dyslexia identification and intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("In the 2018-19 school year and subsequent years, the practicing teacher assistance programs established under section 168.400 shall offer two hours of in-service training, provided by each local school district for all practicing teachers in such district, regarding dyslexia and related disorders. Each charter school shall also offer all of its teachers two hours of training on dyslexia and related disorders. Districts and charter schools may seek assistance from the Department of Elementary and Secondary Education in developing and providing such training. Completion of such training shall count as two contact hours of professional development under section168.021n for teachers."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[21]")).Text.Equals("Missouri does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[23]")).Text.Equals("HB 2379 creates a Dyslexia Taskforce that shall create regulations regarding screening and intervention. Moreover, it shall \"recommend an evidence-based reading instruction, with consideration of the National Reading Panel Report and Orton-Gillingham methodology principles for use in all Missouri schools, and intervention system, including a list of effective dyslexia intervention programs, to address dyslexia or characteristics of dyslexia for use by schools in multi-tiered systems of support and for services as appropriate for special education eligible students.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p[1]")).Text.Equals("Missouri's SSIP states that the SIMR is to \"increase the percent of students with disabilities in tested grades who will perform at proficiency levels on state assessments in reading/language arts and mathematics in the Collaborative Work pilot schools by 6.5 percentage points by 2018.\""));

        }
        [TestMethod]
        public void Nebraska()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/nebraska");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Nebraska LB645"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[5]")).Text.Equals("Nebraska LB645 defines dyslexia to reflect the National Institute of Child Health and Human Development (NICHD) definition."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Nebraska does not have dyslexia screening legislation."));
            GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Nebraska's Technical Assistance Manual on Dyslexia states, \"Screening should take place at the beginning of each school year in kindergarten through grade 2. Schools should use measures that are efficient, reliable, and reasonably valid. For students who are at risk for reading difficulties, progress in reading and reading related-skills should be monitored on a monthly or even weekly basis to determine whether students are making adequate progress or need additional support. Because available screening measures, especially in kindergarten and grade 1, are imperfect, schools are encouraged to conduct a second screening mid-year.\"");
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("Nebraska does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[19]")).Text.Equals("Nebraska does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[23]")).Text.Equals("Nebraska does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p[1]")).Text.Equals("Narrow the gap between the reading proficiency rates of students with disabilities and the general education students at 3rd grade."));

        }
        [TestMethod]
        public void Nevada()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/nevada");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Nevada AB 341");
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("This law requires accountability reports to include the results of early literacy screening assessments. It also requires each school district and charter school to administer screening assessments and to provide dyslexia therapy and the accommodations or modifications required by federal law to a pupil with dyslexia. Finally, it requires each school district to employ certain professionals with training in dyslexia; and the Department of Education to prepare and publish a Dyslexia Resource Guide."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("State law requires the board of trustees of each school district and the governing body of each charter school that serves pupils in kindergarten or grade 1, 2 or 3 to prescribe an early literacy screening assessment for use by the schools located in the school district or the charter school, respectively. The early literacy screening assessment prescribed must include screening for: (a) Phonological and phonemic awareness; (b) Sound-symbol recognition; (c) Alphabet knowledge; (d) Decoding skills; (e) Rapid naming skills; and (f) Encoding skills."));
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("tr"));
            List<string> text = new List<string> { "State Recognized Screeners", "AIMSweb", "Abecedarian Reading Assessment", "Arkansas Rapid Naming Screener", "DIBELS Next", "FCRR's OPM Oral Reading Fluency (Grades 1 - 5)", "Gentry Developmental Test of Spelling", "Houghton Mifflin phonics/decoding screening test", "Phonemic Awareness Screener Assessment"};
            int i = 0;
            foreach (IWebElement element in elements)
            {
                Assert.IsTrue(element.Text.Equals(text[i]));
                i++;
            }
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Nevada does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("At least one employee in each school must be trained to (1) recognize indicators of dyslexia, and (2) the science related to teaching pupils with dyslexia. Professional development must be provided by learning strategies, and may be provided through online training."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("Section 9 of AB341: (1) requires each school district and charter school to administer screenings for dyslexia to certain pupils in certain grade levels; and (2) requires a school district and charter school to address the needs of a pupil if the screening confirms that a pupil has indicators for dyslexia through the response to scientific, research-based intervention system of instruction. Intervention should be systematic, multi-sensory, and offered in an appropriate setting that is derived from a research evidence-base."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("The Nevada Department of Education will improve the performance of third-grade students with disabilities in Clark County School District on statewide assessments of reading/language arts through building the school district's capacity to strengthen the skills of special education teachers in assessment, instructional planning, and teaching."));

        }
        [TestMethod]
        public void NewHampshire()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/new-hampshire");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB 1644-FN"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("HB 1644 defines dyslexia and describes requirements related to the screening and treatment for dyslexia. It also establishes a reading specialist in the state department of education."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("According to HB 1644-FN, \"All students, including English for speakers of other languages students, enrolling in New Hampshire's public schools shall be screened using the Dynamic Indicators of Basic Early Literacy Skills (DIBELS) or an equivalent cost effective screener for the identification of characteristics that are associated with risk factors for dyslexia, related disorders, dyscalculia, and dysgraphia upon entering kindergarten or first grade, and at appropriate times thereafter, to monitor progress. The screening required by this section shall begin no later than January 1, 2018.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("The New Hampshire resource guide describes AIMSweb Plus, PALS-K, PALS 1-3, DIBELS NEXT, and Star. See the resource guide for grade-level guidance."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("The reading specialist and the council for teacher education established in RSA 190 shall collaborate to ensure that all teacher education programs offered at New Hampshire's public institutions of higher education provide explicit professional awareness of best practices on: (a) Recognition of characteristics of dyslexia, related disorders, dyscalculia, and dysgraphia and (b) Evidence-based interventions and accommodations for dyslexia, related disorders, dyscalculia, and dysgraphia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("No later than September 1, 2017, the reading specialist shall develop and make available a program to ensure all New Hampshire teachers and school administrators have access to materials to support professional awareness of best practices on: (a) Recognition of the characteristics of dyslexia, related disorders, dyscalculia, and dysgraphia; and (b) Evidence-based interventions and accommodations for dyslexia, related disorders, dyscalculia, and dysgraphia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("New Hampshire law states, \"In the event that a diagnosis of dyslexia or other reading disability is confirmed by the comprehensive assessment, the board of education shall provide appropriate evidence-based intervention strategies to the student, including intense instruction on phonemic awareness, phonics and fluency, vocabulary, and reading comprehension.\""));
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("tr"));
            List<string> text = new List<string> { "Possible Interventions", "Orton Gillingham", "Wilson Reading System", "LETRS", "Project Read" };
            int i = 0;
            foreach (IWebElement element in elements)
            {
                Assert.IsTrue(element.Text.Equals(text[i]));
                i++;
            }
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("New Hampshire's SIMR focuses on the social-emotional skills of preschool children with disabilities."));

        }
        [TestMethod]
        public void NewJersey()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/new-jersey");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("New Jersey Chapter 105, New Jersey Chapter 131, and New Jersey Chapter 210"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("New Jersey Law Chapter 210 supplements Chapter 40 of Title 18A by tasking the Commissioner of Education with providing technical assistance to each board of education regarding the screening and treatment of dyslexia. It also tasks each board of education with screening all students for dyslexia by the end of the first semester of second grade. Related requirements are discussed."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("According to New Jersey statute, \"A board of education shall ensure that each student enrolled in the school district who has exhibited one or more potential indicators of dyslexia or other reading disabilities is screened for dyslexia and other reading disabilities using a screening instrument selected pursuant to section 2 of this act no later than the student's completion of the first semester of the second grade.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("Please refer to the state resource guide for guidance on selecting screeners."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("New Jersey does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("PL2013, c. 105 requires a minimum of two hours of professional development each year for general education; kindergarten-grade 3; special education; learning disabilities teacher consultants; and speech-language specialists. The professional development must be on screening, intervention, accommodation, and use of technology for students with disabilities, including dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("In the event that a diagnosis of dyslexia or other reading disability is confirmed by the comprehensive assessment, the board of education shall provide appropriate evidence-based intervention strategies to the student, including intense instruction on phonemic awareness, phonics and fluency, vocabulary, and reading comprehension."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]")).Text.Equals("The SIMR is to improve graduation rates."));


        }
        [TestMethod]
        public void NewMexico()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/new-mexico");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB 2010 and HB 230"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("New Mexico House Bill 230 defines dyslexia, provides for the screening and intervention of students with dyslexia, and describes the requirements for the state department of education and local school districts concerning professional development related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("New Mexico does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("New Mexico does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("HB230 requires the New Mexico Department of Education to recommend professional development material for teachers and administrators regarding dyslexia, and it shall adopt the necessary rules and standards to do so. Further, local school districts are required to ensure that every teacher and administrator who teaches reading is trained to provide and implement appropriate research-based reading intervention; and that special education teachers can provide appropriate specialized reading instruction."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("New Mexico law states, \"In accordance with department response to intervention procedures, guidelines and policies, each public school district shall provide timely, appropriate, systematic, scientific, research-based interventions recommended by the student assistance team, with progress monitoring to determine the student's response or lack of response, for a student in the secondary tier of response to intervention who meets the criteria in Subsection A of this section prior to referring the student for a special education evaluation.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("New Mexico's SIMR states that by the federal fiscal year 2018, 47.8% of students with disabilities in Results Driven Accountability schools will score benchmark on the End of Year DIBELS-Next Composite."));


        }
        [TestMethod]
        public void NewYork()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/new-york");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Bill 8262 required the Commissioner of Education to issue a guidance memorandum to every school district and board of cooperative educational services to inform them of the unique educational needs of students with dyslexia, dyscalculia, and dysgraphia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("New York does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("New York does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("New York does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("New York does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("New York's SIMR is to \"Increase the percentage of students with disabilities who score at proficiency levels 2 and above on the grades 3-8 ELA State Assessment (including  students who take the regular ELA State Assessment with or without accommodations  and  students who take the New York State Alternate Assessment).”"));

        }
        [TestMethod]
        public void NorthCarolina()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/north-carolina");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB149"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("North Carolina HB 149 defines dyslexia, describes professional development requirements, and charges local education boards with reviewing screening and diagnostic use."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("According to HB149, \"Prior to the start of the 2017-2018 school year, local boards of education shall review the diagnostic tools and screening instruments used for dyslexia, dyscalculia, or other specific learning disabilities to ensure that they are age-appropriate and effective and shall determine if additional diagnostic and screening tools are needed.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("North Carolina does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("According to HB 149, Prior to the start of the 2017- 2018 school year, the State Board of Education shall ensure that ongoing professional development opportunities are made available to teachers and other school personnel on the identification of and intervention strategies for students with dyslexia, dyscalculia, or other specific learning disabilities. Prior to the start of the 2017-2018 school year, the State Board of Education shall also develop and make available. Information electronically to parents, educators, and other concerned groups that provides further data concerning characteristics of children with dyslexia, educational methodologies, screenings, and what is available to support the work with children with dyslexia in North Carolina."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("North Carolina does not have intervention legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("North Carolina's SIMR focuses on graduation rates."));


        }
        [TestMethod]
        public void NorthDakota()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/north-dakota");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("North Dakota does not have dyslexia legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[6]")).Text.Equals("North Dakota does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("North Dakota does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("North Dakota does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("North Dakota does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("North Dakota's SIMR focuses on improving graduation rates for subgroups of students."));



        }
        [TestMethod]
        public void Ohio()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/ohio");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB96 and HB157"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Ohio HB 157 authorizes professional development related to dyslexia and a dyslexia specialist. HB 96 amends section 3323.01 of Ohio law and enacts section 3323.25 which defines dyslexia, and which requires a pilot project to provide early screening and intervention services for children with risk factors for dyslexia. Statutes related to dyslexia can be found at: Ohio Laws and Rules."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Ohio does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("According to 3323.25, \"The superintendent of public instruction shall establish a pilot project to provide early screening and intervention services for children with risk factors for dyslexia, including low phonemic awareness. The state superintendent shall select three school districts to participate in the pilot project, one of which shall be located in an urban setting, one of which shall be located in a suburban setting, and one of which shall be located in a rural setting. Any school district selected to participate in the pilot project may establish a partnership with a regional library or library system for purposes of the pilot project. To be considered for the pilot project, a school district shall submit a proposal to the state superintendent that identifies a method of screening children for low phonemic awareness and other risk factors for dyslexia, provides for the enrollment of children identified as having risk factors for dyslexia in a reading program staffed by teachers trained in multisensory structured language programs, and includes a methodology for evaluating the effects of the reading program on the children's identified risk factors. The pilot project shall operate for three full school years, beginning with the school year that begins at least three months after the effective date of this section. The goal of the pilot project shall be to demonstrate and evaluate the effectiveness of early reading assistance programs for children with risk factors for dyslexia and to evaluate whether those programs can reduce future special education costs.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Ohio does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("Ohio does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("Ohio does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Ohio's SIMR aims to improve the (a) the percentage of possible points awarded on the state Report Card system for meeting targets related to third grade reading for students with disabilities, and (b) the \"percentage of all kindergarten through third grade students who are on track for literacy, as measured by state reading diagnostic assessments.\" Specific objectives vary by year."));


        }
        [TestMethod]
        public void Oklahoma()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/oklahoma");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB390 and §_70-7001"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("HB 390 creates a scholarship to attend a private school of the recipient's choice. §_70-7001 creates a dyslexia pilot program."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Oklahoma does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Oklahoma does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Oklahoma does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("Oklahoma does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Oklahoma's SIMR was, \"By FFY 2018, Oklahoma will see improved early literacy performance in specific districts in Tulsa County among students with disabilities taking the 3rd grade annual reading assessment. The passing rate (proficiency or above) in Tulsa County will increase from 20 percent to at least 30 percent in FFY 2018. Participating districts will also realize statistically significant improvement in the rate of growth toward proficiency among these students.\" This SIMR is scheduled to be updated this year."));

        }
        [TestMethod]
        public void Oregon()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/oregon");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("SB612, SB1003, and HB2412"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Directs the Oregon Department of Education to develop a plan to provide dyslexia screening and guidance for parental notification. Requires school districts to ensure that at least one kindergarten through grade five teacher per kindergarten through grade five school receives training related to dyslexia. Allows school districts to receive funding for training through Network of Quality Teaching and Learning. Declares an emergency, effective on passage."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("SB612 requires that the Oregon Department of Education develop a plan for universal screening. SB1003 specifically requires that public school students are screened in kindergarten and first grade. Screeners must be cost-effective and account for phonological awareness, rapid naming skills, the correspondence between sound and letter, and family history."));
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("tr"));
            List<string> text = new List<string> { "State Recognized Screeners", "AIMSweb", "DIBELS 6th Edition", "DIBELS Next", "easyCBM" };
            int i = 0;
            foreach (IWebElement element in elements)
            {
                Assert.IsTrue(element.Text.Equals(text[i]));
                i++;
            }
            Assert.IsTrue(GCDriver.FindElement(By.Id("docs-internal-guid-581a5787-5aa6-e41b-3ecd-524260333148")).Text.Equals("SB612 states, \"Each school district shall ensure that at least one kindergarten through grade five teacher in each kindergarten through grade five school has received training related to dyslexia. The training must comply with the requirements described in subsection (3) of this section. (5)(a) A school district that does not comply with the requirements of this section and that does not secure a waiver from the department within the time required by the State Board of Education by rule is considered nonstandard under ORS 327.103. SB1003 further requires the Department of Education to annually develop a list of dyslexia training opportunities."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("ORS 342.147 requires the adoption of standards for instruction on dyslexia that are aligned with the International Dyslexia Association. The requirement applies to endorsement areas that include a significant focus on reading instruction: Elementary Education-Multiple Subjects, English to Speakers of Other Languages, Reading Intervention and Special Education: Generalist endorsements. The purpose of the dyslexia instruction standards is to provide educators with the knowledge and pedagogy skills that best serve students with dyslexia and other learning disabilities."));
            //GCDriver.FindElement(By.XPath("//*[@id='docs -internal-guid-581a5787-5aa6-e41b-3ecd-524260333148']")).Text.Equals("SB612 states, \"Each school district shall ensure that at least one kindergarten through grade five teacher in each kindergarten through grade five school has received training related to dyslexia.The training must comply with the requirements described in subsection(3) of this section. (5)(a) A school district that does not comply with the requirements of this section and that does not secure a waiver from the department within the time required by the State Board of Education by rule is considered nonstandard under ORS 327.103.SB1003 further requires the Department of Education to annually develop a list of dyslexia training opportunities.");
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("Oregon does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("According to SB612, the Oregon Department of Education must identify training opportunities that will enable teachers to recognize dyslexia and to provide systematic, explicit, and evidence-based instruction. Districts must ensure that each K-5 school has at least one K-5 teacher who has received such a training."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Oregon's SIMR is to \"increase the percentage of third-grade students with disabilities reading at grade level, as measured by state assessment.\""));
        }
        [TestMethod]
        public void Pennsylvania()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/pennsylvania");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Act 69 (24 P.S. Article XVII-C)"));
           GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Act 69 provides for a pilot program for dyslexia screening and intervention.");
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Pennsylvania does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("Act 69 created a dyslexia pilot program, but screening is not required by law."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Pennsylvania does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("Pennsylvania does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("Pennsylvania does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]")).Text.Equals("Pennsylvania's SIMR focuses on graduation and drop-out rates."));
            

        }
        [TestMethod]
        public void PuertoRico()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/puerto-rico");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Puerto Rico does not have dyslexia legislation."));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[6]")).Text.Equals("Puerto Rico does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Puerto Rico does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("Puerto Rico does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("Puerto Rico does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Puerto Rico Department of Eduction's SIMR is to increase the percentage (%) of special education students in the 6th grade who score proficient or advanced on the regular assessment for math in the selected schools in the Yabucoa School District."));

            

        }
        [TestMethod]
        public void RhodeIsland()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/rhode-island");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]/a")).Text.Equals("H7052"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[5]")).Text.Equals("H7052 defines dyslexia and describes screening and intervention requirements related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("All school districts that provide elementary education are required to screen all children prior to, or upon, their first entry to school to determine their level of educational readiness. All children are required to participate in this screening. Screening shall address the child's educational development and shall be used to determine whether he or she is educationally disadvantaged in terms of readiness for instruction in the literacy skills of reading, writing, speaking, listening, or mathematics."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("See the state department of education website for guidance on selecting screeners."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Rhode Island does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("Rhode Island does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[19]")).Text.Equals("However, state law states that \"The literacy program shall also include assistance to students by providing strategies that formally address dyslexia, when appropriate. In addition, the department of elementary and secondary education shall offer to school districts, at no cost to the school district or to participants in the training, professional development services to enhance the skills of elementary teachers in the use of evidence-based strategies to improve the literacy skills of students with dyslexia.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[23]")).Text.Equals("Law states, \"The commissioner of elementary and secondary education shall stipulate for each school district the specific cutoff points and the grades for required service each year. Services must be provided first to students who are most educationally disadvantaged. Services shall focus on instruction in reading, writing, speaking, listening, and mathematics. Program emphasis shall be as follows: (A) Intensive development in literacy. Kindergarten through grade three (3). (B) Early intervention in literacy. Grades four (4) through six (6) (C) Remediation in literacy. Grades seven (7) through eight (8). (D) Intensive remediation in literacy. Grades nine (9) through twelve.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p[1]")).Text.Equals("Rhode Island's SIMR focuses on improving math proficiency."));


        }
        [TestMethod]
        public void SouthCarolina()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/south-carolina");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("H.5024"));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("H.5024 requires that before the 2016-2017 school year, \"the state department of education shall provide all literacy coaches and literacy teachers in kindergarten through third grade with training on dyslexia and related disorders, including evidence-based screenings, instructional methods, and interventions, among other things; and to impose related reporting requirements on the department.\""));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("South Carolina does not have screening legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("South Carolina does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("State law states that 1. Before the beginning of the 2016-2017 school year, the State Department of Education shall provide training to all literacy coaches and literacy teachers in kindergarten through grade three on: (1) dyslexia and related reading disorders and their prevalence, using the internationally accepted definition from the International Dyslexia Association; (2) the use of evidence-based screening tools for dyslexia and other reading disorders that are age-appropriate and evaluate, as appropriate, the following skills: (a) phonological and phonemic awareness; (b) sound symbol recognition; (c) alphabet knowledge; (d) decoding and encoding skills; and (e) rapid naming skills; and (3) evidence-based, multi-sensory, instructional methods and interventions designed specifically for students with dyslexia and other reading disorders."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("South Carolina does not have intervention legislation related to dyslexia."));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("South Carolina's SIMR is: \"For students with disabilities in grade three, South Carolina will increase the percentage of students who are deemed proficient or higher on the statewide reading accountability assessment in select districts with the largest average achievement gaps as determined by the ESEA waiver (i.e., those districts with focus or priority schools).\""));




        }
        [TestMethod]
        public void SouthDakota()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/south-dakota");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("South Dakota does not have dyslexia legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[6]")).Text.Equals("South Dakota does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("South Dakota does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("South Dakota does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("South Dakota does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("South Dakota's SIMR is to raise reading proficiency amongst students with specific learning disabilities."));

        }
        [TestMethod]
        public void Tennessee()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/tennessee");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("HB2635, HB1735/SB2002, and PC1058"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Public Chapter 1058 tasks the state department of education with developing procedures and regulations related to the screening and intervention of dyslexia. Related requirements (including professional development requirements) are also discussed."));
          Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("According to PC1058, \"The dyslexia screening procedures shall include phonological and phonemic awareness, sound-symbol recognition, alphabet knowledge, decoding skills, rapid naming, and encoding skills. (3) The dyslexia screening procedures shall be implemented by every LEA. (4) Dyslexia screening may be requested for any student by the student's parent or guardian, teacher, counselor, or school psychologist.\""));
            IList<IWebElement> elements = GCDriver.FindElements(By.CssSelector("tr"));
            List<string> text = new List<string> { "State Recognized Screeners", "AIMSweb", "CTOPP-2y", "Developmental Spelling Analysis", "DIBELS 6th Edition", "DIBELS Next", "easyCBM", "PALS-K", "PASS", "RAN/RAS", "TOWRE-2", "WIST" };
            int i = 0;
            foreach (IWebElement element in elements)
            {
                Assert.IsTrue(element.Text.Equals(text[i]));
                i++;
            }
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Tennessee does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("Tennessee does not have in-service legislation related to dyslexia."));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("State law states that \"(c) If the dyslexia screening conducted by the LEA indicates that a student has characteristics of dyslexia, the LEA shall: (1) Notify the student's parent or legal guardian; (2) Provide the student's parent or legal guardian with information and resource material regarding dyslexia; (3) Provide the student with appropriate tiered dyslexia-specific intervention through its RTl framework; and (4) Monitor the student's progress using a tool designed to measure the effectiveness of the intervention.\" The state defines \"Dyslexia-specific intervention\" as evidence-based, specialized reading, writing, and spelling instruction that is multi-sensory in nature, equipping students to simultaneously use multiple senses, such as vision, hearing, touch, and movement. Dyslexia-specific intervention employs direct instruction of systematic and cumulative content, with the sequence beginning with the easiest and most basic elements and progress methodically to more difficult material. Each step must also be based on those already learned. Components of dyslexia-specific intervention include instruction targeting phonological awareness, sound symbol association, syllable structure, morphology, syntax, and semantics."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("The SMIR is to increase the percentage of students with Specific Learning Disabilities that score at least Basic on the state achievement tests for grades 3 - 8 in Reading Language Arts."));
        }
        [TestMethod]
        public void Texas()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/texas");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Texas Administrative Code_74.28 and 2009 Amendment"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[5]")).Text.Equals("Texas Administrative Code_74.28 tasks the board of trustees of a school district with ensuring that procedures for identifying students with dyslexia are implemented. Related requirements are discussed."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Texas has a number of regulations concerning the screening of students with dyslexia. Guidelines are described in the latest version of the Texas Dyslexia Handbook."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("HB1886 states, “Unless otherwise provided by law, a student determined to have dyslexia during screening or testing under Subsection (a) or accommodated because of dyslexia may not be rescreened or retested for dyslexia for the purpose of reassessing the student's need for accommodations until the district reevaluates the information obtained from previous screening or testing of the student.”"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Please refer to the state handbook for guidance on selecting screeners."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("TEC §21.044(b) describes various pre-service requirements related to dyslexia."));
          Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("HB1886 states, the state education agency “shall annually develop a list of training opportunities regarding dyslexia that satisfy the requirements of Section 21.054(b). The list of training opportunities must include at least one opportunity that is available online. (b) A training opportunity included in the list developed under Subsection (a) must: (1) comply with the knowledge and practice standards of an international organization on dyslexia; and (2) enable an educator to: (A) understand and recognize dyslexia; and (B) implement instruction that is systematic, explicit, and evidence-based to meet the educational needs of a student with dyslexia.”"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[18]")).Text.Equals("TEC §21.054(b) also describes various in-service requirements related to dyslexia."));
           Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[21]")).Text.Equals("Texas has a number of regulations concerning the interventions for students with dyslexia. Guidelines are described in the latest version of the Texas Dyslexia Handbook."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p[1]")).Text.Equals("Increase the reading proficiency rate for all children with disabilities in grades 3-8 against grade level and alternate achievement standards, with or without accommodations."));
        }
        [TestMethod]
        public void Utah()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/utah");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("SB0117"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("SB0117 creates a dyslexia pilot program in a multi-tiered intervention structure."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Utah does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("SB0117 created a dyslexia pilot program. Legislative changes may be forthcoming."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("Utah does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("Utah does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[17]")).Text.Equals("Utah does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Utah's SIMR focuses on math achievement."));
            

        }
        [TestMethod]
        public void Vermont()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/vermont");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.Id("docs-internal-guid-2154bec7-0314-7739-e29e-e121fa5f16d0")).Text.Equals("Vermont State Board of Education Rules (series 2360) identifies dyslexia as a specific learning disability. The Vermont State Board of Education has statutory authority."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[6]")).Text.Equals("Vermont does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Vermont does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("Vermont does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("Vermont does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Vermont's SIMR focuses on improving social-emotional skills of infants and toddlers."));

        }
        [TestMethod]
        public void Washington()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/washington");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("SB6162"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("This bill defines dyslexia, establishes screening and intervention requirements, and calls for supplementary actions by the superintendent of public instruction, including the convening of a dyslexia advisor panel."));
            Assert.IsTrue(GCDriver.FindElement(By.Id("docs-internal-guid-2154bec7-216b-3887-9099-b487346febff")).Text.Equals("Beginning in 2021-2022, schools must “use screening tools and resources that exemplify best practices, as described under section 3 of this act. School districts may use the screening tools and resources identified by the superintendent of public instruction in accordance with section 3 of this act.” According to section 3, the superintendent of public instruction will identify screening tools that: “Satisfy developmental and academic criteria, including considerations of validity and reliability, that indicate typical literacy development or dyslexia, taking into account typical child neurological development; and (b) Identify indicators and areas of weakness that are highly predictive of future reading difficulty, including phonological awareness, phonemic awareness, rapid naming skills, letter sound knowledge, and family history of difficulty with reading and language acquisition. (2) Beginning September 1, 2019, the superintendent of public instruction must maintain on the agency's web site the list of screening tools and resources identified under this section and must include links to the tools and resources, when available. (3) The superintendent of public instruction must review and update the list of screening tools and resources identified under this section as appropriate.”"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Washington does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Washington does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("However, a dyslexia pilot program was created, with a goal to develop an educator training program to enhance the reading, writing, and spelling skills of students with dyslexia. The training program must provide research-based, multisensory literacy intervention professional development in the areas of dyslexia and intervention implementation."));
            Assert.IsTrue(GCDriver.FindElement(By.Id("docs-internal-guid-2154bec7-216c-64dc-3b0a-05bfb792747f")).Text.Equals("According to SB6162, “(1) Beginning in the 2021-22 school year, and as provided in this section, each school district must use multitiered systems of support to provide interventions to students in kindergarten through second grade who display indications of, or areas of weakness associated with, dyslexia. In order to provide school districts with the opportunity to intervene before a student's performance falls significantly below grade level, school districts must screen students in kindergarten through second grade for indications of, or areas associated with, dyslexia as provided in this section.”"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[18]")).Text.Equals("The bill further states, “(a) If a student shows indications of below grade level literacy development or indications of, or areas of weakness associated with, dyslexia, the school district must provide interventions using evidence-based multitiered systems of support, consistent with the recommendations of the dyslexia advisory council under section 4 of this act and as required under this subsection (3). (b) The interventions must be evidence-based multisensory structured literacy interventions and must be provided by an educator trained in instructional methods specifically targeting students' areas of weakness. (c) Whenever possible, a school district must begin by providing student supports in the general education classroom. If screening tools and resources indicate that, after receiving the initial tier of student support, a student requires interventions, the school district may provide the interventions in either the general education classroom or a learning assistance program setting. If after receiving interventions, further screening tools and resources indicate that a student continues to have indications of, or areas of weakness associated with, dyslexia, the school district must recommend to the student's parents and family that the student be evaluated for dyslexia or a specific learning disability.” The bill also includes several reporting/notification requirements."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Washington's SIMR is to reduce the early literacy performance gap between kindergartners with disabilities and their typically developing peers."));


        }
        [TestMethod]
        public void WashingtonDC()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/washington-dc");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Washington DC does not have dyslexia legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[6]")).Text.Equals("Washington DC does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Washington DC does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("Washington DC does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("Washington DC does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Washington DC's SIMR focuses on graduation rates."));
        }
        [TestMethod]
        public void WestVirginia()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/west-virginia");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]/a")).Text.Equals("HB4608"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("According to HB4608, the state board is responsible for \"ensuring that all students receive the necessary and appropriate screenings, evaluations and early assessments for specific learning disabilities, including dyslexia and dyscalculia.\" Universality of screening may depend upon interpretation of \"necessary and appropriate.\" Senate Bill 69 sought to explicitly require universal screening in 2015, but the bill died before being passed."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[8]")).Text.Equals("See the state resource guide for information about selecting screeners."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[11]")).Text.Equals("West Virginia does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[14]")).Text.Equals("West Virginia does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("West Virginia's SIMR focuses on graduation rates."));

        }
        [TestMethod]
        public void Wisconsin()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/wisconsin");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("Wisconsin does not have dyslexia legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[6]")).Text.Equals("Wisconsin does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("Wisconsin does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("Wisconsin does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[15]")).Text.Equals("Wisconsin does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Wisconsin's SIMR is: \"By June 30, 2019, at least 55% of 3rd grade students with IEPs in three target schools will perform at or above reading proficiency against grade level and alternate academic achievement standards as measured by the state assessment.\""));

        }
        [TestMethod]
        public void Wyoming()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/wyoming");
            TestingClass.IsElementPresentXpath("//*[@id='content']/div/div/div[2]/div[1]/div/span[2]/img", GCDriver);
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]/a")).Text.Equals("SF0052"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[9]")).Text.Equals("The universal screening instrument assessment approved by the Wyoming Department of Education pursuant to W.S. §_ 21-3-110 and W.S. §_21-3-401 shall be used as the pre-screening instrument for reading difficulties, including dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[12]")).Text.Equals("See Wyoming's Approved Evaluation Instrument list."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[19]")).Text.Equals("Wyoming does not have in-service legislation related to dyslexia."));
            
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[23]")).Text.Equals("Wyoming does not require dyslexia intervention."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p[1]")).Text.Equals("Wyoming aims to increase in the percentage of third-grade students with disabilities who spend 21 to 60% of their school day outside the general education environment who score proficient or advanced on the statewide reading assessment."));


        }
      

    }
}
