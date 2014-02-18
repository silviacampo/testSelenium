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
            SeleniumUtils.FireFoxTestLoad(browser, Constants.GSWebHost);
        }

        [TestMethod]
        public void TestGSMHomeLoad()
        {
            SeleniumUtils.FireFoxTestLoad(browser, Constants.GSMobileWebHost);
        }

        [TestMethod]
        public void TestGDHomeLoad()
        {
            SeleniumUtils.FireFoxTestLoad(browser, Constants.GDWebHost);
        }

        [TestMethod]
        public void TestGDMHomeLoad()
        {
            SeleniumUtils.FireFoxTestLoad(browser, Constants.GDMobileWebHost);
        }

        [TestMethod]
        public void TestGOHomeLoad()
        {
            SeleniumUtils.FireFoxTestLoad(browser, Constants.GOWebHost);
        }

        [TestMethod]
        public void TestGOMHomeLoad()
        {
            SeleniumUtils.FireFoxTestLoad(browser, Constants.GOMobileWebHost);
        }
        #endregion

    }
}