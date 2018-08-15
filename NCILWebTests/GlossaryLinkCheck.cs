using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NCILWebTests
{
    [TestClass]
    public class GlossaryLinkCheck
    {

        static IWebDriver GCDriver;
        [TestInitialize]
        public void SetUpDrivers()
        {

            var options = new ChromeOptions();
            options.AddArgument("headless");
            GCDriver = new ChromeDriver(options);
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
            string[,] LinkList = new string[,] { { "[href *= '/glossary/identification']", "Identification | National Center on Improving Literacy" },
                                               {"[href *= '/glossary/individualized-educational-program']", "Individualized Educational Program | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/intervention']","Intervention | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/irregular-words']", "Irregular Words | National Center on Improving Literacy"},
 
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
            
            string[,] LinkList = new string[,] { { "[href *= '/glossary/language-processing']", "Language Processing | National Center on Improving Literacy" },
                                               {"[href *= '/glossary/listening-comprehension']", "Listening Comprehension | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/literacy']","Literacy | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/literacy-rich-envioronment']", "Literacy Rich Environment | National Center on Improving Literacy"},
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
        public void MLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/m']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/morphology']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Morphology | National Center on Improving Literacy"));
            GCDriver.Navigate().Back();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/multi-tiered-system-support']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Multi-Tiered System Of Support | National Center on Improving Literacy"));

        }
        [TestMethod]
        public void NLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/n']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/nonverbal-learning-disabilities']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Nonverbal Learning Disabilities | National Center on Improving Literacy"));

        }
        [TestMethod]
        public void OLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/o']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/oral-language']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Oral Language | National Center on Improving Literacy"));
            GCDriver.Navigate().Back();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/orthography']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Orthography | National Center on Improving Literacy"));

        }
        [TestMethod]
        public void PLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/p']")).Click();
            
            string[,] LinkList = new string[,] { { "[href *= '/glossary/phoneme']", "Phoneme | National Center on Improving Literacy" },
                                               {"[href *= '/glossary/phonemic-awareness']", "Phonemic Awareness | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/phonics']","Phonics | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/phonological-awareness']", "Phonological Awareness | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/phonological-processing']", "Phonological Processing | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/pragmatics']", "Pragmatics | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/print-awareness']", "Print Awareness | National Center on Improving Literacy"},
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
        public void RLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/r']")).Click();
            
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/rapid-automatized-naming']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Rapid Automatized Naming | National Center on Improving Literacy"));
            GCDriver.Navigate().Back();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/reading-comprehension']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Reading Comprehension | National Center on Improving Literacy"));
            GCDriver.Navigate().Back();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/receptive-language']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Receptive Language | National Center on Improving Literacy"));

        }
        [TestMethod]
        public void SLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/s']")).Click();
            string[,] LinkList = new string[,] { { "[href *= '/glossary/scaffolding']", "Scaffolding | National Center on Improving Literacy" },
                                               {"[href *= '/glossary/screening']", "Screening | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/self-monitoring']","Self-Monitoring | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/semantics']", "Semantics | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/specific-learning-disability']", "Specific Learning Disability | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/speech-and-language-impairment']", "Speech And Language Impairment | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/syntax']", "Syntax | National Center on Improving Literacy"},
                                               {"[href *= '/glossary/systematic-instruction']", "Systematic Instruction | National Center on Improving Literacy"},
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
        public void VLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/v']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/visual-acuity']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Visual Acuity | National Center on Improving Literacy"));
            GCDriver.Navigate().Back();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/visual-perceptualvisual-motor-deficit']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Visual Perceptual/Visual Motor Deficit | National Center on Improving Literacy"));
            GCDriver.Navigate().Back();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/vocabulary']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Vocabulary | National Center on Improving Literacy"));

        }
        [TestMethod]
        public void WLinkTest()
        {

            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/w']")).Click();
            GCDriver.FindElement(By.CssSelector("[href *= '/glossary/written-language']")).Click();
            Assert.IsTrue(GCDriver.Title.Equals("Written Language | National Center on Improving Literacy"));


        }

        [TestCleanup]
        public void CloseDrivers()
        {
            GCDriver.Quit();
            //GCDriver.Close();
        }

    }
}
