using NUnit.Framework;

namespace TestsUI.Base
{
    public class SettingsConfiguration
    {
        private static string _AppUrl;
        private static string _Browser;

        public static string AppUrl
        {
            get
            {
                if (_AppUrl == null && TestContext.Parameters.Exists("AppUrl"))
                {
                    _AppUrl = TestContext.Parameters["AppUrl"];
                }
                else
                {
                    throw new System.ArgumentException($"The parameter 'AppUrl' was not found, please provide a value for this parameter.");
                }
                return _AppUrl;
            }
        }

        public static string Browser
        {
            get
            {
                if (_Browser == null && TestContext.Parameters.Exists("Browser"))
                {
                    _Browser = TestContext.Parameters["Browser"];
                }
                else
                {
                    throw new System.ArgumentException($"The parameter for 'Browser' was not found, please provide a value for this parameter.");
                }
                return _Browser;
            }
        }
    }
}
