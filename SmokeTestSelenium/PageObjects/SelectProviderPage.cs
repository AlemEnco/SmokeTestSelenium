using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SmokeTestSelenium.WrapperFactory;

namespace SmokeTestSelenium.PageObjects
{
    public class SelectProviderPage : BasePage
    {
        #region Properties

        #region QA

        [FindsBy(How = How.Id, Using = "s2id_s-select-location")]
        [CacheLookup]
        private IWebElement LocationSelectQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen2_search")]
        [CacheLookup]
        private IWebElement LocationSelectInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-apptmode-filter")]
        [CacheLookup]
        private IWebElement AppointmentModeSelectQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen5_search")]
        [CacheLookup]
        private IWebElement AppointmentModeSelectInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "btn-search-submit")]
        [CacheLookup]
        private IWebElement SearchBtnQA { get; set; }

        [FindsBy(How = How.Name, Using = "doctor_filter")]
        [CacheLookup]
        private IWebElement DoctorFilterInputQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search-doctors']/div[2]/table/tbody/tr[1]/td/div/div[2]/div[5]/div/a")]
        [CacheLookup]
        private IWebElement RequestBtnQA { get; set; }

        #endregion

        #region DEMO

        [FindsBy(How = How.Id, Using = "s2id_s-select-location")]
        [CacheLookup]
        private IWebElement LocationSelectDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen2_search")]
        [CacheLookup]
        private IWebElement LocationSelectInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-apptmode-filter")]
        [CacheLookup]
        private IWebElement AppointmentModeSelectDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen5_search")]
        [CacheLookup]
        private IWebElement AppointmentModeSelectInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "btn-search-submit")]
        [CacheLookup]
        private IWebElement SearchBtnDEMO { get; set; }

        [FindsBy(How = How.Name, Using = "doctor_filter")]
        [CacheLookup]
        private IWebElement DoctorFilterInputDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search-doctors']/div[2]/table/tbody/tr[1]/td/div/div[2]/div[5]/div/a")]
        [CacheLookup]
        private IWebElement RequestBtnDEMO { get; set; }

        #endregion

        #region PRD

        [FindsBy(How = How.Id, Using = "s2id_s-select-location")]
        [CacheLookup]
        private IWebElement LocationSelectPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen2_search")]
        [CacheLookup]
        private IWebElement LocationSelectInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-apptmode-filter")]
        [CacheLookup]
        private IWebElement AppointmentModeSelectPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen5_search")]
        [CacheLookup]
        private IWebElement AppointmentModeSelectInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "btn-search-submit")]
        [CacheLookup]
        private IWebElement SearchBtnPRD { get; set; }

        [FindsBy(How = How.Name, Using = "doctor_filter")]
        [CacheLookup]
        private IWebElement DoctorFilterInputPRD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='econsultSearchByFilters']/div[3]/table/tbody/tr[1]/td/div/div[2]/div[5]/div/a")]
        [CacheLookup]
        private IWebElement RequestBtnPRD { get; set; }

        #endregion

        public String message { get; set; }
        public int typeReferral { get; set; }

        #endregion

        #region Constructor
        public SelectProviderPage()
        {
            Driver = BrowserFactory.Driver;
        }

        public SelectProviderPage(IWebDriver driver, Setup.Settings setup)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            this.Setup = setup;
        }
        #endregion

        #region Methods

        public void RequesteConsultSessionQA()
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            if (this.Driver.FindElements(By.Name("doctor_filter")).Count != 0)
            {
                Thread.Sleep(this.Setup.SmWaitTime);
                RequestBtnQA.Click();
            }
            else
            {
                Thread.Sleep(this.Setup.SmWaitTime);
                LocationSelectQA.Click();
                LocationSelectInputQA.SendKeys(this.Setup.Data.LocationProviderId);
                Thread.Sleep(this.Setup.SmWaitTime);
                LocationSelectInputQA.SendKeys(Keys.Enter);
                SearchBtnQA.Click();
                Thread.Sleep(this.Setup.SmWaitTime);
                RequestBtnQA.Click();
            }
        }
        public void RequesteConsultSessionDEMO()
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            if (this.Driver.FindElements(By.Name("doctor_filter")).Count != 0)
            {
                Thread.Sleep(this.Setup.SmWaitTime);
                RequestBtnDEMO.Click();
            }
            else
            {
                Thread.Sleep(this.Setup.SmWaitTime);
                LocationSelectDEMO.Click();
                LocationSelectInputDEMO.SendKeys(this.Setup.Data.LocationProviderId);
                Thread.Sleep(this.Setup.SmWaitTime);
                LocationSelectInputDEMO.SendKeys(Keys.Enter);
                SearchBtnDEMO.Click();
                Thread.Sleep(this.Setup.SmWaitTime);
                RequestBtnDEMO.Click();
            }
        }
        public void RequesteConsultSessionPRD()
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            if (this.Driver.FindElements(By.Name("doctor_filter")).Count != 0)
            {
                Thread.Sleep(this.Setup.SmWaitTime);
                RequestBtnPRD.Click();
            }
            else
            {
                Thread.Sleep(this.Setup.SmWaitTime);
                LocationSelectPRD.Click();
                LocationSelectInputPRD.SendKeys(this.Setup.Data.LocationProviderId);
                Thread.Sleep(this.Setup.SmWaitTime);
                LocationSelectInputPRD.SendKeys(Keys.Enter);
                SearchBtnPRD.Click();
                Thread.Sleep(this.Setup.SmWaitTime);
                RequestBtnPRD.Click();
            }
        }

        public void RequestReferralSessionQA(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 7;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;

                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    Reader.ReadAsync();
                    typeReferral = Convert.ToInt32(Reader.GetInt32("typeReferral"));

                    Thread.Sleep(this.Setup.SmWaitTime);
                    if (this.Driver.FindElements(By.Name("doctor_filter")).Count != 0)
                    {
                        if (typeReferral == 1)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputQA.SendKeys("Remote Televideo session");
                            Thread.Sleep(this.Setup.SmWaitTime);
                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 2)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputQA.SendKeys("Telemedicine");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 3)
                        {
                            Thread.Sleep(this.Setup.SmWaitTime);

                            AppointmentModeSelectQA.Click();
                            AppointmentModeSelectInputQA.SendKeys("In-Person");
                            Thread.Sleep(this.Setup.SmWaitTime);
                            AppointmentModeSelectInputQA.SendKeys(Keys.Enter);
                            SearchBtnQA.Click();
                            Thread.Sleep(this.Setup.SmWaitTime);

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 4)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputQA.SendKeys("Onsite");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(this.Setup.SmWaitTime);
                        LocationSelectQA.Click();
                        LocationSelectInputQA.SendKeys(this.Setup.Data.LocationProviderId);
                        Thread.Sleep(this.Setup.SmWaitTime);
                        LocationSelectInputQA.SendKeys(Keys.Enter);
                        SearchBtnQA.Click();
                        Thread.Sleep(this.Setup.SmWaitTime);

                        if (typeReferral == 1)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputQA.SendKeys("Remote Televideo session");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 2)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputQA.SendKeys("Telemedicine"); // change to Televideo 

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 3)
                        {
                            Thread.Sleep(1000);

                            AppointmentModeSelectQA.Click();
                            AppointmentModeSelectInputQA.SendKeys("In-Person");
                            Thread.Sleep(this.Setup.SmWaitTime);
                            AppointmentModeSelectInputQA.SendKeys(Keys.Enter);
                            SearchBtnQA.Click();
                            Thread.Sleep(this.Setup.SmWaitTime);

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 4)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputQA.SendKeys("Onsite");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
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
        public void RequestReferralSessionDEMO(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 7;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;

                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    Reader.ReadAsync();
                    typeReferral = Convert.ToInt32(Reader.GetInt32("typeReferral"));

                    Thread.Sleep(this.Setup.SmWaitTime);
                    if (this.Driver.FindElements(By.Name("doctor_filter")).Count != 0)
                    {
                        if (typeReferral == 1)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputDEMO.SendKeys("Remote Televideo session");
                            Thread.Sleep(this.Setup.SmWaitTime);
                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 2)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputDEMO.SendKeys("Telemedicine");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 3)
                        {
                            Thread.Sleep(1000);
                            AppointmentModeSelectDEMO.Click();
                            AppointmentModeSelectInputDEMO.SendKeys("In-Person");
                            Thread.Sleep(this.Setup.SmWaitTime);
                            AppointmentModeSelectInputDEMO.SendKeys(Keys.Enter);
                            SearchBtnDEMO.Click();
                            Thread.Sleep(this.Setup.SmWaitTime);

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 4)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputDEMO.SendKeys("Onsite");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(this.Setup.SmWaitTime);
                        LocationSelectDEMO.Click();
                        LocationSelectInputDEMO.SendKeys(this.Setup.Data.LocationProviderId);
                        Thread.Sleep(this.Setup.SmWaitTime);
                        LocationSelectInputDEMO.SendKeys(Keys.Enter);
                        SearchBtnDEMO.Click();
                        Thread.Sleep(this.Setup.SmWaitTime);

                        if (typeReferral == 1)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputDEMO.SendKeys("Remote Televideo session");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 2)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputDEMO.SendKeys("Telemedicine"); // change to Televideo 

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 3)
                        {
                            Thread.Sleep(1000);
                            AppointmentModeSelectDEMO.Click();
                            AppointmentModeSelectInputDEMO.SendKeys("In-Person");
                            Thread.Sleep(this.Setup.SmWaitTime);
                            AppointmentModeSelectInputDEMO.SendKeys(Keys.Enter);
                            SearchBtnDEMO.Click();
                            Thread.Sleep(this.Setup.SmWaitTime);

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 4)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputDEMO.SendKeys("Onsite");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
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
        public void RequestReferralSessionPRD(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 7;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;

                MySqlDataReader Reader = cmd.ExecuteReader();

                if (Reader.HasRows)
                {
                    Reader.ReadAsync();
                    typeReferral = Convert.ToInt32(Reader.GetInt32("typeReferral"));

                    Thread.Sleep(this.Setup.SmWaitTime);
                    if (this.Driver.FindElements(By.Name("doctor_filter")).Count != 0)
                    {
                        if (typeReferral == 1)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputPRD.SendKeys("Remote Televideo session");
                            Thread.Sleep(this.Setup.SmWaitTime);
                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 2)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputPRD.SendKeys("Telemedicine");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 3)
                        {
                            Thread.Sleep(1000);
                            AppointmentModeSelectPRD.Click();
                            AppointmentModeSelectInputPRD.SendKeys("In-Person");
                            Thread.Sleep(this.Setup.SmWaitTime);
                            AppointmentModeSelectInputPRD.SendKeys(Keys.Enter);
                            SearchBtnPRD.Click();
                            Thread.Sleep(this.Setup.SmWaitTime);

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 4)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputPRD.SendKeys("Onsite");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        Thread.Sleep(this.Setup.SmWaitTime);
                        LocationSelectPRD.Click();
                        LocationSelectInputPRD.SendKeys(this.Setup.Data.LocationProviderId);
                        Thread.Sleep(this.Setup.SmWaitTime);
                        LocationSelectInputPRD.SendKeys(Keys.Enter);
                        SearchBtnPRD.Click();
                        Thread.Sleep(this.Setup.SmWaitTime);

                        if (typeReferral == 1)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputPRD.SendKeys("Remote Televideo session");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 2)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputPRD.SendKeys("Telemedicine"); // change to Televideo 

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 3)
                        {
                            Thread.Sleep(1000);
                            AppointmentModeSelectPRD.Click();
                            AppointmentModeSelectInputPRD.SendKeys("In-Person");
                            Thread.Sleep(this.Setup.SmWaitTime);
                            AppointmentModeSelectInputPRD.SendKeys(Keys.Enter);
                            SearchBtnPRD.Click();
                            Thread.Sleep(this.Setup.SmWaitTime);

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
                        }
                        else if (typeReferral == 4)
                        {
                            Thread.Sleep(1000);
                            DoctorFilterInputPRD.SendKeys("Onsite");

                            IWebElement tableElement = this.Driver.FindElement(By.ClassName("slots-table"));
                            IList<IWebElement> tableRow = tableElement.FindElements(By.TagName("tr"));

                            for (int i = 1; i < tableRow.Count; i++)
                            {
                                IWebElement Row = this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]"));

                                if (Row.Displayed)
                                {
                                    this.Driver.FindElement(By.XPath("//table/tbody/tr[" + i + "]/td[1]/div/div/div/div/a")).Click();
                                    break;
                                }
                            }
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

        #endregion
    }
}