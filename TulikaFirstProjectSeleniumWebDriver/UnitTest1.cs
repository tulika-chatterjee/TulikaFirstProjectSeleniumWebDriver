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
            strdriver.Navigate().GoToUrl("https://www.facebook.com/");
            //this is my first clone
            strdriver.Close();
            //Added by GitExpA
            //Added by GitExpB
            //Some more
           strdriver.Quit();
        }
    }
}
