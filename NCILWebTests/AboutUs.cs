using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;

namespace NCILWebTests
{
    [TestClass]
    public class AboutUs
    {
        string[] bioText = new string[] { "Hank Fien, Ph.D., is the Director of NCIL and leads the Instruction and Intervention Strand of the center. Dr. Fien is an Associate Professor in the Special Education and Clinical Sciences department at the University of Oregon, and the Director of the Center on Teaching and Learning. His research is focused on the areas of early reading, adolescent reading, and early mathematics interventions for diverse learners in school settings. Dr. Fien’s most recent work is focused on extending the learning environment from the physical classroom to include virtual environments (e.g., gaming platforms), and leveraging gaming technology to maximize instructional design and delivery principles. ",
        "Yaacov Petscher, Ph.D. is a Deputy Director of NCIL and leads the Screening and Identification Strand of the center. Dr. Petscher is an Associate Director at the Florida Center for Reading Research and the Director of the Quantitative Methodology and Innovative Division, at Florida State University. He is interested in the development and application of statistical models to data in order to understand why students differ in their reading skills, as well as creative disseminations of research through technology and alternative mediums.",
       "Sarah Sayko, M.Ed., is a Deputy Director of NCIL, and leads the Parent and Family Strand of the center.  She is a Senior Research Associate at RMC Research Corporation in Arlington, VA.  Sarah is the West Virginia State Coordinator for the Appalachia Regional Comprehensive Center. Ms. Sayko is experienced in designing professional learning experiences and resources for school leaders and practitioners in evidence-based literacy practices and on how to implement these practices in schools.  She was an elementary reading coach and literacy specialist in two Massachusetts school districts and is a certified K-12 reading specialist.",
        "Nancy J. Nelson, Ph.D., is the Co-Lead of Professional Development for NCIL. She is a Research Assistant Professor at the Center on Teaching and Learning at the University of Oregon, and the Director of Clinic and Outreach Services which houses the CTL Clinic. Dr. Nelson’s research focuses on developing and evaluating math and reading interventions for grades K-8. She is a nationally certified school psychologist, and a former middle and high school special education math teacher.",
        "Scott K. Baker, Ph.D., Co-Leads the Professional Development Strand for NCIL. Dr. Baker is a Research Professor at the Center on Research and Evaluation at Southern Methodist University, and a senior Research Associate at the Center on Teaching and Learning, University of Oregon. He is interested in the role research plays in improving policies and practices associated with improved educational outcomes, and  in the challenges faced by English learners and by children with learning difficulties and disabilities.",
        "Jessica Turtura, Ph.D., is the Co-Lead of Dissemination for NCIL. She also provides overall project management for the center. Jessica is a Research Associate at the Center on Teaching and Learning at the University of Oregon. She is interested in the development and evaluation of reading and math interventions for grades K-3, and in factors that predict responsiveness to intervention.",
        "Brian Gearin Co-Leads the Dissemination Strand for the Center. Brian is a doctoral student in Educational Methodology, Policy, and Leadership and a graduate employee at the University of Oregon’s Center on Teaching and Learning. He is a former high school social studies and English teacher at a priority school in Delaware. Brian’s research is broadly focused on the translation of scientific research to educational policy and practice.",
        "Lillian Durán, Ph.D., leads the center’s work on creating and translating resources for English language learners. She is an Associate Professor in the Department of Special Education and Clinical Sciences at the University of Oregon. Her research is focused on improving instructional and assessment practices with preschool-aged dual language learners (DLLs). Dr. Durán brings expertise on the topic of recommended practices in assessment and intervention with young DLLs with and without identified disabilities. Prior to Dr. Durán’s work in higher education she worked for 9 years as an early childhood special education teacher.",
        "Anna Ingram provides Administrative Support to the center, and is a member of the Dissemination and the Parent & Family strands. Anna has a BA in English and Creative Writing from West Virginia University and has worked for the Center on Teaching and Learning at the University of Oregon as part of the administrative staff since 2004. She splits her time between NCIL and the CTL Clinic which offers tutoring to elementary age students struggling with reading or math. Anna is also the parent of a child who struggles with dyslexia, and has a vested interest in evidence-based instruction for children struggling with reading."};


        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {
            var options = new ChromeOptions();
            options.AddArgument("headless");
            GCDriver = new ChromeDriver(options);
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/about");
        }
        [TestMethod]
        public void TitleCheck()
        {
            Assert.IsTrue(GCDriver.Title.Equals("About Us | National Center on Improving Literacy"));
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".page__title.title")).Text.Equals("About Us"));
        }
        [TestMethod]
        public void Panel1Test()
        {
            //pane1 is the first paragraph of text on the aboutus page
            Assert.IsTrue(GCDriver.FindElement(By.CssSelector(".panel-pane.pane-custom.pane-1")).Text.Equals("The National Center on Improving Literacy " +
                "(NCIL) is a partnership among literacy experts, university researchers, and technical assistance providers, with funding from the United States" +
                " Department of Education."));
           
            
        }
        [TestMethod]
        public void Panel2Test()
        {
          GCDriver.FindElement(By.CssSelector(".panel-pane.pane-custom.pane-2")).Text.Equals("Our Mission is to increase access to, and use of, evidence-based " +
              "approaches to screen, identify, and teach students with literacy-related disabilities, including dyslexia. Download our handout.");

        }
        [TestMethod]
        public void TestPDF()
        {
            GCDriver.FindElement(By.LinkText("Download our handout.")).Click();

            IWebElement element = GCDriver.FindElement(By.Id("plugin"));
            string myString = element.GetAttribute("src");
            Assert.AreEqual(myString, "https://improvingliteracy.org/files/Improving-Literacy-Handout.pdf");

        }

        [TestMethod]
        public void PictureTest()
        {
            //tests if staff pictures are presenet and visable on about page   
            TestingClass.IsElementPresentCSS(".figure", GCDriver);
          
           
        }
        [TestMethod]
        public void YoutubePresent()
        {
            //GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            GCDriver.SwitchTo().Frame(0);
            
            TestingClass.IsElementPresentXpath("//*[@id='player']", GCDriver);
            //*[@id="player_uid_501086740_1"]/div[3]/div[1]/div[2]/a




        }

        [TestMethod]
        public void TestBioField()
        {
            // IList<IWebElement> textList = GCDriver.FindElements(By.CssSelector(".field.field-name-field-bio")
            // List<string>text=GCDriver.FindElements(By.CssSelector(".field.field-name-field-bio"))
            //GCDriver.FindElements(By.CssSelector(".field.field-name-field-bio"))[0].Text;

            for (int i=0;i<bioText.Length;i++)
            {
                bool flag = true;
                if (GCDriver.FindElements(By.CssSelector(".field.field-name-field-bio"))[i].Text == bioText[i])
                {
                    flag = true;
                }
                else
                    flag = false;
                Assert.IsTrue(flag);
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
