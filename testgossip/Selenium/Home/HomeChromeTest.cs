using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace testgossip.Selenium
{
    [TestClass]
    public class HomeChromeTest
    {
        private ChromeDriver browser;

        #region "HOME PAGES LOAD"

        [TestMethod]
        public void TestGSHomeLoad()
        {
            SeleniumChromeUtils.TestLoad(browser, Constants.GSWebHost);
        }

        [TestMethod]
        public void TestGSMHomeLoad()
        {
            SeleniumChromeUtils.TestLoad(browser, Constants.GSMobileWebHost);
        }

        [TestMethod]
        public void TestGDHomeLoad()
        {
            SeleniumChromeUtils.TestLoad(browser, Constants.GDWebHost);
        }

        [TestMethod]
        public void TestGDMHomeLoad()
        {
            SeleniumChromeUtils.TestLoad(browser, Constants.GDMobileWebHost);
        }

        [TestMethod]
        public void TestGOHomeLoad()
        {
            SeleniumChromeUtils.TestLoad(browser, Constants.GOWebHost);
        }

        [TestMethod]
        public void TestGOMHomeLoad()
        {
            SeleniumChromeUtils.TestLoad(browser, Constants.GOMobileWebHost);
        }
        #endregion

    }
}