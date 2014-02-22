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
             Assert.IsTrue(SeleniumSafariUtils.TestLoad(browser, Constants.GSWebHost));
        }

        [TestMethod]
        public void TestGSMHomeLoad()
        {
             Assert.IsTrue(SeleniumSafariUtils.TestLoad(browser, Constants.GSMobileWebHost));
        }

        [TestMethod]
        public void TestGDHomeLoad()
        {
             Assert.IsTrue(SeleniumSafariUtils.TestLoad(browser, Constants.GDWebHost));
        }

        [TestMethod]
        public void TestGDMHomeLoad()
        {
             Assert.IsTrue(SeleniumSafariUtils.TestLoad(browser, Constants.GDMobileWebHost));
        }

        [TestMethod]
        public void TestGOHomeLoad()
        {
             Assert.IsTrue(SeleniumSafariUtils.TestLoad(browser, Constants.GOWebHost));
        }

        [TestMethod]
        public void TestGOMHomeLoad()
        {
             Assert.IsTrue(SeleniumSafariUtils.TestLoad(browser, Constants.GOMobileWebHost));
        }
        #endregion

        #region "HOME PAGES TITLES ARE OK"

        [TestMethod]
        public void TestGSHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestTitleLoad(browser, Constants.GSWebHost, Constants.GSWebHostTitle));
        }

        [TestMethod]
        public void TestGSMHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestTitleLoad(browser, Constants.GSMobileWebHost, Constants.GSMobileWebHostTitle));
        }

        [TestMethod]
        public void TestGDHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestTitleLoad(browser, Constants.GDWebHost, Constants.GDWebHostTitle));
        }

        [TestMethod]
        public void TestGDMHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestTitleLoad(browser, Constants.GDMobileWebHost, Constants.GDMobileWebHostTitle));
        }

        [TestMethod]
        public void TestGOHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestTitleLoad(browser, Constants.GOWebHost, Constants.GOWebHostTitle));
        }

        [TestMethod]
        public void TestGOMHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestTitleLoad(browser, Constants.GOMobileWebHost, Constants.GOMobileWebHostTitle));
        }

        #endregion

        #region "HOME PAGES HEADER TEXT ARE OK"

        [TestMethod]
        public void TestGSHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestHeaderTextLoad(browser, Constants.GSWebHost, Layout.GSTitleImg));
        }

        [TestMethod]
        public void TestGSMHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestHeaderTextLoad(browser, Constants.GSMobileWebHost, Layout.GSMTitleImg));
        }

        [TestMethod]
        public void TestGDHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestHeaderTextLoad(browser, Constants.GDWebHost, Layout.GDTitleImg));
        }

        [TestMethod]
        public void TestGDMHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestHeaderTextLoad(browser, Constants.GDMobileWebHost, Layout.GDMTitleImg));
        }

        [TestMethod]
        public void TestGOHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestHeaderTextLoad(browser, Constants.GOWebHost, Layout.GOTitleImg));
        }

        [TestMethod]
        public void TestGOMHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumSafariUtils.TestHeaderTextLoad(browser, Constants.GOMobileWebHost, Layout.GOMTitleImg));
        }

        #endregion

        //#region "HOME PAGES MENU COLORS ARE OK"

        //[TestMethod]
        //public void TestGSHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumSafariUtils.TestMenuColorsLoad(browser, Constants.GSWebHost, Layout.GSleftMenuFColor.ToRgbString, Layout.GSleftMenuBColor.ToRgbString));
        //}

        ////[TestMethod]
        //public void TestGSMHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumSafariUtils.TestMenuColorsLoad(browser, Constants.GSMobileWebHost, Layout.GSleftMenuFColor.ToRgbString, Layout.GSleftMenuBColor.ToRgbString));
        //}

        //[TestMethod]
        //public void TestGDHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumSafariUtils.TestMenuColorsLoad(browser, Constants.GDWebHost, Layout.GDleftMenuFColor.ToRgbString, Layout.GDleftMenuBColor.ToRgbString));
        //}

        ////[TestMethod]
        //public void TestGDMHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumSafariUtils.TestMenuColorsLoad(browser, Constants.GDMobileWebHost, Layout.GDleftMenuFColor.ToRgbString, Layout.GDleftMenuBColor.ToRgbString));
        //}

        //[TestMethod]
        //public void TestGOHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumSafariUtils.TestMenuColorsLoad(browser, Constants.GOWebHost, Layout.GOleftMenuFColor.ToRgbString, Layout.GOleftMenuBColor.ToRgbString));
        //}

        ////[TestMethod]
        //public void TestGOMHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumSafariUtils.TestMenuColorsLoad(browser, Constants.GOMobileWebHost, Layout.GOleftMenuFColor.ToRgbString, Layout.GOleftMenuBColor.ToRgbString));
        //}

        //#endregion

    }
}