using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SmokeTestSelenium.WrapperFactory;

namespace SmokeTestSelenium.PageObjects
{
    public class LoginPage : BasePage
    {
        #region Properties

        #region QA

        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement EmailInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement PasswordInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "btn-login")]
        [CacheLookup]
        private IWebElement LoginBtnQA { get; set; }

        #endregion

        #region DEMO

        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement EmailInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement PasswordInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "btn-login")]
        [CacheLookup]
        private IWebElement LoginBtnDEMO { get; set; }

        #endregion

        #region PRD

        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement EmailInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement PasswordInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "btn-login")]
        [CacheLookup]
        private IWebElement LoginBtnPRD { get; set; }

        #endregion

        public String message { get; set; }

        #endregion

        #region Constructor
        public LoginPage()
        {
            Driver = BrowserFactory.Driver;
        }

        public LoginPage(IWebDriver driver, Setup.Settings setup)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            this.Setup = setup;
        }
        #endregion

        #region Methods

        public void LoginQA(Int16 module, String Connection)
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
                    EmailInputQA.SendKeys(Convert.ToString(Reader.GetString("UserEmail")));
                    PasswordInputQA.SendKeys(Convert.ToString(Reader.GetString("UserPassword")));

                    Thread.Sleep(1000);
                    LoginBtnQA.Click();
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
        public void LoginDEMO(Int16 module, String Connection)
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
                    EmailInputDEMO.SendKeys(Convert.ToString(Reader.GetString("UserEmail")));
                    PasswordInputDEMO.SendKeys(Convert.ToString(Reader.GetString("UserPassword")));

                    Thread.Sleep(1000);
                    LoginBtnDEMO.Click();
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
        public void LoginPRD(Int16 module, String Connection)
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
                    EmailInputPRD.SendKeys(Convert.ToString(Reader.GetString("UserEmail")));
                    PasswordInputPRD.SendKeys(Convert.ToString(Reader.GetString("UserPassword")));

                    Thread.Sleep(1000);
                    LoginBtnPRD.Click();
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
