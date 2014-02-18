using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;


namespace testgossip.Selenium
{
    [TestClass]
    public class HomeFireFoxTest
    {
        private FirefoxDriver browser;

        #region "HOME PAGES LOAD"

        [TestMethod]
        public void TestGSHomeLoad()
        {
            SeleniumFireFoxUtils.TestLoad(browser, Constants.GSWebHost);
        }

        [TestMethod]
        public void TestGSMHomeLoad()
        {
            SeleniumFireFoxUtils.TestLoad(browser, Constants.GSMobileWebHost);
        }

        [TestMethod]
        public void TestGDHomeLoad()
        {
            SeleniumFireFoxUtils.TestLoad(browser, Constants.GDWebHost);
        }

        [TestMethod]
        public void TestGDMHomeLoad()
        {
            SeleniumFireFoxUtils.TestLoad(browser, Constants.GDMobileWebHost);
        }

        [TestMethod]
        public void TestGOHomeLoad()
        {
            SeleniumFireFoxUtils.TestLoad(browser, Constants.GOWebHost);
        }

        [TestMethod]
        public void TestGOMHomeLoad()
        {
            SeleniumFireFoxUtils.TestLoad(browser, Constants.GOMobileWebHost);
        }
        #endregion

    }
}