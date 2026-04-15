using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SmokeTestSelenium.WrapperFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeTestSelenium.PageObjects
{
    public class PracticeAdministratorPage : BasePage
    {

        #region Properties

        #region QA

        [FindsBy(How = How.ClassName, Using = "tt-input")]
        [CacheLookup]
        private IWebElement SearchProviderInputQA { get; set; }

        [FindsBy(How = How.ClassName, Using = "pretend-doctor")]
        [CacheLookup]
        private IWebElement SelectProviderQA { get; set; }

        #endregion

        #region DEMO

        [FindsBy(How = How.ClassName, Using = "tt-input")]
        [CacheLookup]
        private IWebElement SearchProviderInputDEMO { get; set; }

        [FindsBy(How = How.ClassName, Using = "pretend-doctor")]
        [CacheLookup]
        private IWebElement SelectProviderDEMO { get; set; }

        #endregion

        #region PRD

        [FindsBy(How = How.ClassName, Using = "tt-input")]
        [CacheLookup]
        private IWebElement SearchProviderInputPRD { get; set; }

        [FindsBy(How = How.ClassName, Using = "pretend-doctor")]
        [CacheLookup]
        private IWebElement SelectProviderPRD { get; set; }

        #endregion

        #endregion

        #region Constructor
        public PracticeAdministratorPage()
        {
            Driver = BrowserFactory.Driver;
        }

        public PracticeAdministratorPage(IWebDriver driver, Setup.Settings setup)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            this.Setup = setup;
        }

        #endregion

        #region Methods

        public void SearchProviderQA(Int16 module, String Connection)
        {
            SearchProviderInputQA.SendKeys("Rebecca ");
            //wait until
            SelectProviderQA.Click();
        }
        public void SearchProviderDEMO(Int16 module, String Connection)
        {
            SearchProviderInputDEMO.SendKeys("Rebecca ");
            //wait until
            SelectProviderDEMO.Click();
        }
        public void SearchProviderPRD(Int16 module, String Connection)
        {
            SearchProviderInputPRD.SendKeys("Rebecca ");
            //wait until
            SelectProviderPRD.Click();
        }

        #endregion

    }
}
