﻿using System;
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

        public static bool TestHeaderTextLoad(FirefoxDriver browser, string webPage, string webPageTitleImage)
        {
            bool result = false;
            browser = new FirefoxDriver();
            try
            {
                result = SeleniumUtils.TestHeaderTextLoad(browser, webPage, webPageTitleImage);
            }
            finally
            {
                browser.Quit();
            }
            return result;
        }

        public static bool TestMenuColorsLoad(FirefoxDriver browser, string webPage, string color, string bgcolor, out string message)
        {
            bool result = false;
            browser = new FirefoxDriver();
            try
            {
                result = SeleniumUtils.TestMenuColorsLoad(browser, webPage, color, bgcolor, out message);
            }
            finally
            {
                browser.Quit();
            }
            return result;
        }

    }
}
