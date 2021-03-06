﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WatiN.Core;

namespace testgossip.Watin
{
    //Only run in FF2 to 3.6
    //[TestClass]
    public class HomeFireFoxTest
    {
        private FireFox browser;

        #region "HOME PAGES LOAD"

        //[TestMethod]
        public void TestGSHomeLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GSWebHost);
                Assert.AreEqual(browser.Url, Constants.GSWebHost);
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGSMHomeLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GSMobileWebHost);
                Assert.AreEqual(browser.Url, Constants.GSMobileWebHost);
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGDHomeLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GDWebHost);
                Assert.AreEqual(browser.Url, Constants.GDWebHost);
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGDMHomeLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GDMobileWebHost);
                Assert.AreEqual(browser.Url, Constants.GDMobileWebHost);
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGOHomeLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GOWebHost);
                Assert.AreEqual(browser.Url, Constants.GOWebHost);
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGOMHomeLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GOMobileWebHost);
                Assert.AreEqual(browser.Url, Constants.GOMobileWebHost);
            }
            finally
            {
                browser.Close();
            }
        }

        #endregion

        #region "HOME PAGES TITLES ARE OK"

        //[TestMethod]
        public void TestGSHomeTitleLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GSWebHost);
                Assert.IsTrue(browser.Title.Contains(Constants.GSWebHostTitle));
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGSMHomeTitleLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GSMobileWebHost);
                Assert.IsTrue(browser.Title.Contains(Constants.GSMobileWebHostTitle));
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGDHomeTitleLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GDWebHost);
                Assert.IsTrue(browser.Title.Contains(Constants.GDWebHostTitle));
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGDMHomeTitleLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GDMobileWebHost);
                Assert.IsTrue(browser.Title.Contains(Constants.GDMobileWebHostTitle));
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGOHomeTitleLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GOWebHost);
                Assert.IsTrue(browser.Title.Contains(Constants.GOWebHostTitle));
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGOMHomeTitleLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GOMobileWebHost);
                Assert.IsTrue(browser.Title.Contains(Constants.GOMobileWebHostTitle));
            }
            finally
            {
                browser.Close();
            }
        }

        #endregion

        #region "HOME PAGES HEADER TEXT ARE OK"

        //[TestMethod]
        public void TestGSHomeHeaderTextLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GSWebHost);
                string GossipTitleContent = browser.Div(Find.ById("GossipTitle")).InnerHtml;
                Assert.AreEqual(GossipTitleContent, Constants.GSWebHostTitle);
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGSMHomeHeaderTextLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GSMobileWebHost);
                string GossipTitleContent = browser.Div(Find.ById("GossipTitle")).InnerHtml;
                Assert.AreEqual(GossipTitleContent, Constants.GSMobileWebHostTitle);
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGDHomeHeaderTextLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GDWebHost);
                string GossipTitleContent = browser.Div(Find.ById("GossipTitle")).InnerHtml;
                Assert.AreEqual(GossipTitleContent, Constants.GDWebHostTitle);
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGDMHomeHeaderTextLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GDMobileWebHost);
                string GossipTitleContent = browser.Div(Find.ById("GossipTitle")).InnerHtml;
                Assert.AreEqual(GossipTitleContent, Constants.GDMobileWebHostTitle);
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGOHomeHeaderTextLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GOWebHost);
                string GossipTitleContent = browser.Div(Find.ById("GossipTitle")).InnerHtml;
                Assert.AreEqual(GossipTitleContent, Constants.GOWebHostTitle);
            }
            finally
            {
                browser.Close();
            }
        }

        //[TestMethod]
        public void TestGOMHomeHeaderBGImageLoad()
        {
            browser = new FireFox();
            try
            {
                browser.GoTo(Constants.GOMobileWebHost);
                string GossipTitleContent = browser.Div(Find.ById("GossipTitle")).InnerHtml;
                Assert.AreEqual(GossipTitleContent, Constants.GOMobileWebHostTitle);
            }
            finally
            {
                browser.Close();
            }
        }

        #endregion

     }
}
