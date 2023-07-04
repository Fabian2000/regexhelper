namespace RegExHelper
{
    public static class RegExPrepared
    {
        public static string FindPassword { get => /*lang=regex*/"(?=.*[a-z]+.*)(?=.*[A-Z]+.*)(?=.*\\d+.*)(?=.*\\W.*).{8,}"; }
        public static string FindURL { get => /*lang=regex*/"(http(s)?:\\/\\/)?(\\d\\d\\d\\.\\d\\d\\d\\.\\d\\d\\d\\.\\d\\d\\d|([a-zA-Z0-9-_äöüß]+\\.)+[a-zA-Z0-9-_äöüß]+|[a-zA-Z0-9-_äöüß]+)(:\\d+)?((\\/\\w+)*)?\\/?(\\?((?=\\S).(=|&)?)*)?(#([\\w\\d]+)?)?"; }
        public static string FindEmail { get => /*lang=regex*/"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}"; }
        public static string FindDateYYYYMMDD { get => /*lang=regex*/"\\d{4}-\\d{2}-\\d{2}"; }
        public static string FindIPv4 { get => /*lang=regex*/"(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)"; }
        public static string FindUsername { get => /*lang=regex*/"[a-zA-Z0-9_-]{3,16}"; }
        public static string FindHexColor { get => /*lang=regex*/"#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})"; }
        public static string FindPhoneSimple { get => /*lang=regex*/"#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})"; }
        public static string FindPhoneUS { get => /*lang=regex*/"\\+?1?\\s*\\(?([2-9][0-8][0-9])\\)?[-.\\s]?([2-9][0-9]{2})[-.\\s]?([0-9]{4})"; }
        public static string FindPhoneDE { get => /*lang=regex*/"\\+?49\\s?\\(?([0-9]{2,3})\\)?[-.\\s]?([0-9]{2,4})[-.\\s]?([0-9]{2,4})"; }
        public static string FindPhoneUK { get => /*lang=regex*/"\\+?44\\s?\\(?([0-9]{4})\\)?[-.\\s]?([0-9]{3})[-.\\s]?([0-9]{4})"; }
        public static string FindPhoneFR { get => /*lang=regex*/"\\+?33\\s?\\(?([0-9]{1})\\)?[-.\\s]?([0-9]{2})[-.\\s]?([0-9]{2})[-.\\s]?([0-9]{2})[-.\\s]?([0-9]{2})"; }
        public static string FindPhoneCA { get => /*lang=regex*/"\\+?1?\\s?\\(?([2-9][0-9]{2})\\)?[-.\\s]?([0-9]{3})[-.\\s]?([0-9]{4})"; }
        public static string FindIBAN { get => /*lang=regex*/"[A-Z]{2}\\d{2}[A-Z0-9]{1,30}"; }
        public static string FindCreditCard { get => /*lang=regex*/"\\d{12,19}"; }
        public static string FindSocialSecurityNumber { get => /*lang=regex*/"\\d{3}-\\d{2}-\\d{4}"; }
        public static string FindIPv6 { get => /*lang=regex*/"([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}"; }
        public static string FindISBN { get => /*lang=regex*/"(ISBN(?:-10)?:?\\ ?)?(?=[0-9X]{10}$|(?=(?:[0-9]+[-\\ ]){3})[-\\ 0-9X]{13}$|97[89][0-9]{10}$|(?=(?:[0-9]+[-\\ ]){4})[-\\ 0-9]{17}$)(?:97[89][- ]?)?[0-9]{1,5}[- ]?[0-9]+[- ]?[0-9]+[- ]?[0-9X]"; }
        public static string FindPostcodeUS { get => /*lang=regex*/"\\d{5}(-\\d{4})?"; }
        public static string FindPostcodeDE { get => /*lang=regex*/"\\d{5}"; }
        public static string FindPostcodeUK { get => /*lang=regex*/"[A-Z]{1,2}\\d[A-Z\\d]? \\d[A-Z]{2}"; }
        public static string FindPostcodeFR { get => /*lang=regex*/"\\d{5}"; }
        public static string FindPostcodeCA { get => /*lang=regex*/"[A-Z]\\d[A-Z] \\d[A-Z]\\d"; }
        public static string FindTimeHHMM { get => /*lang=regex*/"([01]\\d|2[0-3]):([0-5]\\d)"; }

        public static string ValidatePassword { get => $"^{FindPassword}$"; }
        public static string ValidateURL { get => $"^{FindURL}$"; }
        public static string ValidateEmail { get => $"^{FindEmail}$"; }
        public static string ValidateDateYYYYMMDD { get => $"^{FindDateYYYYMMDD}$"; }
        public static string ValidateIPv4 { get => $"^{FindIPv4}$"; }
        public static string ValidateUsername { get => $"^{FindUsername}$"; }
        public static string ValidateHexColor { get => $"^{FindHexColor}$"; }
        public static string ValidatePhoneSimple { get => $"^{FindPhoneSimple}$"; }
        public static string ValidatePhoneUS { get => $"^{FindPhoneUS}$"; }
        public static string ValidatePhoneDE { get => $"^{FindPhoneDE}$"; }
        public static string ValidatePhoneUK { get => $"^{FindPhoneUK}$"; }
        public static string ValidatePhoneFR { get => $"^{FindPhoneFR}$"; }
        public static string ValidatePhoneCA { get => $"^{FindPhoneCA}$"; }
        public static string ValidateIBAN { get => $"^{FindIBAN}$"; }
        public static string ValidateCreditCard { get => $"^{FindCreditCard}$"; }
        public static string ValidateSocialSecurityNumber { get => $"^{FindSocialSecurityNumber}$"; }
        public static string ValidateIPv6 { get => $"^{FindIPv6}$"; }
        public static string ValidateISBN { get => $"^{FindISBN}$"; }
        public static string ValidatePostcodeUS { get => $"^{FindPostcodeUS}$"; }
        public static string ValidatePostcodeDE { get => $"^{FindPostcodeDE}$"; }
        public static string ValidatePostcodeUK { get => $"^{FindPostcodeUK}$"; }
        public static string ValidatePostcodeFR { get => $"^{FindPostcodeFR}$"; }
        public static string ValidatePostcodeCA { get => $"^{FindPostcodeCA}$"; }
        public static string ValidateTimeHHMM { get => $"^{FindTimeHHMM}$"; }
    }
}