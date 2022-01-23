using Microsoft.Playwright;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace PlaywrightFramework.Base
{
    public class PlaywrightDriver
    {
        public virtual string PagePath { get; private set; }
        public virtual string Domain => TestContext.Parameters["AppUrl"];

        public static IPage Page { get; set; }

        public static BrowserTypeLaunchOptions ChromeOptions = new()
        {
            Headless = System.Convert.ToBoolean(Environment.GetEnvironmentVariable("HEADED")),
            SlowMo = 0
        };

        public static BrowserTypeLaunchOptions FirefoxOptions = new()
        {
            Headless = System.Convert.ToBoolean(Environment.GetEnvironmentVariable("HEADED")),
            SlowMo = 0
        };

        public static BrowserTypeLaunchOptions SafariOptions = new()
        {
            
            Headless = System.Convert.ToBoolean(Environment.GetEnvironmentVariable("HEADED")),
            SlowMo = 0
        };

        public static async Task<IPage> InitalizePlaywright(string passBrowserType)
        {
            var playwright = await Playwright.CreateAsync();

            IBrowser browser = passBrowserType switch
            {
                "Chrome" => await playwright.Chromium.LaunchAsync(ChromeOptions),
                "Firefox" => await playwright.Firefox.LaunchAsync(FirefoxOptions),
                "Safari" => await playwright.Firefox.LaunchAsync(FirefoxOptions),
                _ => throw new System.ArgumentException($"The parameter for 'Browser' is not correct, please provide Chrome, Firefox or Safari."),
            };

            Page = await browser.NewPageAsync();

            return Page;
        }

        private string CompleteUrl => $"{Domain}{PagePath}";

        public async Task OpenURL()
        {
            await Page.GotoAsync(CompleteUrl);
        }
    }
}
