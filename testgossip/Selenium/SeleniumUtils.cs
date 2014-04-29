using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System.Threading;




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

        public static bool TestMenuColorsLoad(RemoteWebDriver browser, string webPage, string color, string bcolor, out string message)
        {
                browser.Navigate().GoToUrl(webPage);
                IWebElement leftmenuDiv = browser.FindElement(By.Id(Layout.leftMenuDiv));
                string BGColor = leftmenuDiv.GetCssValue("background-color");
                IWebElement leftmenuLink = leftmenuDiv.FindElements(By.TagName("a"))[0];
                string Color = leftmenuLink.GetCssValue("color");
            message = "The color " +  Color + " is equal to " + color + " and the backgroundColor " + BGColor + " is equals to " + bcolor;
                return Color.Equals(color) && BGColor.Equals(bcolor);
        }

        public static bool TestEmptyLogin(RemoteWebDriver browser, string webPage, out string message)
        {
            bool result = true;
            message = "";

                browser.Navigate().GoToUrl(webPage);
                browser.FindElementByClassName("formbutton").Submit();
                if (browser.FindElementByClassName("ErrorMessage") == null)
                {
                    message = "Error message not displayed";
                    return false;
                }


                browser.Navigate().GoToUrl(webPage);
                browser.FindElement(By.XPath("//div[@id='" + Login.ForgotPasswordAjaxMessageDiv + "']/following-sibling::button[last()]")).Submit();
                Thread.Sleep(1000);
                if (browser.FindElementById(Login.ForgotPasswordAjaxMessageDiv).GetAttribute("innerHTML") == String.Empty)
                {
                    message = "Ajax error message not displayed";
                    return false;
                }

            return result;
        }

        public static bool TestInvalidLogin(RemoteWebDriver browser, string webPage, out string message)
        {
            bool result = true;
            message = "";
            browser.Navigate().GoToUrl(webPage);
                //browser.TextField(Find.ById(Login.UsernameInputText)).TypeText("12");
                //browser.TextField(Find.ById(Login.PasswordInputText)).TypeText("3456");
                //browser.Button(Find.ByClass("formbutton")).Click();
                //if (browser.Child(Find.ByClass("ErrorMessage")) == null)
                //{
                //    message = "Error message not displayed";
                //    return false;
                //}


                //browser.Navigate().GoToUrl(webPage);
                //browser.TextField(Find.ById(Login.ForgotPasswordEmailInputText)).TypeText("123456");
                //browser.Div(Find.ById("ajaxMessage")).NextSibling.NextSibling.Click();
                //Thread.Sleep(1000);
                //if (browser.Div(Find.ById("ajaxMessage")).InnerHtml == null)
                //{
                //    message = "Ajax error message not displayed";
                //    return false;
                //}

            return result;
        }

        public static bool TestInexistantLogin(RemoteWebDriver browser, string webPage, out string message)
        {
            bool result = true;
            message = "";
            browser.Navigate().GoToUrl(webPage);
                //browser.TextField(Find.ById(Login.UsernameInputText)).TypeText("sssssss");
                //browser.TextField(Find.ById(Login.PasswordInputText)).TypeText("ppppppppp");
                //browser.Button(Find.ByClass("formbutton")).Click();
                //if (browser.Child(Find.ByClass("ErrorMessage")) == null)
                //{
                //    message = "Error message not displayed";
                //    return false;
                //}


                //browser.Navigate().GoToUrl(webPage);
                //browser.TextField(Find.ById(Login.ForgotPasswordEmailInputText)).TypeText("eeee@eeeeee.com");
                //browser.Div(Find.ById("ajaxMessage")).NextSibling.NextSibling.Click();
                //Thread.Sleep(1000);
                //if (browser.Div(Find.ById("ajaxMessage")).InnerHtml == null)
                //{
                //    message = "Ajax error message not displayed";
                //    return false;
                //}

            return result;
        }


    
    }
}
