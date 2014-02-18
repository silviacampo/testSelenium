using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;




        //    IWebElement myfieldName = browser.FindElement(By.Id("loginName"));
        //    myfieldName.Clear();
        //    myfieldName.SendKeys("ff");

        //    IWebElement myfieldPassword = browser.FindElement(By.Id("password"));
        //    myfieldPassword.Clear();
        //    myfieldPassword.SendKeys("pp");

        //    IWebElement myfieldSubmit = browser.FindElement(By.Id("submitLogin"));
        //    myfieldSubmit.Submit();

    


namespace testgossip
{
    class SeleniumUtils
    {
        public static bool TestLoad(RemoteWebDriver browser, string webPage)
        {
            browser.Navigate().GoToUrl(webPage);
           return browser.Url.ToString().Equals(webPage);
        }
 
        public static bool TestTitleLoad(RemoteWebDriver browser, string webPage, string webPageTitle)
        {
            browser.Navigate().GoToUrl(webPage);
            return browser.Title.Contains(webPageTitle);
        }

        public static bool TestHeaderTextLoad(RemoteWebDriver browser, string webPage, string webPageTitle)
        {
            browser.Navigate().GoToUrl(webPage);
            string GossipTitleContent = browser.FindElement(By.Id(Layout.gossipTitleDiv)).Text;
                return GossipTitleContent.Equals(webPageTitle);
        }

        public static bool TestMenuColorsLoad(RemoteWebDriver browser, string webPage, string color, string bcolor)
        {
                browser.Navigate().GoToUrl(webPage);
                string BGColor = browser.FindElement(By.Id(Layout.leftMenuDiv)).GetCssValue("background");
                string Color = browser.FindElement(By.Id(Layout.leftMenuDiv)).FindElements(By.TagName("a"))[0].GetCssValue("color");
                return Color.Equals(color) && BGColor.Equals(bcolor);
        }
    }
}
