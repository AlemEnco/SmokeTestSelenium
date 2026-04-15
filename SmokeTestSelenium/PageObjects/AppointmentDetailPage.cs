using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SmokeTestSelenium.WrapperFactory;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmokeTestSelenium.PageObjects
{
    public class AppointmentDetailPage : BasePage
    {
        #region Properties

        #region QA

        #region Add Notes

        [FindsBy(How = How.Id, Using = "new_note")]
        [CacheLookup]
        private IWebElement NewNoteBtnQA { get; set; }

        [FindsBy(How = How.Id, Using = "new_note_modal")]
        [CacheLookup]
        private IWebElement NewNoteModalQA { get; set; }

        [FindsBy(How = How.Id, Using = "update_priority_input_1")]
        [CacheLookup]
        private IWebElement NoteHighPriorityCheckQA { get; set; }

        [FindsBy(How = How.Id, Using = "note_area")]
        [CacheLookup]
        private IWebElement NoteTextareaQA { get; set; }

        [FindsBy(How = How.Id, Using = "attachment_input")]
        [CacheLookup]
        private IWebElement AttachmentInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "add_new_note")]
        [CacheLookup]
        private IWebElement PublishBtnQA { get; set; }

        #endregion

        #region Edit Appointment Detail

        [FindsBy(How = How.XPath, Using = "//*[@id='mytab']/li[2]/a")]
        [CacheLookup]
        private IWebElement DemographicsTabQA { get; set; }

        [FindsBy(How = How.Id, Using = "middle_name")]
        [CacheLookup]
        private IWebElement MiddleNameInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "save_demo_changes")]
        [CacheLookup]
        private IWebElement SaveChangesBtnQA { get; set; }

        [FindsBy(How = How.ClassName, Using = "edit_note")]
        [CacheLookup]
        private IWebElement EditNoteBtnQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='clinicals']/div/div[2]/div[1]/textarea")]
        [CacheLookup]
        private IWebElement EditNoteTextareaQA { get; set; }

        [FindsBy(How = How.ClassName, Using = "submit_edit_note")]
        [CacheLookup]
        private IWebElement SubmitEditNoteBtnQA { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = "cancel-econsult-requesting")]
        [CacheLookup]
        private IWebElement CancelAppointmentBtnQA { get; set; }

        [FindsBy(How = How.Id, Using = "cancel-econsult-requesting-reason")]
        [CacheLookup]
        private IWebElement ReasonCanceleConsultAppointmentSelectQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='textarea-other-reason']/textarea")]
        [CacheLookup]
        private IWebElement ReasonCanceleConsultAppointmentInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "reassign_confirm")]
        [CacheLookup]
        private IWebElement YesCanceleConsultAppointmentBtnQA { get; set; }

        [FindsBy(How = How.Id, Using = "cancel-referral-provider-reason")]
        [CacheLookup]
        private IWebElement ReasonCancelReferralAppointmentSelectQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='textarea-other-reason']/textarea")]
        [CacheLookup]
        private IWebElement ReasonCancelReferralAppointmentInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "cancel_confirm_provider")]
        [CacheLookup]
        private IWebElement YesCancelReferralAppointmentBtnQA { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/form/div[3]/div[1]/div[1]/div[2]/div[2]/ul/li[3]/select")]
        [CacheLookup]
        private IWebElement StatusSelectQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-navbar']/ul/li[9]/a")]
        [CacheLookup]
        private IWebElement LogoutBtnQA { get; set; }

        #endregion

        #region DEMO

        #region Add Notes

        [FindsBy(How = How.Id, Using = "new_note")]
        [CacheLookup]
        private IWebElement NewNoteBtnDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "new_note_modal")]
        [CacheLookup]
        private IWebElement NewNoteModalDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "update_priority_input_1")]
        [CacheLookup]
        private IWebElement NoteHighPriorityCheckDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "note_area")]
        [CacheLookup]
        private IWebElement NoteTextareaDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "attachment_input")]
        [CacheLookup]
        private IWebElement AttachmentInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "add_new_note")]
        [CacheLookup]
        private IWebElement PublishBtnDEMO { get; set; }

        #endregion

        #region Edit Appointment Detail

        [FindsBy(How = How.XPath, Using = "//*[@id='mytab']/li[2]/a")]
        [CacheLookup]
        private IWebElement DemographicsTabDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "middle_name")]
        [CacheLookup]
        private IWebElement MiddleNameInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "save_demo_changes")]
        [CacheLookup]
        private IWebElement SaveChangesBtnDEMO { get; set; }

        [FindsBy(How = How.ClassName, Using = "edit_note")]
        [CacheLookup]
        private IWebElement EditNoteBtnDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='clinicals']/div/div[2]/div[1]/textarea")]
        [CacheLookup]
        private IWebElement EditNoteTextareaDEMO { get; set; }

        [FindsBy(How = How.ClassName, Using = "submit_edit_note")]
        [CacheLookup]
        private IWebElement SubmitEditNoteBtnDEMO { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = "cancel-econsult-requesting")]
        [CacheLookup]
        private IWebElement CancelAppointmentBtnDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "cancel-econsult-requesting-reason")]
        [CacheLookup]
        private IWebElement ReasonCanceleConsultAppointmentSelectDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='textarea-other-reason']/textarea")]
        [CacheLookup]
        private IWebElement ReasonCanceleConsultAppointmentInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "reassign_confirm")]
        [CacheLookup]
        private IWebElement YesCanceleConsultAppointmentBtnDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "cancel-referral-provider-reason")]
        [CacheLookup]
        private IWebElement ReasonCancelReferralAppointmentSelectDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='textarea-other-reason']/textarea")]
        [CacheLookup]
        private IWebElement ReasonCancelReferralAppointmentInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "cancel_confirm_provider")]
        [CacheLookup]
        private IWebElement YesCancelReferralAppointmentBtnDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/form/div[3]/div[1]/div[1]/div[2]/div[2]/ul/li[3]/select")]
        [CacheLookup]
        private IWebElement StatusSelectDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-navbar']/ul/li[9]/a")]
        [CacheLookup]
        private IWebElement LogoutBtnDEMO { get; set; }

        #endregion

        #region PRD

        #region Add Notes

        [FindsBy(How = How.Id, Using = "new_note")]
        [CacheLookup]
        private IWebElement NewNoteBtnPRD { get; set; }

        [FindsBy(How = How.Id, Using = "new_note_modal")]
        [CacheLookup]
        private IWebElement NewNoteModalPRD { get; set; }

        [FindsBy(How = How.Id, Using = "update_priority_input_")]
        [CacheLookup]
        private IWebElement NoteHighPriorityCheckPRD { get; set; }

        [FindsBy(How = How.Id, Using = "note_area")]
        [CacheLookup]
        private IWebElement NoteTextareaPRD { get; set; }

        [FindsBy(How = How.Id, Using = "attachment_input")]
        [CacheLookup]
        private IWebElement AttachmentInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "add_new_note")]
        [CacheLookup]
        private IWebElement PublishBtnPRD { get; set; }

        #endregion

        #region Edit Appointment Detail

        [FindsBy(How = How.XPath, Using = "//*[@id='mytab']/li[2]/a")]
        [CacheLookup]
        private IWebElement DemographicsTabPRD { get; set; }

        [FindsBy(How = How.Id, Using = "middle_name")]
        [CacheLookup]
        private IWebElement MiddleNameInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "save_demo_changes")]
        [CacheLookup]
        private IWebElement SaveChangesBtnPRD { get; set; }

        [FindsBy(How = How.ClassName, Using = "edit_note")]
        [CacheLookup]
        private IWebElement EditNoteBtnPRD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='clinicals']/div/div[2]/div[1]/textarea")]
        [CacheLookup]
        private IWebElement EditNoteTextareaPRD { get; set; }

        [FindsBy(How = How.ClassName, Using = "submit_edit_note")]
        [CacheLookup]
        private IWebElement SubmitEditNoteBtnPRD { get; set; }

        #endregion

        [FindsBy(How = How.XPath, Using = "cancel-econsult-requesting")]
        [CacheLookup]
        private IWebElement CancelAppointmentBtnPRD { get; set; }

        [FindsBy(How = How.Id, Using = "cancel-econsult-requesting-reason")]
        [CacheLookup]
        private IWebElement ReasonCanceleConsultAppointmentSelectPRD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='textarea-other-reason']/textarea")]
        [CacheLookup]
        private IWebElement ReasonCanceleConsultAppointmentInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "reassign_confirm")]
        [CacheLookup]
        private IWebElement YesCanceleConsultAppointmentBtnPRD { get; set; }

        [FindsBy(How = How.Id, Using = "cancel-referral-provider-reason")]
        [CacheLookup]
        private IWebElement ReasonCancelReferralAppointmentSelectPRD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='textarea-other-reason']/textarea")]
        [CacheLookup]
        private IWebElement ReasonCancelReferralAppointmentInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "cancel_confirm_provider")]
        [CacheLookup]
        private IWebElement YesCancelReferralAppointmentBtnPRD { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div[3]/form/div[3]/div[1]/div[1]/div[2]/div[2]/ul/li[3]/select")]
        [CacheLookup]
        private IWebElement StatusSelectPRD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main-navbar']/ul/li[9]/a")]
        [CacheLookup]
        private IWebElement LogoutBtnPRD { get; set; }

        #endregion        

        public String message { get; set; }
        public String NoteHighPriority { get; set; }
        public String NoteUploadFile { get; set; }
        public String EditNote { get; set; }
        public String EditDemographics { get; set; }
        public String CancelAppointment { get; set; }
        public String Logout { get; set; }

        #endregion

        #region Constructor
        public AppointmentDetailPage()
        {
            Driver = BrowserFactory.Driver;
        }

        public AppointmentDetailPage(IWebDriver driver, Setup.Settings setup)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            this.Setup = setup;
        }
        #endregion

        #region Methods

        public void CreateNoteQA(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 10;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "19")
                        {
                            NoteHighPriority = row["value"].ToString();
                        }
                        else if (idJsonParameter == "12")
                        {
                            NoteUploadFile = row["value"].ToString();
                        }
                        else if (idJsonParameter == "20")
                        {
                            Logout = row["value"].ToString();
                        }
                    }

                    NewNoteBtnQA.Click();

                    if (NoteHighPriority == "1")
                    {
                        NoteHighPriorityCheckQA.Click();
                    }

                    NoteTextareaQA.SendKeys("Automated test note");

                    if(NoteUploadFile == "1")
                    {
                        AttachmentInputQA.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                    }

                    PublishBtnQA.Click();

                    if (Logout == "1")
                    {
                        LogoutBtnQA.Click();
                        Assert.Pass();
                    }
                    else
                    {
                        if(this.Driver.FindElements(By.ClassName("edit_note")).Count != 0)
                        {
                            Assert.Pass();
                        }
                        else
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
        public void CreateNoteDEMO(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 10;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "19")
                        {
                            NoteHighPriority = row["value"].ToString();
                        }
                        else if (idJsonParameter == "12")
                        {
                            NoteUploadFile = row["value"].ToString();
                        }
                        else if (idJsonParameter == "20")
                        {
                            Logout = row["value"].ToString();
                        }
                    }

                    NewNoteBtnQA.Click();

                    if (NoteHighPriority == "1")
                    {
                        NoteHighPriorityCheckDEMO.Click();
                    }

                    NoteTextareaDEMO.SendKeys("Automated test note");

                    if (NoteUploadFile == "1")
                    {
                        AttachmentInputDEMO.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                    }

                    PublishBtnDEMO.Click();

                    if (Logout == "1")
                    {
                        LogoutBtnDEMO.Click();
                        Assert.Pass();
                    }
                    else
                    {
                        if (this.Driver.FindElements(By.ClassName("edit_note")).Count != 0)
                        {
                            Assert.Pass();
                        }
                        else
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
        public void CreateNotePRD(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 10;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "19")
                        {
                            NoteHighPriority = row["value"].ToString();
                        }
                        else if (idJsonParameter == "12")
                        {
                            NoteUploadFile = row["value"].ToString();
                        }
                        else if (idJsonParameter == "20")
                        {
                            Logout = row["value"].ToString();
                        }
                    }

                    NewNoteBtnQA.Click();

                    if (NoteHighPriority == "1")
                    {
                        NoteHighPriorityCheckPRD.Click();
                    }

                    NoteTextareaPRD.SendKeys("Automated test note");

                    if (NoteUploadFile == "1")
                    {
                        AttachmentInputPRD.SendKeys("..\\..\\..\\Setup\\Pdf\\pdf_test.pdf");
                    }

                    PublishBtnPRD.Click();

                    if (Logout == "1")
                    {
                        LogoutBtnPRD.Click();
                        Assert.Pass();
                    }
                    else
                    {
                        if (this.Driver.FindElements(By.ClassName("edit_note")).Count != 0)
                        {
                            Assert.Pass();
                        }
                        else
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

        public void EditAppointmentDetailQA(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 10;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "17")
                        {
                            EditDemographics = row["value"].ToString();
                        }
                        else if (idJsonParameter == "18")
                        {
                            EditNote = row["value"].ToString();
                        }
                        else if (idJsonParameter == "20")
                        {
                            Logout = row["value"].ToString();
                        }
                        else if (idJsonParameter == "21")
                        {
                            CancelAppointment = row["value"].ToString();
                        }
                    }

                    if (this.Driver.FindElements(By.ClassName("edit_note")).Count != 0)
                    {
                        EditNoteBtnQA.Click();
                        EditNoteTextareaQA.SendKeys("Automated test note edit");
                        SubmitEditNoteBtnQA.Click();
                    }

                    DemographicsTabQA.Click();
                    MiddleNameInputQA.SendKeys("Automated");
                    SaveChangesBtnQA.Click();
                    //wait until
                    
                    if (CancelAppointment == "1")
                    {
                        if (this.Driver.FindElements(By.ClassName("cancel-econsult-requesting")).Count != 0)
                        {
                            CancelAppointmentBtnQA.Click();
                            var select = new SelectElement(ReasonCanceleConsultAppointmentSelectQA);
                            select.SelectByValue("other");
                            ReasonCancelReferralAppointmentInputQA.SendKeys("cancel test");
                            YesCanceleConsultAppointmentBtnQA.Click();
                        }
                    }
                    else
                    {

                    }

                    if (Logout == "1")
                    {
                        LogoutBtnQA.Click();
                        Assert.Pass();
                    }
                    else
                    {
                        var selectStatus = new SelectElement(StatusSelectQA);

                        if (selectStatus.SelectedOption.Text == "Cancelled")
                        {
                            Assert.Pass();
                        }
                        else
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
        public void EditAppointmentDetailDEMO(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 10;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "17")
                        {
                            EditDemographics = row["value"].ToString();
                        }
                        else if (idJsonParameter == "18")
                        {
                            EditNote = row["value"].ToString();
                        }
                        else if (idJsonParameter == "20")
                        {
                            Logout = row["value"].ToString();
                        }
                        else if (idJsonParameter == "21")
                        {
                            CancelAppointment = row["value"].ToString();
                        }
                    }

                    if (this.Driver.FindElements(By.ClassName("edit_note")).Count != 0)
                    {
                        EditNoteBtnDEMO.Click();
                        EditNoteTextareaDEMO.SendKeys("Automated test note edit");
                        SubmitEditNoteBtnDEMO.Click();
                    }

                    DemographicsTabDEMO.Click();
                    MiddleNameInputDEMO.SendKeys("Automated");
                    SaveChangesBtnDEMO.Click();
                    //wait until

                    if (CancelAppointment == "1")
                    {
                        if (this.Driver.FindElements(By.ClassName("cancel-econsult-requesting")).Count != 0)
                        {
                            CancelAppointmentBtnDEMO.Click();
                            var select = new SelectElement(ReasonCanceleConsultAppointmentSelectDEMO);
                            select.SelectByValue("other");
                            ReasonCancelReferralAppointmentInputDEMO.SendKeys("cancel test");
                            YesCanceleConsultAppointmentBtnDEMO.Click();
                        }
                    }
                    else
                    {

                    }

                    if (Logout == "1")
                    {
                        LogoutBtnDEMO.Click();
                        Assert.Pass();
                    }
                    else
                    {
                        var selectStatus = new SelectElement(StatusSelectQA);

                        if (selectStatus.SelectedOption.Text == "Cancelled")
                        {
                            Assert.Pass();
                        }
                        else
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
        public void EditAppointmentDetailPRD(Int16 module, String Connection)
        {
            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 10;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "17")
                        {
                            EditDemographics = row["value"].ToString();
                        }
                        else if (idJsonParameter == "18")
                        {
                            EditNote = row["value"].ToString();
                        }
                        else if (idJsonParameter == "20")
                        {
                            Logout = row["value"].ToString();
                        }
                        else if (idJsonParameter == "21")
                        {
                            CancelAppointment = row["value"].ToString();
                        }
                    }

                    if (this.Driver.FindElements(By.ClassName("edit_note")).Count != 0)
                    {
                        EditNoteBtnPRD.Click();
                        EditNoteTextareaPRD.SendKeys("Automated test note edit");
                        SubmitEditNoteBtnPRD.Click();
                    }

                    DemographicsTabPRD.Click();
                    MiddleNameInputPRD.SendKeys("Automated");
                    SaveChangesBtnPRD.Click();
                    //wait until

                    if (CancelAppointment == "1")
                    {
                        if (this.Driver.FindElements(By.ClassName("cancel-econsult-requesting")).Count != 0)
                        {
                            CancelAppointmentBtnPRD.Click();
                            var select = new SelectElement(ReasonCanceleConsultAppointmentSelectDEMO);
                            select.SelectByValue("other");
                            ReasonCancelReferralAppointmentInputPRD.SendKeys("cancel test");
                            YesCanceleConsultAppointmentBtnPRD.Click();
                        }
                    }
                    else
                    {

                    }

                    if (Logout == "1")
                    {
                        LogoutBtnPRD.Click();
                        Assert.Pass();
                    }
                    else
                    {
                        var selectStatus = new SelectElement(StatusSelectQA);

                        if (selectStatus.SelectedOption.Text == "Cancelled")
                        {
                            Assert.Pass();
                        }
                        else
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
        #endregion
    }
}