using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Safari;


namespace testgossip.Selenium
{
    [TestClass]
    public class HomeSafariTest
    {
        private SafariDriver browser;

        #region "HOME PAGES LOAD"

        [TestMethod]
        public void TestGSHomeLoad()
        {
            SeleniumSafariUtils.TestLoad(browser, Constants.GSWebHost);
        }

        [TestMethod]
        public void TestGSMHomeLoad()
        {
            SeleniumSafariUtils.TestLoad(browser, Constants.GSMobileWebHost);
        }

        [TestMethod]
        public void TestGDHomeLoad()
        {
            SeleniumSafariUtils.TestLoad(browser, Constants.GDWebHost);
        }

        [TestMethod]
        public void TestGDMHomeLoad()
        {
            SeleniumSafariUtils.TestLoad(browser, Constants.GDMobileWebHost);
        }

        [TestMethod]
        public void TestGOHomeLoad()
        {
            SeleniumSafariUtils.TestLoad(browser, Constants.GOWebHost);
        }

        [TestMethod]
        public void TestGOMHomeLoad()
        {
            SeleniumSafariUtils.TestLoad(browser, Constants.GOMobileWebHost);
        }
        #endregion

    }
}