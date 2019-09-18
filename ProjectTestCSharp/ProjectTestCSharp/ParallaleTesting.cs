using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectTestCSharp.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using ProjectTestCSharp.Utilities;

namespace ProjectTestCSharp
{
    [TestFixture]
    public class ParallaleTesting
    {
        IWebDriver driver;

        [Test,Category("UAT Testing"),Category("Model1")]
        public void TestMethod1()
        {
           var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Driver.Close();
           

        }

        [Test,Category("UAT Testing"),Category("Model1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Driver.Close();


        }

        [Test,Category("UAT Testing"),Category("Model1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Driver.Close();


        }

        [Test,Category("UAT Testing"),Category("Model1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Driver.Close();


        }

        [Test,Category("UAT Testing"),Category("Model1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Driver.Close();


        }

        [Test,Category("UAT Testing"),Category("Model1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Driver.Close();


        }

        [Test,Category("UAT Testing"),Category("Model1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Driver.Close();


        }

        [Test,Category("UAT Testing"),Category("Model1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Driver.Close();


        }

        [Test,Category("UAT Testing"),Category("Model1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Driver.Close();


        }

        [Test, Category("UAT Testing"), Category("Model1")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtilities().Init(driver);
            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Driver.Close();


        }



    }
}

