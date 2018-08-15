using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using OpenQA.Selenium.Support.UI;

namespace NCILWebTests
{
    class TestingClass
    {
        static IWebDriver GCDriver;
        public void SetUpDrivers()
        {

            GCDriver = new ChromeDriver();

            //GCDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        public static void IsElementPresentXpath(string whereToLook, IWebDriver driver)
        {
            IWebElement element;
            bool flag = false;
            if (TryFindElement(By.XPath(whereToLook), out element, driver))
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
        public static void IsElementPresentLinkText(string whereToLook, IWebDriver driver)
        {
            IWebElement element;
            bool flag = false;
            if (TryFindElement(By.LinkText(whereToLook), out element, driver))
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
        public static void IsElementPresentClassName(string whereToLook, IWebDriver driver)
        {
            IWebElement element;
            bool flag = false;
            if (TryFindElement(By.ClassName(whereToLook), out element, driver))
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
        public static void IsElementPresentCSS(string whereToLook, IWebDriver driver)
        {
            IWebElement element;
            bool flag = false;
            if (TryFindElement(By.CssSelector(whereToLook), out element, driver))
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
        public static bool TextCheckMethodClassName(string txtToCheck, string whereToCheck, IWebDriver driver)
        {
            bool flag;
            //method for testing if a supplied text a certain location (using class name) is found
            if (driver.FindElement(By.ClassName(whereToCheck)).Text.Equals(txtToCheck) == true)
               
                return true;
            else
                return false;
        }
        public static bool TextCheckMethodCSS(string txtTocheck, string whereToCheck, IWebDriver driver)
        {
            if (driver.FindElement(By.CssSelector(whereToCheck)).Text.Equals(txtTocheck) == true)
                return true;
            else
                return false;
        }
        public static bool TextCheckMethodXPath(string txtTocheck, string whereToCheck, IWebDriver driver)
        {
            if (driver.FindElement(By.XPath(whereToCheck)).Text.Equals(txtTocheck) == true)
                return true;
            else
                return false;
        }
        public static bool TryFindElement(By by, out IWebElement element, IWebDriver driver)
        {
            try
            {
                element = driver.FindElement(by);
            }
            catch (NoSuchElementException ex)
            {
                element = null;
                return false;
            }
            return true;
        }
        public static bool IsElementVisible(IWebElement element)
        {
            return element.Displayed && element.Enabled;
        }
        public static bool CheckFileDownloaded(string filename)
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
        public static IWebElement WaitUntilElementClickable(By elementLocator, IWebDriver driver, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementToBeClickable(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
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

    }
}
