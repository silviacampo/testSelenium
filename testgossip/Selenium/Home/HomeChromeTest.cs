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
            Assert.IsTrue(SeleniumChromeUtils.TestLoad(browser, Constants.GSWebHost));
        }

        [TestMethod]
        public void TestGSMHomeLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestLoad(browser, Constants.GSMobileWebHost));
        }

        [TestMethod]
        public void TestGDHomeLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestLoad(browser, Constants.GDWebHost));
        }

        [TestMethod]
        public void TestGDMHomeLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestLoad(browser, Constants.GDMobileWebHost));
        }

        [TestMethod]
        public void TestGOHomeLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestLoad(browser, Constants.GOWebHost));
        }

        [TestMethod]
        public void TestGOMHomeLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestLoad(browser, Constants.GOMobileWebHost));
        }
        #endregion

        #region "HOME PAGES TITLES ARE OK"

        [TestMethod]
        public void TestGSHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestTitleLoad(browser, Constants.GSWebHost, Constants.GSWebHostTitle));
        }

        [TestMethod]
        public void TestGSMHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestTitleLoad(browser, Constants.GSMobileWebHost, Constants.GSMobileWebHostTitle));
        }

        [TestMethod]
        public void TestGDHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestTitleLoad(browser, Constants.GDWebHost, Constants.GDWebHostTitle));
        }

        [TestMethod]
        public void TestGDMHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestTitleLoad(browser, Constants.GDMobileWebHost, Constants.GDMobileWebHostTitle));
        }

        [TestMethod]
        public void TestGOHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestTitleLoad(browser, Constants.GOWebHost, Constants.GOWebHostTitle));
        }

        [TestMethod]
        public void TestGOMHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestTitleLoad(browser, Constants.GOMobileWebHost, Constants.GOMobileWebHostTitle));
        }

        #endregion

        #region "HOME PAGES HEADER TEXT ARE OK"

        [TestMethod]
        public void TestGSHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestHeaderTextLoad(browser, Constants.GSWebHost, Layout.GSTitleImg));
        }

        [TestMethod]
        public void TestGSMHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestHeaderTextLoad(browser, Constants.GSMobileWebHost, Layout.GSMTitleImg));
        }

        [TestMethod]
        public void TestGDHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestHeaderTextLoad(browser, Constants.GDWebHost, Layout.GDTitleImg));
        }

        [TestMethod]
        public void TestGDMHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestHeaderTextLoad(browser, Constants.GDMobileWebHost, Layout.GDMTitleImg));
        }

        [TestMethod]
        public void TestGOHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestHeaderTextLoad(browser, Constants.GOWebHost, Layout.GOTitleImg));
        }

        [TestMethod]
        public void TestGOMHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumChromeUtils.TestHeaderTextLoad(browser, Constants.GOMobileWebHost, Layout.GOMTitleImg));
        }

        #endregion

        //#region "HOME PAGES MENU COLORS ARE OK"

        //[TestMethod]
        //public void TestGSHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumChromeUtils.TestMenuColorsLoad(browser, Constants.GSWebHost, Layout.GSleftMenuFColor.ToRgbString, Layout.GSleftMenuBColor.ToRgbString));
        //}

        ////[TestMethod]
        //public void TestGSMHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumChromeUtils.TestMenuColorsLoad(browser, Constants.GSMobileWebHost, Layout.GSleftMenuFColor.ToRgbString, Layout.GSleftMenuBColor.ToRgbString));
        //}

        //[TestMethod]
        //public void TestGDHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumChromeUtils.TestMenuColorsLoad(browser, Constants.GDWebHost, Layout.GDleftMenuFColor.ToRgbString, Layout.GDleftMenuBColor.ToRgbString));
        //}

        ////[TestMethod]
        //public void TestGDMHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumChromeUtils.TestMenuColorsLoad(browser, Constants.GDMobileWebHost, Layout.GDleftMenuFColor.ToRgbString, Layout.GDleftMenuBColor.ToRgbString));
        //}

        //[TestMethod]
        //public void TestGOHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumChromeUtils.TestMenuColorsLoad(browser, Constants.GOWebHost, Layout.GOleftMenuFColor.ToRgbString, Layout.GOleftMenuBColor.ToRgbString));
        //}

        ////[TestMethod]
        //public void TestGOMHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumChromeUtils.TestMenuColorsLoad(browser, Constants.GOMobileWebHost, Layout.GOleftMenuFColor.ToRgbString, Layout.GOleftMenuBColor.ToRgbString));
        //}

        //#endregion
    
    }
}