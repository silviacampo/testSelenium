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
            Assert.IsTrue(SeleniumFireFoxUtils.TestLoad(browser, Constants.GSWebHost));
        }

        [TestMethod]
        public void TestGSMHomeLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestLoad(browser, Constants.GSMobileWebHost));
        }

        [TestMethod]
        public void TestGDHomeLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestLoad(browser, Constants.GDWebHost));
        }

        [TestMethod]
        public void TestGDMHomeLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestLoad(browser, Constants.GDMobileWebHost));
        }

        [TestMethod]
        public void TestGOHomeLoad()
        {
           Assert.IsTrue(SeleniumFireFoxUtils.TestLoad(browser, Constants.GOWebHost));
        }

        [TestMethod]
        public void TestGOMHomeLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestLoad(browser, Constants.GOMobileWebHost));
        }
        #endregion

        #region "HOME PAGES TITLES ARE OK"

        [TestMethod]
        public void TestGSHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestTitleLoad(browser, Constants.GSWebHost, Constants.GSWebHostTitle));
        }

        [TestMethod]
        public void TestGSMHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestTitleLoad(browser, Constants.GSMobileWebHost, Constants.GSMobileWebHostTitle));
        }

        [TestMethod]
        public void TestGDHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestTitleLoad(browser, Constants.GDWebHost, Constants.GDWebHostTitle));
        }

        [TestMethod]
        public void TestGDMHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestTitleLoad(browser, Constants.GDMobileWebHost, Constants.GDMobileWebHostTitle));
        }

        [TestMethod]
        public void TestGOHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestTitleLoad(browser, Constants.GOWebHost, Constants.GOWebHostTitle));
        }

        [TestMethod]
        public void TestGOMHomeTitleLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestTitleLoad(browser, Constants.GOMobileWebHost, Constants.GOMobileWebHostTitle));
        }

        #endregion

        #region "HOME PAGES HEADER TEXT ARE OK"

        [TestMethod]
        public void TestGSHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestHeaderTextLoad(browser, Constants.GSWebHost, Layout.GSTitleImg));
        }

        [TestMethod]
        public void TestGSMHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestHeaderTextLoad(browser, Constants.GSMobileWebHost, Layout.GSMTitleImg));
        }

        [TestMethod]
        public void TestGDHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestHeaderTextLoad(browser, Constants.GDWebHost, Layout.GDTitleImg));
        }

        [TestMethod]
        public void TestGDMHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestHeaderTextLoad(browser, Constants.GDMobileWebHost, Layout.GDMTitleImg));
        }

        [TestMethod]
        public void TestGOHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestHeaderTextLoad(browser, Constants.GOWebHost, Layout.GOTitleImg));
        }

        [TestMethod]
        public void TestGOMHomeHeaderTextLoad()
        {
            Assert.IsTrue(SeleniumFireFoxUtils.TestHeaderTextLoad(browser, Constants.GOMobileWebHost, Layout.GOMTitleImg));
        }

        #endregion

        //#region "HOME PAGES MENU COLORS ARE OK"

        //[TestMethod]
        //public void TestGSHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumFireFoxUtils.TestMenuColorsLoad(browser, Constants.GSWebHost, Layout.GSleftMenuFColor.ToRgbString, Layout.GSleftMenuBColor.ToRgbString));
        //}

        ////[TestMethod]
        //public void TestGSMHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumFireFoxUtils.TestMenuColorsLoad(browser, Constants.GSMobileWebHost, Layout.GSleftMenuFColor.ToRgbString, Layout.GSleftMenuBColor.ToRgbString));
        //}

        //[TestMethod]
        //public void TestGDHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumFireFoxUtils.TestMenuColorsLoad(browser, Constants.GDWebHost, Layout.GDleftMenuFColor.ToRgbString, Layout.GDleftMenuBColor.ToRgbString));
        //}

        ////[TestMethod]
        //public void TestGDMHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumFireFoxUtils.TestMenuColorsLoad(browser, Constants.GDMobileWebHost, Layout.GDleftMenuFColor.ToRgbString, Layout.GDleftMenuBColor.ToRgbString));
        //}

        //[TestMethod]
        //public void TestGOHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumFireFoxUtils.TestMenuColorsLoad(browser, Constants.GOWebHost, Layout.GOleftMenuFColor.ToRgbString, Layout.GOleftMenuBColor.ToRgbString));
        //}

        ////[TestMethod]
        //public void TestGOMHomeMenuColorsLoad()
        //{
        //    Assert.IsTrue(SeleniumFireFoxUtils.TestMenuColorsLoad(browser, Constants.GOMobileWebHost, Layout.GOleftMenuFColor.ToRgbString, Layout.GOleftMenuBColor.ToRgbString));
        //}

        //#endregion
    }
}