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

namespace ProjectTestCSharp
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke Testing")]
        public void TestMethod1()
        {
          
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            element.SelectByText("Jun");
            element.SelectByValue("6");

        }

        [Test, Category("Regression Testing")]
        public void TestMethod2()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");
            Thread.Sleep(5000);

        }

        [Test, Category("Regression Testing")]
        public void TestMethod3()
        {

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");


        }


    }
}
