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

        public static bool TestHeaderTextLoad(RemoteWebDriver browser, string webPage, string webPageTitleImage)
        {
            browser.Navigate().GoToUrl(webPage);
            IWebElement titleImage = browser.FindElement(By.Id(Layout.gossipTitleImg));
            string GossipTitleImage = titleImage.GetCssValue("background-image");
                return GossipTitleImage.Contains(webPageTitleImage);
        }

        public static bool TestMenuColorsLoad(RemoteWebDriver browser, string webPage, string color, string bcolor)
        {
                browser.Navigate().GoToUrl(webPage);
                IWebElement leftmenuDiv = browser.FindElement(By.Id(Layout.leftMenuDiv));
                string BGColor = leftmenuDiv.GetCssValue("background-color");
                IWebElement leftmenuLink = leftmenuDiv.FindElements(By.TagName("a"))[0];
                string Color = leftmenuLink.GetCssValue("color");
                return Color.Equals(color) && BGColor.Equals(bcolor);
        }
    }
}
