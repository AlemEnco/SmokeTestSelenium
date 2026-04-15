using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumExtras.PageObjects;
using SmokeTestSelenium.WrapperFactory;
using System.Data;

namespace SmokeTestSelenium.PageObjects
{
    public class PatientInformationPage : BasePage
    {
        #region Properties

        #region QA

        [FindsBy(How = How.Id, Using = "econsult_reason")]
        [CacheLookup]
        private IWebElement eConsultReasonInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "is_consent")]
        [CacheLookup]
        private IWebElement ConsentInputCheckQA { get; set; }

        [FindsBy(How = How.Id, Using = "submitbutton")]
        [CacheLookup]
        private IWebElement SubmitBtnQA { get; set; }

        [FindsBy(How = How.Id, Using = "search-nearest-insurances")]
        [CacheLookup]
        private IWebElement ModalNearestInsuranceQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search-nearest-insurances']/div/div/div[3]/button[2]")]
        [CacheLookup]
        private IWebElement ModalNoBtnQA { get; set; }

        [FindsBy(How = How.Id, Using = "televideo_onsite_consent")]
        [CacheLookup]
        private IWebElement ConsentInput2CheckQA { get; set; }

        [FindsBy(How = How.Id, Using = "note_area")]
        [CacheLookup]
        private IWebElement AddNoteTextareaQA { get; set; }

        [FindsBy(How = How.Id, Using = "attachment_input")]
        [CacheLookup]
        private IWebElement Attachment_inputQA { get; set; }

        #endregion

        #region DEMO

        [FindsBy(How = How.Id, Using = "econsult_reason")]
        [CacheLookup]
        private IWebElement eConsultReasonInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "is_consent")]
        [CacheLookup]
        private IWebElement ConsentInputCheckDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "submitbutton")]
        [CacheLookup]
        private IWebElement SubmitBtnDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "search-nearest-insurances")]
        [CacheLookup]
        private IWebElement ModalNearestInsuranceDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search-nearest-insurances']/div/div/div[3]/button[2]")]
        [CacheLookup]
        private IWebElement ModalNoBtnDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "televideo_onsite_consent")]
        [CacheLookup]
        private IWebElement ConsentInput2CheckDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "note_area")]
        [CacheLookup]
        private IWebElement AddNoteTextareaDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "attachment_input")]
        [CacheLookup]
        private IWebElement Attachment_inputDEMO { get; set; }

        #endregion

        #region PRD

        [FindsBy(How = How.Id, Using = "econsult_reason")]
        [CacheLookup]
        private IWebElement eConsultReasonInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "is_consent")]
        [CacheLookup]
        private IWebElement ConsentInputCheckPRD { get; set; }

        [FindsBy(How = How.Id, Using = "submitbutton")]
        [CacheLookup]
        private IWebElement SubmitBtnPRD { get; set; }

        [FindsBy(How = How.Id, Using = "search-nearest-insurances")]
        [CacheLookup]
        private IWebElement ModalNearestInsurancePRD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='search-nearest-insurances']/div/div/div[3]/button[2]")]
        [CacheLookup]
        private IWebElement ModalNoBtnPRD { get; set; }

        [FindsBy(How = How.Id, Using = "televideo_onsite_consent")]
        [CacheLookup]
        private IWebElement ConsentInput2CheckPRD { get; set; }

        [FindsBy(How = How.Id, Using = "note_area")]
        [CacheLookup]
        private IWebElement AddNoteTextareaPRD { get; set; }

        [FindsBy(How = How.Id, Using = "attachment_input")]
        [CacheLookup]
        private IWebElement Attachment_inputPRD { get; set; }

        #endregion

        public String? message { get; set; }
        public String? Reason { get; set; }
        public String? UploadFile { get; set; }
        public String? AddNotes { get; set; }

        #endregion

        #region Constructor

        public PatientInformationPage()
        {
            Driver = BrowserFactory.Driver;
        }

        public PatientInformationPage(IWebDriver driver, Setup.Settings setup)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            this.Setup = setup;
        }

        #endregion

        #region Methods

        public void PatientInformationConsentQA(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 6;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "9")
                        {
                            Reason = row["value"].ToString();
                        }
                        else if (idJsonParameter == "12")
                        {
                            UploadFile = row["value"].ToString();
                        }
                        else if (idJsonParameter == "18")
                        {
                            AddNotes = row["value"].ToString();
                        }
                    }


                    Thread.Sleep(this.Setup.SmWaitTime);

                    if (this.Driver.FindElements(By.Id("first_name")).Count != 0)
                    {
                        if (ModalNearestInsuranceQA.Displayed)
                        {
                            ModalNoBtnQA.Click();
                            Thread.Sleep(this.Setup.SmWaitTime);
                            var element = Driver.FindElement(By.Id("submitbutton"));
                            Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
                            eConsultReasonInputQA.SendKeys(Reason);
                            Thread.Sleep(this.Setup.SmWaitTime);
                            ConsentInputCheckQA.Click();
                            if (this.Driver.FindElements(By.Id("televideo_onsite_consent")).Count != 0)
                            {
                                ConsentInput2CheckQA.Click();

                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaQA.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputQA.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }                                

                                SubmitBtnQA.Click();
                            }
                            else
                            {
                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaQA.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputQA.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnQA.Click();
                            }
                        }
                        else
                        {
                            var element = Driver.FindElement(By.Id("submitbutton"));
                            Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
                            eConsultReasonInputQA.SendKeys(Reason);
                            Thread.Sleep(this.Setup.SmWaitTime);
                            ConsentInputCheckQA.Click();
                            if (this.Driver.FindElements(By.Id("televideo_onsite_consent")).Count != 0)
                            {
                                ConsentInput2CheckQA.Click();

                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaQA.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputQA.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnQA.Click();
                            }
                            else
                            {
                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaQA.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputQA.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnQA.Click();
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
        public void PatientInformationConsentDEMO(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 6;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "9")
                        {
                            Reason = row["value"].ToString();
                        }
                        else if (idJsonParameter == "12")
                        {
                            UploadFile = row["value"].ToString();
                        }
                        else if (idJsonParameter == "18")
                        {
                            AddNotes = row["value"].ToString();
                        }
                    }

                    Thread.Sleep(this.Setup.SmWaitTime);

                    if (this.Driver.FindElements(By.Id("first_name")).Count != 0)
                    {
                        if (ModalNearestInsuranceDEMO.Displayed)
                        {
                            ModalNoBtnDEMO.Click();
                            Thread.Sleep(this.Setup.SmWaitTime);
                            var element = Driver.FindElement(By.Id("submitbutton"));
                            Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
                            eConsultReasonInputDEMO.SendKeys(Reason);
                            Thread.Sleep(this.Setup.SmWaitTime);
                            ConsentInputCheckDEMO.Click();
                            if (this.Driver.FindElements(By.Id("televideo_onsite_consent")).Count != 0)
                            {
                                ConsentInput2CheckDEMO.Click();

                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaDEMO.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputDEMO.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnDEMO.Click();
                            }
                            else
                            {
                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaDEMO.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputDEMO.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnDEMO.Click();
                            }
                        }
                        else
                        {
                            var element = Driver.FindElement(By.Id("submitbutton"));
                            Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
                            eConsultReasonInputDEMO.SendKeys(Reason);
                            Thread.Sleep(this.Setup.SmWaitTime);
                            ConsentInputCheckDEMO.Click();
                            if (this.Driver.FindElements(By.Id("televideo_onsite_consent")).Count != 0)
                            {
                                ConsentInput2CheckDEMO.Click();

                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaDEMO.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputDEMO.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnDEMO.Click();
                            }
                            else
                            {
                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaDEMO.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputDEMO.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnDEMO.Click();
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
        public void PatientInformationConsentPRD(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 6;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "9")
                        {
                            Reason = row["value"].ToString();
                        }
                        else if (idJsonParameter == "12")
                        {
                            UploadFile = row["value"].ToString();
                        }
                        else if (idJsonParameter == "18")
                        {
                            AddNotes = row["value"].ToString();
                        }
                    }


                    Thread.Sleep(this.Setup.SmWaitTime);

                    if (this.Driver.FindElements(By.Id("first_name")).Count != 0)
                    {
                        if (ModalNearestInsurancePRD.Displayed)
                        {
                            ModalNoBtnPRD.Click();
                            Thread.Sleep(this.Setup.SmWaitTime);
                            var element = Driver.FindElement(By.Id("submitbutton"));
                            Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
                            eConsultReasonInputPRD.SendKeys(Reason);
                            Thread.Sleep(this.Setup.SmWaitTime);
                            ConsentInputCheckPRD.Click();
                            if (this.Driver.FindElements(By.Id("televideo_onsite_consent")).Count != 0)
                            {
                                ConsentInput2CheckPRD.Click();

                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaPRD.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputPRD.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnPRD.Click();
                            }
                            else
                            {
                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaPRD.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputPRD.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnPRD.Click();
                            }
                        }
                        else
                        {
                            var element = Driver.FindElement(By.Id("submitbutton"));
                            Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", element);
                            eConsultReasonInputPRD.SendKeys(Reason);
                            Thread.Sleep(this.Setup.SmWaitTime);
                            ConsentInputCheckPRD.Click();
                            if (this.Driver.FindElements(By.Id("televideo_onsite_consent")).Count != 0)
                            {
                                ConsentInput2CheckPRD.Click();

                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaPRD.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputPRD.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnPRD.Click();
                            }
                            else
                            {
                                if (AddNotes == "1")
                                {
                                    AddNoteTextareaPRD.SendKeys("Test Note");
                                }

                                if (UploadFile == "1")
                                {
                                    Attachment_inputPRD.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                                }

                                SubmitBtnPRD.Click();
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
