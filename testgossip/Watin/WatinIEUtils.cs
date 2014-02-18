using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;

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
    }
}
