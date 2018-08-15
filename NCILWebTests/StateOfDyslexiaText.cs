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
            GCDriver = new ChromeDriver(options);

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
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Students with IEPs will be prepared to transition effectively and achieve improved post-school outcomes [i.e., students will be able to achieve positive post-school outcomes and engage in higher education and competitive employment opportunities]."));
          
        }
        [TestMethod]
        public void AlaskaText()
        {
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/state-of-dyslexia/alaska");
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
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[3]")).Text.Equals("SR743"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[4]")).Text.Equals("Georgia has signed several laws defining and recognizing the importance of dyslexia, as well as its relevance to education."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[7]")).Text.Equals("Georgia does not have dyslexia screening legislation."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[10]")).Text.Equals("Georgia does not have pre-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[13]")).Text.Equals("Georgia does not have in-service legislation related to dyslexia."));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/p[16]")).Text.Equals("Georgia does not require dyslexia intervention"));
            Assert.IsTrue(GCDriver.FindElement(By.XPath("//*[@id='content']/div/div/div[1]/div[1]/p")).Text.Equals("Georgia's SIMR is to increase the statewide graduation rate of students with disabilities and close the graduation gap."));


        }
    }
}
