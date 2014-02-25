using System;
using System.Text.RegularExpressions;
using WatiN.Core;

namespace testgossip
{
    class Login : Page
    {
        //p class ErrorMessage color #F00
        public static string UsernameInputText = "UserUsername";
        public static string PasswordInputText = "UserPassword";
        //Submit is input submit class formbutton
        public static string ForgotPasswordAjaxMessageDiv = "ajaxMessage"; // class message color #900
        public static string ForgotPasswordEmailInputText = "UserForgotpassemail";
        //Send is button submit

        public static HtmlColor ErrorMessageColor = new HtmlColor("#F00");
        public static HtmlColor AjaxMessageColor = new HtmlColor("#900");

    }
}
