using OpenQA.Selenium;
using SmokeTestSelenium.Setup;

namespace SmokeTestSelenium.PageObjects
{
    public class BasePage
    {
        public IWebDriver? Driver;
        public Settings? Setup;
    }
}
