using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;
using System.Threading;

namespace testgossip
{
    class WatinIEUtils
    {
        public static bool TestLoad(IE browser, string webPage)
        {
            bool result = false;
            browser = new IE();
            try
            {
                browser.GoTo(webPage);
                result = browser.Url.Equals(webPage);
            }
            finally
            {
                browser.Close();
            }
            return result;
        }

        public static bool TestTitleLoad(IE browser, string webPage, string webPageTitle)
        {
            bool result = false;
            browser = new IE();
            try
            {
                browser.GoTo(webPage);
                result = browser.Title.Contains(webPageTitle);
            }
            finally
            {
                browser.Close();
            }
            return result;
        }

        public static bool TestHeaderTextLoad(IE browser, string webPage, string webPageTitle)
        {
            bool result = false;
            browser = new IE();
            try
            {
                browser.GoTo(webPage);
                string GossipTitleContent = browser.Div(Find.ById(Layout.gossipTitleDiv)).InnerHtml;
                result = GossipTitleContent.Equals(webPageTitle);
            }
            finally
            {
                browser.Close();
            }
            return result;
        }

        public static bool TestMenuColorsLoad(IE browser, string webPage,HtmlColor color, HtmlColor bcolor)
        {
            bool result = false;
            browser = new IE();
            try
            {
                browser.GoTo(webPage);
                Style menuStyle = browser.Div(Find.ById(Layout.leftMenuDiv)).Style;
                Style menuLinkStyle = browser.Div(Find.ById(Layout.leftMenuDiv)).Links[0].Style;
                HtmlColor menuColor = menuLinkStyle.Color;                
                HtmlColor menuBackColor = menuStyle.BackgroundColor;
                result = menuColor.Equals(color) && menuBackColor.Equals(bcolor);
            }
            finally
            {
                browser.Close();
            }
            return result;
        }

        public static bool TestEmptyLogin(IE browser, string webPage, out string message)
        {
            bool result = true;
            message = "";
            browser = new IE();
            try
            {
                browser.GoTo(webPage);
                browser.Button(Find.ByClass("formbutton")).Click();
                if (browser.Child(Find.ByClass("ErrorMessage")) == null)
                {
                    message = "Error message not displayed";
                    return false;
                }


                browser.GoTo(webPage);
                browser.Div(Find.ById(Login.ForgotPasswordAjaxMessageDiv)).NextSibling.NextSibling.Click();
                Thread.Sleep(1000);
                if (browser.Div(Find.ById(Login.ForgotPasswordAjaxMessageDiv)).InnerHtml == null)
                {
                    message = "Ajax error message not displayed";
                    return false;
                }
            }
            finally
            {
                browser.Close();
            }
            return result;
        }

        public static bool TestInvalidLogin(IE browser, string webPage, out string message)
        {
            bool result = true;
            message = "";
            browser = new IE();
            try
            {
                browser.GoTo(webPage);
                browser.TextField(Find.ById(Login.UsernameInputText)).TypeText("12");
                browser.TextField(Find.ById(Login.PasswordInputText)).TypeText("3456"); 
                browser.Button(Find.ByClass("formbutton")).Click();
                if (browser.Child(Find.ByClass("ErrorMessage")) == null)
                {
                    message = "Error message not displayed";
                    return false;
                }


                browser.GoTo(webPage);
                browser.TextField(Find.ById(Login.ForgotPasswordEmailInputText)).TypeText("123456");
                browser.Div(Find.ById(Login.ForgotPasswordAjaxMessageDiv)).NextSibling.NextSibling.Click();
                Thread.Sleep(1000);
                if (browser.Div(Find.ById(Login.ForgotPasswordAjaxMessageDiv)).InnerHtml == null)
                {
                    message = "Ajax error message not displayed";
                    return false;
                }
            }
            finally
            {
                browser.Close();
            }
            return result;
        }

        public static bool TestInexistantLogin(IE browser, string webPage, out string message)
        {
            bool result = true;
            message = "";
            browser = new IE();
            try
            {
                browser.GoTo(webPage);
                browser.TextField(Find.ById(Login.UsernameInputText)).TypeText("sssssss");
                browser.TextField(Find.ById(Login.PasswordInputText)).TypeText("ppppppppp");
                browser.Button(Find.ByClass("formbutton")).Click();
                if (browser.Child(Find.ByClass("ErrorMessage")) == null)
                {
                    message = "Error message not displayed";
                    return false;
                }


                browser.GoTo(webPage);
                browser.TextField(Find.ById(Login.ForgotPasswordEmailInputText)).TypeText("eeee@eeeeee.com");
                browser.Div(Find.ById(Login.ForgotPasswordAjaxMessageDiv)).NextSibling.NextSibling.Click();
                Thread.Sleep(1000);
                if (browser.Div(Find.ById(Login.ForgotPasswordAjaxMessageDiv)).InnerHtml == null)
                {
                    message = "Ajax error message not displayed";
                    return false;
                }
            }
            finally
            {
                browser.Close();
            }
            return result;
        }

    }

}
