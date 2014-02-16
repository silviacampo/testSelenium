using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WatiN.Core;

namespace testgossip
{
    class WatinIEUtils
    {
        public static bool TestLoad(IE browser, string webHost)
        {
            bool result = false;
            browser = new IE();
            try
            {
                browser.GoTo(Constants.GSWebHost);
                result = browser.Url.Equals(Constants.GSWebHost);
            }
            finally
            {
                browser.Close();
            }
            return result;
        }

        public static bool TestTitleLoad(IE browser, string webHost, string webHostTitle)
        {
            bool result = false;
            browser = new IE();
            try
            {
                browser.GoTo(webHost);
                result = browser.Title.Contains(webHostTitle);
            }
            finally
            {
                browser.Close();
            }
            return result;
        }

        public static bool TestHeaderTextLoad(IE browser, string webHost, string webHostTitle)
        {
            bool result = false;
            browser = new IE();
            try
            {
                browser.GoTo(webHost);
                string GossipTitleContent = browser.Div(Find.ById(Layout.gossipTitleDiv)).InnerHtml;
                result = GossipTitleContent.Equals(webHostTitle);
            }
            finally
            {
                browser.Close();
            }
            return result;
        }

        public static bool TestMenuColorsLoad(IE browser, string webHost,HtmlColor color, HtmlColor bcolor)
        {
            bool result = false;
            browser = new IE();
            try
            {
                browser.GoTo(webHost);
                Style menuStyle = browser.Div(Find.ById(Layout.leftMenuDiv)).Style;
                HtmlColor menuColor = menuStyle.Color;
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
