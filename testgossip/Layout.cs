using System;
using System.Text.RegularExpressions;
using WatiN.Core;

namespace testgossip
{
    class Layout: Page
    {
        public static string gossipTitleDiv = "GossipTitle";

        public static string leftMenuDiv = "leftmenu";
        public static HtmlColor GSleftMenuBColor = new HtmlColor("#99ccdf");
        public static HtmlColor GSleftMenuFColor = new HtmlColor("#0066cc");

        public static HtmlColor GDleftMenuBColor = new HtmlColor("#a5e57e");
        public static HtmlColor GDleftMenuFColor = new HtmlColor("#498227");

        public static HtmlColor GOleftMenuBColor = new HtmlColor("#b70002");
        public static HtmlColor GOleftMenuFColor = new HtmlColor("#ffffff");

    }
}
