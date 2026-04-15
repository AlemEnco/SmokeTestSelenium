using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using SmokeTestSelenium.WrapperFactory;

namespace SmokeTestSelenium.PageObjects
{
    public class PrintPage : BasePage
    {
        #region Properties

        #region QA

        [FindsBy(How = How.ClassName, Using = "print_button")]
        [CacheLookup]
        private IWebElement ReturnDashboardQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-navbar']/ul/li[9]/a")]
        [CacheLookup]
        private IWebElement LogoutBtnQA { get; set; }

        #endregion

        #region DEMO

        [FindsBy(How = How.ClassName, Using = "print_button")]
        [CacheLookup]
        private IWebElement ReturnDashboardDEMO { get; set; }

        #endregion

        #region PRD

        [FindsBy(How = How.ClassName, Using = "print_button")]
        [CacheLookup]
        private IWebElement ReturnDashboardPRD { get; set; }

        #endregion

        public String message { get; set; }
        public String GoDashboard { get; set; }

        #endregion

        #region Constructor

        public PrintPage()
        {
            Driver = BrowserFactory.Driver;
        }

        public PrintPage(IWebDriver driver, Setup.Settings setup)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            this.Setup = setup;
        }

        #endregion

        #region Methods

        public void ValidarQA(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 9;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows) {

                    Reader.ReadAsync();
                    GoDashboard = Convert.ToString(Reader.GetString("GoDashboard"));

                    if (GoDashboard == "1")
                    {
                        ReturnDashboardQA.Click();
                    }
                    else
                    {
                        try
                        {
                            if (isAlertPresent())
                            {
                                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1000));
                                wait.Until(ExpectedConditions.AlertIsPresent());

                                IAlert alert = Driver.SwitchTo().Alert();
                                alert.Accept();

                                if (this.Driver.FindElements(By.ClassName("print_button")).Count != 0)
                                {
                                    Assert.Pass();
                                }
                                else
                                {
                                    Assert.Fail();
                                }
                            }
                            else
                            {
                                if (this.Driver.FindElements(By.ClassName("print_button")).Count != 0)
                                {
                                    Assert.Pass();
                                }
                                else
                                {
                                    Assert.Fail();
                                }
                            }
                        }
                        catch (UnhandledAlertException u)
                        {
                            Assert.Fail();
                        }
                    }                    
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
        public void ValidarDEMO(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 9;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {

                    Reader.ReadAsync();
                    GoDashboard = Convert.ToString(Reader.GetString("GoDashboard"));

                    if (GoDashboard == "1")
                    {
                        ReturnDashboardDEMO.Click();
                    }
                    else
                    {
                        try
                        {
                            if (isAlertPresent())
                            {
                                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1000));
                                wait.Until(ExpectedConditions.AlertIsPresent());

                                IAlert alert = Driver.SwitchTo().Alert();
                                alert.Accept();

                                if (this.Driver.FindElements(By.ClassName("print_button")).Count != 0)
                                {
                                    Assert.Pass();
                                }
                                else
                                {
                                    Assert.Fail();
                                }
                            }
                            else
                            {
                                if (this.Driver.FindElements(By.ClassName("print_button")).Count != 0)
                                {
                                    Assert.Pass();
                                }
                                else
                                {
                                    Assert.Fail();
                                }
                            }
                        }
                        catch (UnhandledAlertException u)
                        {
                            Assert.Fail();
                        }
                    }
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
        public void ValidarPRD(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 9;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {

                    Reader.ReadAsync();
                    GoDashboard = Convert.ToString(Reader.GetString("GoDashboard"));

                    if (GoDashboard == "1")
                    {
                        ReturnDashboardPRD.Click();
                    }
                    else
                    {
                        try { 
                            if (isAlertPresent())
                            {
                                WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(1000));
                                wait.Until(ExpectedConditions.AlertIsPresent());

                                IAlert alert = Driver.SwitchTo().Alert();
                                alert.Accept();

                                if (this.Driver.FindElements(By.ClassName("print_button")).Count != 0)
                                {
                                    Assert.Pass();
                                }
                                else
                                {
                                    Assert.Fail();
                                }
                            }
                            else
                            {
                                if (this.Driver.FindElements(By.ClassName("print_button")).Count != 0)
                                {
                                    Assert.Pass();
                                }
                                else
                                {
                                    Assert.Fail();
                                }
                            }
                        }
                        catch (UnhandledAlertException u)
                        {
                            Assert.Fail();
                        }
                    }
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

        public Boolean isAlertPresent()
        {
            try
            {
                Driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException ex)
            {
                return false;
            }
        }

        #endregion
    }
}