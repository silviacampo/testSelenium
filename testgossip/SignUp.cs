using System;
using System.Text.RegularExpressions;
using WatiN.Core;

namespace testgossip
{
    class SignUp : Page
    {        
        public static string UsernameInputText = "UserUsername";
        //sibling div class ErrorMessage

        public static string CitySelect = "cityDdl";
        public static string LanguageSelect = "UserLanguage";
        public static string AvatarInputFile = "avatarimage";
        public static string AvatarClearButton = "clearavatarimage";

        public static string PasswordImputText = "UserPassword";
        //sibling div class ErrorMessage

        public static string PasswordConfirmImputText = "UserPasswordConfirm";
        //sibling div class ErrorMessage

        public static string EmailImputText = "UserEmail";
        //sibling div class ErrorMessage

        public static string AlertsInputChBx = "UserAlerts";
        //sibling link href # Click here to open/close filters
        public static string AlertsFiltersDiv = "alerts";
        public static string AlertCategoryChBx = "UserCatAlert";
        public static string AlertLocationChBx = "UserLocAlert";
        public static string AlertKeywordChBx = "UserKeyAlert";

        public static string TermConditionsChBx = "UserTermnconditions";

        //Save is input submit 

        public static HtmlColor ErrorMessageColor = new HtmlColor("#F00");

    }
}