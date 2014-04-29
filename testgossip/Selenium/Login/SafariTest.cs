using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Safari;


namespace testgossip.Selenium.Login
{
    [TestClass]
    public class SafariTest
    {
        private SafariDriver browser;

        [TestMethod]
        public void TestEmptyLogin()
        {
            string message;
            Assert.IsTrue(SeleniumSafariUtils.TestEmptyLogin(browser, Constants.GSWebLoginPage,out message),message);
        }      

    }
}