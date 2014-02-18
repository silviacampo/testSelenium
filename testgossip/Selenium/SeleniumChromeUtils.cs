﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Chrome;



namespace testgossip.Selenium
{
    class SeleniumChromeUtils
    {
        public static bool TestLoad(ChromeDriver browser, string webPage)
        {
            bool result = false;
            browser = new ChromeDriver();
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

        public static bool TestTitleLoad(ChromeDriver browser, string webPage, string webPageTitle)
        {
            bool result = false;
            browser = new ChromeDriver();
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

        public static bool TestHeaderTextLoad(ChromeDriver browser, string webPage, string webPageTitle)
        {
            bool result = false;
            browser = new ChromeDriver();
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

        public static bool TestMenuColorsLoad(ChromeDriver browser, string webPage, string color, string bgcolor)
        {
            bool result = false;
            browser = new ChromeDriver();
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
