﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Safari;

namespace testgossip.Selenium
{
    class SeleniumSafariUtils
    {
        public static bool TestLoad(SafariDriver browser, string webPage)
        {
            bool result = false;
            browser = new SafariDriver();
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

        public static bool TestTitleLoad(SafariDriver browser, string webPage, string webPageTitle)
        {
            bool result = false;
            browser = new SafariDriver();
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

        public static bool TestHeaderTextLoad(SafariDriver browser, string webPage, string webPageTitleImage)
        {
            bool result = false;
            browser = new SafariDriver();
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

        public static bool TestMenuColorsLoad(SafariDriver browser, string webPage, string color, string bgcolor, out string message)
        {
            bool result = false;
            browser = new SafariDriver();
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


        public static bool TestEmptyLogin(SafariDriver browser, string webPage, out string message)
        {
            bool result = false;
            browser = new SafariDriver();
            try
            {
                result = SeleniumUtils.TestEmptyLogin(browser, webPage, out message);
            }
            finally
            {
                browser.Quit();
            }
            return result;
        }
    }
}
