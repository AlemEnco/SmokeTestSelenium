using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SmokeTestSelenium.WrapperFactory;

namespace SmokeTestSelenium.PageObjects
{
    public class YodaPage : BasePage
    {
        #region Properties

        #region QA

        [FindsBy(How = How.XPath, Using = "//*[@id='side-menu']/li[3]/a")]
        [CacheLookup]
        private IWebElement DoctorsOptionQA { get; set; }

        [FindsBy(How = How.Id, Using = "doctor-search")]
        [CacheLookup]
        private IWebElement NameInputQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='doctors-management-table']/tbody/tr[1]/td[6]/a")]
        [CacheLookup]
        private IWebElement BecomeBtnQA { get; set; }

        #endregion

        #region DEMO

        [FindsBy(How = How.XPath, Using = "//*[@id='side-menu']/li[3]/a")]
        [CacheLookup]
        private IWebElement DoctorsOptionDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "doctor-search")]
        [CacheLookup]
        private IWebElement NameInputDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='doctors-management-table']/tbody/tr[1]/td[6]/a")]
        [CacheLookup]
        private IWebElement BecomeBtnDEMO { get; set; }

        #endregion

        #region PRD

        [FindsBy(How = How.XPath, Using = "//*[@id='side-menu']/li[3]/a")]
        [CacheLookup]
        private IWebElement DoctorsOptionPRD { get; set; }

        [FindsBy(How = How.Id, Using = "doctor-search")]
        [CacheLookup]
        private IWebElement NameInputPRD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='doctors-management-table']/tbody/tr[1]/td[6]/a")]
        [CacheLookup]
        private IWebElement BecomeBtnPRD { get; set; }

        #endregion

        public String message { get; set; }

        #endregion

        #region Constructor
        public YodaPage()
        {
            Driver = BrowserFactory.Driver;
        }

        public YodaPage(IWebDriver driver, Setup.Settings setup)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            this.Setup = setup;
        }
        #endregion

        #region Methods

        public void BecomeProviderQA(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 2;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    Reader.ReadAsync();
                    Thread.Sleep(this.Setup.SmWaitTime);
                    DoctorsOptionQA.Click();
                    NameInputQA.SendKeys("Rebecca");
                    NameInputQA.SendKeys(Keys.Enter);

                    Thread.Sleep(1000);
                    BecomeBtnPRD.Click();
                }
                else
                {
                    message = "the query is empty";
                    Assert.Fail(message);
                }
            }
            catch (MySqlException ex)
            {
                message = ex.Message;

                Assert.Fail(message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void BecomeProviderDEMO(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 2;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    Reader.ReadAsync();
                    Thread.Sleep(this.Setup.SmWaitTime);
                    DoctorsOptionDEMO.Click();
                    NameInputDEMO.SendKeys("Rebecca");
                    NameInputDEMO.SendKeys(Keys.Enter);

                    Thread.Sleep(1000);
                    BecomeBtnDEMO.Click();
                }
                else
                {
                    message = "the query is empty";
                    Assert.Fail(message);
                }
            }
            catch (MySqlException ex)
            {
                message = ex.Message;

                Assert.Fail(message);
            }
            finally
            {
                connection.Close();
            }
        }
        public void BecomeProviderPRD(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 2;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    Reader.ReadAsync();
                    Thread.Sleep(this.Setup.SmWaitTime);
                    DoctorsOptionPRD.Click();
                    NameInputPRD.SendKeys("Rebecca");
                    NameInputPRD.SendKeys(Keys.Enter);

                    Thread.Sleep(1000);
                    BecomeBtnPRD.Click();
                }
                else
                {
                    message = "the query is empty";
                    Assert.Fail(message);
                }
            }
            catch (MySqlException ex)
            {
                message = ex.Message;

                Assert.Fail(message);
            }
            finally
            {
                connection.Close();
            }
        }

        #endregion
    }
}