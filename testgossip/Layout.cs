using System;
using System.Text.RegularExpressions;
using WatiN.Core;

namespace testgossip
{
    class Layout: Page
    {
        public static string gossipTitleDiv = "GossipTitle"; 
        public static string gossipTitleImg = "GossipImg";
        public static string GSTitleImg = "http://www.gossipspecials.com/img/GossipSpecialsBadaboom.jpeg";
        public static string GSMTitleImg = "http://m.gossipspecials.com/img/GossipSpecialsBadaboomSml.jpeg";
        public static string GDTitleImg = "http://www.gossipdeals.com/img/GossipDealsLogo.jpg";
        public static string GDMTitleImg = "http://m.gossipdeals.com/img/GossipDealsLogoSml.jpg";
        public static string GOTitleImg = "http://www.gossipoffers.com/img/GossipOffersLogo.jpeg";
        public static string GOMTitleImg = "http://m.gossipoffers.com/img/GossipOffersLogoSml.jpeg";



        public static string leftMenuDiv = "leftmenu";
        public static HtmlColor GSleftMenuBColor = new HtmlColor("#99ccdf");
        public static HtmlColor GSleftMenuFColor = new HtmlColor("#0066cc");

        public static HtmlColor GDleftMenuBColor = new HtmlColor("#a5e57e");
        public static HtmlColor GDleftMenuFColor = new HtmlColor("#498227");

        public static HtmlColor GOleftMenuBColor = new HtmlColor("#b70002");
        public static HtmlColor GOleftMenuFColor = new HtmlColor("#ffffff");

    }
}
