using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Firefox;

namespace testgossip.Selenium
{
    class SeleniumFireFoxUtils
    {
        public static bool TestLoad(FirefoxDriver browser, string webPage)
        {
            bool result = false;
            browser = new FirefoxDriver();
            try
            {
                result = SeleniumUtils.TestLoad(browser, webPage);
            }
            finally
            {
                browser.Quit();
            }
            return result;
        }

        public static bool TestTitleLoad(FirefoxDriver browser, string webPage, string webPageTitle)
        {
            bool result = false;
            browser = new FirefoxDriver();
            try
            {
                result = SeleniumUtils.TestTitleLoad(browser, webPage, webPageTitle);
            }
            finally
            {
                browser.Quit();
            }
            return result;
        }

        public static bool TestHeaderTextLoad(FirefoxDriver browser, string webPage, string webPageTitle)
        {
            bool result = false;
            browser = new FirefoxDriver();
            try
            {
                result = SeleniumUtils.TestHeaderTextLoad(browser, webPage, webPageTitle);
            }
            finally
            {
                browser.Quit();
            }
            return result;
        }

        public static bool TestMenuColorsLoad(FirefoxDriver browser, string webPage, string color, string bgcolor)
        {
            bool result = false;
            browser = new FirefoxDriver();
            try
            {
                result = SeleniumUtils.TestMenuColorsLoad(browser, webPage, color, bgcolor);
            }
            finally
            {
                browser.Quit();
            }
            return result;
        }

    }
}
