using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NCILWebTests
{
    [TestClass]
    public class Glossary
    {

        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {

            GCDriver = new ChromeDriver();
            GCDriver.Navigate().GoToUrl("https://improvingliteracy.org/glossary");
        }
        [TestMethod]
        public void TestTitle()
        {
            Assert.IsTrue(GCDriver.Title.Equals("Learning Literacy Glossary | National Center on Improving Literacy"));
        }
        [TestMethod]
        public void ALinkTest()
        {
            string[,] LinkList = new string[,] { { "[href *= '/glossary/academic-language']", "Academic Language | National Center on Improving Literacy" },
                                               {"[href *= '/glossary/accuracy']", "Accuracy | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/alphabet-knowledge']","Alphabet Knowledge | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/alphabetic-principle']", "Alphabetic Principle | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/auditory-perception']", "Auditory Perception | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/auditory-processing']", "Auditory Processing | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/automaticity']", "Automaticity | National Center on Improving Literacy"},



            };

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/a']")).Click();
            for (int i=0; i<LinkList.GetLength(0)-1;i++)
            {
                
            GCDriver.FindElement(By.CssSelector(LinkList[i,0])).Click();
            Assert.IsTrue(GCDriver.Title.Equals(LinkList[i,1]));
            GCDriver.Navigate().Back();
            }
 
        }
        [TestMethod]
        public void BLinkTest()
        {
            
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/b']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/blending']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Blending | National Center on Improving Literacy"));

        }
        [TestMethod]
        public void CLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/c']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/cognitive-processing']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Cognitive Processing | National Center on Improving Literacy"));
            GCDriver.Navigate().Back();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/connected-text']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Connected Text | National Center on Improving Literacy"));



        }
        [TestMethod]
        public void DLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/d']")).Click();
            string[,] LinkList = new string[,] { { "[href *= '/glossary/decodable-words']", "Decodable Words | National Center on Improving Literacy" },
                                               {"[href *= '/glossary/decoding']", "Decoding | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/diagnosis']","Diagnosis | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/dyscalculia']", "Dyscalculia | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/dysgraphia']", "Dysgraphia | National Center on Improving Literacy"},
                                               
                                               {"[href *= '/glossary/dyslecia']", "Dyslexia | National Center on Improving Literacy"},



            };

            
            for (int i = 0; i < LinkList.GetLength(0) - 1; i++)
            {
                //GCDriver.FindElement(By.CssSelector("[href *= '/glossary/d']")).Click();
                GCDriver.FindElement(By.CssSelector(LinkList[i, 0])).Click();
                Assert.IsTrue(GCDriver.Title.Equals(LinkList[i, 1]));
                GCDriver.Navigate().Back();
            }

        }
        [TestMethod]
        public void ELinkTest()
        {
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/e']")).Click();
            string[,] LinkList = new string[,] { { "[href *= '/glossary/eligibility-category-or-classification']", "Eligibility Category or Classification | National Center on Improving Literacy" },
                                               {"[href *= '/glossary/evidence-based']", "Evidence-based | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/executive-functioning']","Executive Functioning | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/explicit-instruction']", "Explicit Instruction | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/expression']", "Expression | National Center on Improving Literacy"},

                                               {"[href *= '/glossary/expressive-language']", "Expressive Language | National Center on Improving Literacy"},



            };


            for (int i = 0; i < LinkList.GetLength(0) - 1; i++)
            {
                //GCDriver.FindElement(By.CssSelector("[href *= '/glossary/d']")).Click();
                GCDriver.FindElement(By.CssSelector(LinkList[i, 0])).Click();
                Assert.IsTrue(GCDriver.Title.Equals(LinkList[i, 1]));
                GCDriver.Navigate().Back();
            }

        }
        [TestMethod]
        public void FLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/f']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/fluency']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Fluency | National Center on Improving Literacy"));

        }
        [TestMethod]
        public void GLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/g']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/grammar']")).Click() ;
            Assert.IsTrue(GCDriver.Title.Equals("Grammar | National Center on Improving Literacy"));
            GCDriver.Navigate().Back();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/grapheme']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Grapheme | National Center on Improving Literacy"));

        }
        [TestMethod]
        public void HLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/h']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/high-frequency-words']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("High Frequency Words | National Center on Improving Literacy"));


        }
        [TestMethod]
        public void ILinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/i']")).Click();
            string[,] LinkList = new string[,] { { "[href *= '/glossary/identfication']", "Identification | National Center on Improving Literacy" },
                                               {"[href *= '/glossary/individual-educational-program']", "Individual Educational Program | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/executive-functioning']","Executive Functioning | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/explicit-instruction']", "Explicit Instruction | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/expression']", "Expression | National Center on Improving Literacy"},

                                               {"[href *= '/glossary/expressive-language']", "Expressive Language | National Center on Improving Literacy"},



            };


            for (int i = 0; i < LinkList.GetLength(0) - 1; i++)
            {
                //GCDriver.FindElement(By.CssSelector("[href *= '/glossary/d']")).Click();
                GCDriver.FindElement(By.CssSelector(LinkList[i, 0])).Click();
                Assert.IsTrue(GCDriver.Title.Equals(LinkList[i, 1]));
                GCDriver.Navigate().Back();
            }

        }
        [TestMethod]
        public void LLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/l']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/language-processing']"));

        }
        [TestMethod]
        public void MLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/m']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/morphology']"));

        }
        [TestMethod]
        public void NLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/n']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/nonverbal-learning-disabilities']"));

        }
        [TestMethod]
        public void OLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/o']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/oral-language']"));

        }
        [TestMethod]
        public void PLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/p']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/phoneme']"));

        }
        [TestMethod]
        public void RLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/r']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/rapid-automatized-naming']"));

        }
        [TestMethod]
        public void SLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/s']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/scaffolding']"));

        }
        [TestMethod]
        public void VLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/v']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/visual-acuity']"));

        }
        [TestMethod]
        public void WLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/w']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/written-language']"));

        }

        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }

    }
}
