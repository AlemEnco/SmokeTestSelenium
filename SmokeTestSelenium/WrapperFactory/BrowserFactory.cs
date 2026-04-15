using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SmokeTestSelenium.WrapperFactory
{
    public class BrowserFactory
    {
        private static readonly IDictionary<string, IWebDriver> Drivers= new Dictionary<string, IWebDriver>();
        private static IWebDriver? driver;

        public static IWebDriver Driver
        {
            get
            {
                if(driver == null)
                {
                    throw new NullReferenceException("The WebDriver browser instance was not initialized. You should first call the method InitBrowser.");
                }
                return driver;
            }
            private set
            {
                driver = value;
            }
        }

        public static void InitBrowser(String browserName)
        {
            switch(browserName)
            {
                case "Firefox":
                    if(driver == null)
                    {
                        driver = new FirefoxDriver();
                    }
                    break;

                case "IE":
                    if(driver == null)
                    {
                        driver = new InternetExplorerDriver();
                    }
                    break;

                case "Chrome":
                    if (driver == null)
                    {
                        ChromeOptions options = new ChromeOptions();
                        options.AddArgument("user-data-dir=C:\\Users\\ALEM\\AppData\\Local\\Google\\Chrome\\User Data\\Default");
                        driver = new ChromeDriver(options);
                        driver.Manage().Window.Maximize();
                        Drivers.Add("Chrome", Driver);
                    }
                    break;
            }
        }

        public static void LoadApplication(Int16 environment)
        {
            switch (environment)
            {
                case 1:
                    Driver.Url = "https://qa.referwell.com/login";
                    break;

                case 2:
                    Driver.Url = "https://demo.referwell.com/login";
                    break;
            }
        }
    }
}