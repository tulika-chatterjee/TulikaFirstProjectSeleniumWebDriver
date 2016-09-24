using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace TulikaFirstProjectSeleniumWebDriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IWebDriver strdriver = new ChromeDriver();
            strdriver.Navigate().GoToUrl("https://www.linkedin.com/");
            strdriver.Close();
           strdriver.Quit();
        }
    }
}
