using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;


namespace testgossip.Watin
{
    [TestClass]
    public class HomeIETest
    {
        private IE browser;
 
        #region "HOME PAGES LOAD"

        [TestMethod]
        public void TestGSHomeLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestLoad(browser, Constants.GSWebHost));
        }

        [TestMethod]
        public void TestGSMHomeLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestLoad(browser, Constants.GSMobileWebHost));
        }

        [TestMethod]
        public void TestGDHomeLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestLoad(browser, Constants.GDWebHost));
        }

        [TestMethod]
        public void TestGDMHomeLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestLoad(browser, Constants.GDMobileWebHost));
        }

        [TestMethod]
        public void TestGOHomeLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestLoad(browser, Constants.GOWebHost));
        }

        [TestMethod]
        public void TestGOMHomeLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestLoad(browser, Constants.GOMobileWebHost));
        }

        #endregion

        #region "HOME PAGES TITLES ARE OK"

        [TestMethod]
        public void TestGSHomeTitleLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestTitleLoad(browser, Constants.GSWebHost, Constants.GSWebHostTitle));
        }

        [TestMethod]
        public void TestGSMHomeTitleLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestTitleLoad(browser, Constants.GSMobileWebHost, Constants.GSMobileWebHostTitle));
        }

        [TestMethod]
        public void TestGDHomeTitleLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestTitleLoad(browser, Constants.GDWebHost, Constants.GDWebHostTitle));
        }

        [TestMethod]
        public void TestGDMHomeTitleLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestTitleLoad(browser, Constants.GDMobileWebHost, Constants.GDMobileWebHostTitle));
        }

        [TestMethod]
        public void TestGOHomeTitleLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestTitleLoad(browser, Constants.GOWebHost, Constants.GOWebHostTitle));
        }

        [TestMethod]
        public void TestGOMHomeTitleLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestTitleLoad(browser, Constants.GOMobileWebHost, Constants.GOMobileWebHostTitle));
        }

        #endregion

        #region "HOME PAGES HEADER TEXT ARE OK"

        [TestMethod]
        public void TestGSHomeHeaderTextLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestHeaderTextLoad(browser, Constants.GSWebHost, Constants.GSWebHostTitle));
        }

        [TestMethod]
        public void TestGSMHomeHeaderTextLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestHeaderTextLoad(browser, Constants.GSMobileWebHost, Constants.GSMobileWebHostTitle));
        }

        [TestMethod]
        public void TestGDHomeHeaderTextLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestHeaderTextLoad(browser, Constants.GDWebHost, Constants.GDWebHostTitle));
        }

        [TestMethod]
        public void TestGDMHomeHeaderTextLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestHeaderTextLoad(browser, Constants.GDMobileWebHost, Constants.GDMobileWebHostTitle));
        }

        [TestMethod]
        public void TestGOHomeHeaderTextLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestHeaderTextLoad(browser, Constants.GOWebHost, Constants.GOWebHostTitle));
        }

        [TestMethod]
        public void TestGOMHomeHeaderTextLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestHeaderTextLoad(browser, Constants.GOMobileWebHost, Constants.GOMobileWebHostTitle));
        }

        #endregion

        #region "HOME PAGES MENU COLORS ARE OK"

        [TestMethod]
        public void TestGSHomeMenuColorsLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestMenuColorsLoad(browser, Constants.GSWebHost, Layout.GSleftMenuFColor, Layout.GSleftMenuBColor));
        }

        //[TestMethod]
        public void TestGSMHomeMenuColorsLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestMenuColorsLoad(browser, Constants.GSMobileWebHost, Layout.GSleftMenuFColor, Layout.GSleftMenuBColor));
        }

        [TestMethod]
        public void TestGDHomeMenuColorsLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestMenuColorsLoad(browser, Constants.GDWebHost, Layout.GDleftMenuFColor, Layout.GDleftMenuBColor));
        }

        //[TestMethod]
        public void TestGDMHomeMenuColorsLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestMenuColorsLoad(browser, Constants.GDMobileWebHost, Layout.GDleftMenuFColor, Layout.GDleftMenuBColor));
        }

        [TestMethod]
        public void TestGOHomeMenuColorsLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestMenuColorsLoad(browser, Constants.GOWebHost, Layout.GOleftMenuFColor, Layout.GOleftMenuBColor));
        }

        //[TestMethod]
        public void TestGOMHomeMenuColorsLoad()
        {
            Assert.IsTrue(WatinIEUtils.TestMenuColorsLoad(browser, Constants.GOMobileWebHost, Layout.GOleftMenuFColor, Layout.GOleftMenuBColor));
        }

        #endregion
    }
}
