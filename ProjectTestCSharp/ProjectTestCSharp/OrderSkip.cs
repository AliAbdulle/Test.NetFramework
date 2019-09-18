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
    public class OrderSkipAttribute 
    {

        [Test, Category("OrderSkipAttribute")]
        public void TestMethod3()
        {
            IWebDriver driver = new ChromeDriver();
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("OpenSeleniumC#");


        }


    }
}
