using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using SmokeTestSelenium.WrapperFactory;
using System.Data;

namespace SmokeTestSelenium.PageObjects
{
    public class SearchPatientPage : BasePage
    {
        #region Properties

        #region QA

        [FindsBy(How = How.Id, Using = "dob-input")]
        [CacheLookup]
        private IWebElement DobInputQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='patient-lookup']/div[6]/input")]
        [CacheLookup]
        private IWebElement SearchBtnQA { get; set; }

        [FindsBy(How = How.Id, Using = "use-selected")]
        [CacheLookup]
        private IWebElement UseSelectedBtnQA { get; set; }

        [FindsBy(How = How.Id, Using = "create-new")]
        [CacheLookup]
        private IWebElement CreateNewBtnQA { get; set; }

        [FindsBy(How = How.ClassName, Using = "yes")]
        [CacheLookup]
        private IWebElement YesBtnQA { get; set; }

        #endregion

        #region DEMO

        [FindsBy(How = How.Id, Using = "dob-input")]
        [CacheLookup]
        private IWebElement DobInputDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='patient-lookup']/div[6]/input")]
        [CacheLookup]
        private IWebElement SearchBtnDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "use-selected")]
        [CacheLookup]
        private IWebElement UseSelectedBtnDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "create-new")]
        [CacheLookup]
        private IWebElement CreateNewBtnDEMO { get; set; }

        [FindsBy(How = How.ClassName, Using = "yes")]
        [CacheLookup]
        private IWebElement YesBtnDEMO { get; set; }

        #endregion

        #region PRD

        [FindsBy(How = How.Id, Using = "dob-input")]
        [CacheLookup]
        private IWebElement DobInputPRD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='patient-lookup']/div[6]/input")]
        [CacheLookup]
        private IWebElement SearchBtnPRD { get; set; }

        [FindsBy(How = How.Id, Using = "use-selected")]
        [CacheLookup]
        private IWebElement UseSelectedBtnPRD { get; set; }

        [FindsBy(How = How.Id, Using = "create-new")]
        [CacheLookup]
        private IWebElement CreateNewBtnPRD { get; set; }

        [FindsBy(How = How.ClassName, Using = "yes")]
        [CacheLookup]
        private IWebElement YesBtnPRD { get; set; }

        #endregion

        public String message { get; set; }
        public String Dob { get; set; }

        #endregion

        #region Constructor
        public SearchPatientPage()
        {
            Driver = BrowserFactory.Driver;
        }

        public SearchPatientPage(IWebDriver driver, Setup.Settings setup)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            this.Setup = setup;
        }
        #endregion

        #region Methods

        public void AddPatientQA(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 5;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "7")
                        {
                            Dob = row["value"].ToString();
                        }
                    }


                    Thread.Sleep(this.Setup.SmWaitTime);
                    DobInputQA.Click();
                    DobInputQA.SendKeys(Dob);
                    DobInputQA.SendKeys(Keys.Enter);
                    SearchBtnQA.Click();
                    Thread.Sleep(this.Setup.SmWaitTime);

                    if (this.Driver.FindElements(By.ClassName("clickrow")).Count != 0)
                    {
                        Thread.Sleep(1000);
                        ExpectedConditions.ElementToBeClickable(this.Driver.FindElement(By.XPath(this.Setup.Data.Patient)));
                        Thread.Sleep(this.Setup.SmWaitTime); // time must be set so that the exception in the previous line can be made.
                        this.Driver.FindElement(By.XPath(this.Setup.Data.Patient)).Click();
                        var element = Driver.FindElement(By.Id("use-selected"));
                        Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
                        Thread.Sleep(this.Setup.SmWaitTime);

                        if (this.Driver.FindElements(By.ClassName("is-open")).Count != 0)
                        {
                            UseSelectedBtnQA.Click();
                            ExpectedConditions.ElementToBeClickable(this.Driver.FindElement(By.ClassName("yes")));
                            Thread.Sleep(this.Setup.SmWaitTime); // time must be set so that the exception in the previous line can be made.
                            YesBtnQA.Click();
                        }
                        else
                        {
                            UseSelectedBtnQA.Click();
                        }
                    }
                    else
                    {
                        CreateNewBtnQA.Click();
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
        public void AddPatientDEMO(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 5;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "7")
                        {
                            Dob = row["value"].ToString();
                        }
                    }


                    Thread.Sleep(this.Setup.SmWaitTime);
                    DobInputDEMO.Click();
                    DobInputDEMO.SendKeys(Dob);
                    DobInputDEMO.SendKeys(Keys.Enter);
                    SearchBtnDEMO.Click();
                    Thread.Sleep(this.Setup.SmWaitTime);

                    if (this.Driver.FindElements(By.ClassName("clickrow")).Count != 0)
                    {
                        Thread.Sleep(1000);
                        ExpectedConditions.ElementToBeClickable(this.Driver.FindElement(By.XPath(this.Setup.Data.Patient)));
                        Thread.Sleep(this.Setup.SmWaitTime); // time must be set so that the exception in the previous line can be made.
                        this.Driver.FindElement(By.XPath(this.Setup.Data.Patient)).Click();
                        var element = Driver.FindElement(By.Id("use-selected"));
                        Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
                        Thread.Sleep(this.Setup.SmWaitTime);

                        if (this.Driver.FindElements(By.ClassName("is-open")).Count != 0)
                        {
                            UseSelectedBtnDEMO.Click();
                            ExpectedConditions.ElementToBeClickable(this.Driver.FindElement(By.ClassName("yes")));
                            Thread.Sleep(this.Setup.SmWaitTime); // time must be set so that the exception in the previous line can be made.
                            YesBtnDEMO.Click();
                        }
                        else
                        {
                            UseSelectedBtnDEMO.Click();
                        }
                    }
                    else
                    {
                        CreateNewBtnDEMO.Click();
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
        public void AddPatientPRD(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 5;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "7")
                        {
                            Dob = row["value"].ToString();
                        }
                    }


                    Thread.Sleep(this.Setup.SmWaitTime);
                    DobInputPRD.Click();
                    DobInputPRD.SendKeys(Dob);
                    DobInputPRD.SendKeys(Keys.Enter);
                    SearchBtnPRD.Click();
                    Thread.Sleep(this.Setup.SmWaitTime);

                    if (this.Driver.FindElements(By.ClassName("clickrow")).Count != 0)
                    {
                        Thread.Sleep(1000);
                        ExpectedConditions.ElementToBeClickable(this.Driver.FindElement(By.XPath(this.Setup.Data.Patient)));
                        Thread.Sleep(this.Setup.SmWaitTime); // time must be set so that the exception in the previous line can be made.
                        this.Driver.FindElement(By.XPath(this.Setup.Data.Patient)).Click();
                        var element = Driver.FindElement(By.Id("use-selected"));
                        Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
                        Thread.Sleep(this.Setup.SmWaitTime);

                        if (this.Driver.FindElements(By.ClassName("is-open")).Count != 0)
                        {
                            UseSelectedBtnPRD.Click();
                            ExpectedConditions.ElementToBeClickable(this.Driver.FindElement(By.ClassName("yes")));
                            Thread.Sleep(this.Setup.SmWaitTime); // time must be set so that the exception in the previous line can be made.
                            YesBtnPRD.Click();
                        }
                        else
                        {
                            UseSelectedBtnPRD.Click();
                        }
                    }
                    else
                    {
                        CreateNewBtnPRD.Click();
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

        public void SelectNewPatientQA()
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            DobInputQA.Click();
            DobInputQA.SendKeys(this.Setup.Data.ObjPatient.Dob);
            DobInputQA.SendKeys(Keys.Enter);
            SearchBtnQA.Click();
            Thread.Sleep(1000);

            CreateNewBtnQA.Click();
        }
        public void SelectNewPatientDEMO()
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            DobInputDEMO.Click();
            DobInputDEMO.SendKeys(this.Setup.Data.ObjPatient.Dob);
            DobInputDEMO.SendKeys(Keys.Enter);
            SearchBtnDEMO.Click();
            Thread.Sleep(1000);

            CreateNewBtnDEMO.Click();
        }
        public void SelectNewPatientPRD()
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            DobInputPRD.Click();
            DobInputPRD.SendKeys(this.Setup.Data.ObjPatient.Dob);
            DobInputPRD.SendKeys(Keys.Enter);
            SearchBtnPRD.Click();
            Thread.Sleep(1000);

            CreateNewBtnPRD.Click();
        }

        #endregion
    }
}
