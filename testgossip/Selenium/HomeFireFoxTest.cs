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
        private IWebDriver driver;

        #region "HOME PAGES LOAD"

        [TestMethod]
        public void TestGSHomeLoad()
        {
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            try
            {
                driver.Navigate().GoToUrl(Constants.GSWebHost);
                Assert.AreEqual(driver.Url.ToString(), Constants.GSWebHost);
            }
            finally
            {
                driver.Quit();
            }
        }

        [TestMethod]
        public void TestGSMHomeLoad()
        {
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            try
            {
                driver.Navigate().GoToUrl(Constants.GSMobileWebHost);
                Assert.AreEqual(driver.Url.ToString(), Constants.GSMobileWebHost);
            }
            finally
            {
                driver.Quit();
            }
        }

        [TestMethod]
        public void TestGDHomeLoad()
        {
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            try
            {
                driver.Navigate().GoToUrl(Constants.GDWebHost);
                Assert.AreEqual(driver.Url.ToString(), Constants.GDWebHost);
            }
            finally
            {
                driver.Quit();
            }
        }

        [TestMethod]
        public void TestGDMHomeLoad()
        {
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            try
            {
                driver.Navigate().GoToUrl(Constants.GDMobileWebHost);
                Assert.AreEqual(driver.Url.ToString(), Constants.GDMobileWebHost);
            }
            finally
            {
                driver.Quit();
            }
        }

        [TestMethod]
        public void TestGOHomeLoad()
        {
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            try
            {
                driver.Navigate().GoToUrl(Constants.GOWebHost);
                Assert.AreEqual(driver.Url.ToString(), Constants.GOWebHost);
            }
            finally
            {
                driver.Quit();
            }
        }

        [TestMethod]
        public void TestGOMHomeLoad()
        {
            driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
            try
            {
                driver.Navigate().GoToUrl(Constants.GOMobileWebHost);
                Assert.AreEqual(driver.Url.ToString(), Constants.GOMobileWebHost);
            }
            finally
            {
                driver.Quit();
            }
        }

        #endregion


        //[TestMethod]
        //public void TestMethodLoginFail()
        //{
        //    //OpenQA.Selenium.Firefox..InternetExplorerOptions ieo = new OpenQA.Selenium.IE.InternetExplorerOptions();
        //    //ieo.IgnoreZoomLevel = true;
        //    driver = new OpenQA.Selenium.Firefox.FirefoxDriver();
        //    driver.Navigate().GoToUrl(localhost);

        //    IWebElement myfieldName = driver.FindElement(By.Id("loginName"));
        //    myfieldName.Clear();
        //    myfieldName.SendKeys("ff");

        //    IWebElement myfieldPassword = driver.FindElement(By.Id("password"));
        //    myfieldPassword.Clear();
        //    myfieldPassword.SendKeys("pp");

        //    IWebElement myfieldSubmit = driver.FindElement(By.Id("submitLogin"));
        //    myfieldSubmit.Submit();

        //    Assert.AreEqual(driver.Url.ToString(), localhost + "Login.aspx?ReturnUrl=%2fdefault.aspx%3f");

        //    driver.Quit();
        //}
    }
}
