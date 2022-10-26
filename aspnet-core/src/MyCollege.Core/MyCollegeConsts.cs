using MyCollege.Debugging;

namespace MyCollege
{
    public class MyCollegeConsts
    {
        public const string LocalizationSourceName = "MyCollege";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "766f13fe811e4607851060ee4564819d";
    }
}
