using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumExtras.PageObjects;
using SmokeTestSelenium.WrapperFactory;
using System.Data;

namespace SmokeTestSelenium.PageObjects
{
    public class CreatePatientPage : BasePage
    {
        #region Properties

        #region QA

        #region Patient Information

        [FindsBy(How = How.Id, Using = "first_name")]
        [CacheLookup]
        private IWebElement FirstNameInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "last_name")]
        [CacheLookup]
        private IWebElement LastNameInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement EmailInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "date_of_birth")]
        [CacheLookup]
        private IWebElement DOBInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "phone_number1")]
        [CacheLookup]
        private IWebElement PhoneNumberInputQA { get; set; }

        #endregion Patient Information

        #region Additional Information

        [FindsBy(How = How.Id, Using = "phone_number2")]
        [CacheLookup]
        private IWebElement PhoneNumberSecondaryQA { get; set; }

        [FindsBy(How = How.Id, Using = "address_line_1")]
        [CacheLookup]
        private IWebElement AddressLine1InputQA { get; set; }

        [FindsBy(How = How.Id, Using = "address_line_2")]
        [CacheLookup]
        private IWebElement AddressLine2InputQA { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        [CacheLookup]
        private IWebElement CityInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_state")]
        [CacheLookup]
        private IWebElement StateSelectQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen3_search")]
        [CacheLookup]
        private IWebElement StateSelectInputQA { get; set; }

        #endregion Additional Information

        #region Specialty Diagnosis

        [FindsBy(How = How.Id, Using = "econsult_reason")]
        [CacheLookup]
        private IWebElement ReasonInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "is_consent")]
        [CacheLookup]
        private IWebElement ConsentInputCheckQA { get; set; }

        [FindsBy(How = How.Id, Using = "note_area")]
        [CacheLookup]
        private IWebElement AddNoteTextareaQA { get; set; }

        #endregion

        [FindsBy(How = How.Id, Using = "attachment_input")]
        [CacheLookup]
        private IWebElement Attachment_inputQA { get; set; }

        [FindsBy(How = How.Id, Using = "submitbutton")]
        [CacheLookup]
        private IWebElement SendBtnQA { get; set; }

        #endregion

        #region DEMO

        #region Patient Information

        [FindsBy(How = How.Id, Using = "first_name")]
        [CacheLookup]
        private IWebElement FirstNameInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "last_name")]
        [CacheLookup]
        private IWebElement LastNameInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement EmailInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "date_of_birth")]
        [CacheLookup]
        private IWebElement DOBInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "phone_number1")]
        [CacheLookup]
        private IWebElement PhoneNumberInputDEMO { get; set; }

        #endregion Patient Information

        #region Additional Information

        [FindsBy(How = How.Id, Using = "phone_number2")]
        [CacheLookup]
        private IWebElement PhoneNumberSecondaryDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "address_line_1")]
        [CacheLookup]
        private IWebElement AddressLine1InputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "address_line_2")]
        [CacheLookup]
        private IWebElement AddressLine2InputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        [CacheLookup]
        private IWebElement CityInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_state")]
        [CacheLookup]
        private IWebElement StateSelectDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen3_search")]
        [CacheLookup]
        private IWebElement StateSelectInputDEMO { get; set; }

        #endregion Additional Information

        #region Specialty Diagnosis

        [FindsBy(How = How.Id, Using = "econsult_reason")]
        [CacheLookup]
        private IWebElement ReasonInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "is_consent")]
        [CacheLookup]
        private IWebElement ConsentInputCheckDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "note_area")]
        [CacheLookup]
        private IWebElement AddNoteTextareaDEMO { get; set; }

        #endregion

        [FindsBy(How = How.Id, Using = "attachment_input")]
        [CacheLookup]
        private IWebElement Attachment_inputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "submitbutton")]
        [CacheLookup]
        private IWebElement SendBtnDEMO { get; set; }

        #endregion

        #region DEMO

        #region Patient Information

        [FindsBy(How = How.Id, Using = "first_name")]
        [CacheLookup]
        private IWebElement FirstNameInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "last_name")]
        [CacheLookup]
        private IWebElement LastNameInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "email")]
        [CacheLookup]
        private IWebElement EmailInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "date_of_birth")]
        [CacheLookup]
        private IWebElement DOBInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "phone_number1")]
        [CacheLookup]
        private IWebElement PhoneNumberInputPRD { get; set; }

        #endregion Patient Information

        #region Additional Information

        [FindsBy(How = How.Id, Using = "phone_number2")]
        [CacheLookup]
        private IWebElement PhoneNumberSecondaryPRD { get; set; }

        [FindsBy(How = How.Id, Using = "address_line_1")]
        [CacheLookup]
        private IWebElement AddressLine1InputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "address_line_2")]
        [CacheLookup]
        private IWebElement AddressLine2InputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "city")]
        [CacheLookup]
        private IWebElement CityInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_state")]
        [CacheLookup]
        private IWebElement StateSelectPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen3_search")]
        [CacheLookup]
        private IWebElement StateSelectInputPRD { get; set; }

        #endregion Additional Information

        #region Specialty Diagnosis

        [FindsBy(How = How.Id, Using = "econsult_reason")]
        [CacheLookup]
        private IWebElement ReasonInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "is_consent")]
        [CacheLookup]
        private IWebElement ConsentInputCheckPRD { get; set; }

        [FindsBy(How = How.Id, Using = "note_area")]
        [CacheLookup]
        private IWebElement AddNoteTextareaPRD { get; set; }

        #endregion

        [FindsBy(How = How.Id, Using = "attachment_input")]
        [CacheLookup]
        private IWebElement Attachment_inputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "submitbutton")]
        [CacheLookup]
        private IWebElement SendBtnPRD { get; set; }

        #endregion

        public String message { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EmailPatient { get; set; }
        public String Gender { get; set; }
        public String PhoneNumber { get; set; }
        public String SecondaryPhoneNumber { get; set; }
        public String AddressLine1 { get; set; }
        public String AddressLine2 { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Dob { get; set; }

        #endregion

        #region Constructor
        public CreatePatientPage()
        {
            Driver = BrowserFactory.Driver;
        }

        public CreatePatientPage(IWebDriver driver, Setup.Settings setup)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            this.Setup = setup;
        }

        #endregion

        #region Methods

        public void CreateNewPatientQA(Int16 module, String Connection)
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            if (this.Driver.FindElements(By.Id("save-patient")).Count != 0)
            {
                MySqlConnection connection = new MySqlConnection(Connection);

                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 8;
                    cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dr);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            FirstName = row["FirstName"].ToString();
                            LastName = row["LastName"].ToString();
                            Dob = row["Dob"].ToString();
                            EmailPatient = row["EmailPatient"].ToString();
                            Gender = row["Gender"].ToString();
                            PhoneNumber = row["PhoneNumber"].ToString();
                            SecondaryPhoneNumber = row["SecondaryPhoneNumber"].ToString();
                            AddressLine1 = row["AddressLine1"].ToString();
                            AddressLine2 = row["AddressLine2"].ToString();
                            City = row["City"].ToString();
                            State = row["State"].ToString();
                        }

                        Thread.Sleep(1000);
                        FirstNameInputQA.SendKeys(FirstName);
                        Thread.Sleep(1000);
                        LastNameInputQA.SendKeys(LastName);
                        Thread.Sleep(1000);
                        EmailInputQA.SendKeys(EmailPatient);
                        Thread.Sleep(1000);
                        DOBInputQA.SendKeys(Dob);
                        Thread.Sleep(1000);

                        if ((Gender) == "M")
                        {
                            this.Driver.FindElement(By.Id("gender_male")).Click();
                        }
                        else
                        {
                            this.Driver.FindElement(By.Id("gender_female")).Click();
                        }

                        PhoneNumberInputQA.SendKeys(PhoneNumber);
                        Thread.Sleep(1000);
                        //RefMrnInput.SendKeys(this.Setup.Data.ObjPatient.MRN);
                        //Thread.Sleep(1000);

                        var elementPhoneNumber2 = Driver.FindElement(By.Id("phone_number2"));
                        Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", elementPhoneNumber2);

                        PhoneNumberSecondaryQA.SendKeys(SecondaryPhoneNumber);
                        Thread.Sleep(1000);
                        AddressLine1InputQA.SendKeys(AddressLine1);
                        Thread.Sleep(1000);
                        AddressLine2InputQA.SendKeys(AddressLine2);
                        Thread.Sleep(1000);
                        CityInputQA.SendKeys(City);
                        Thread.Sleep(1000);

                        StateSelectQA.Click();
                        StateSelectInputQA.SendKeys(State);
                        Thread.Sleep(1000);
                        StateSelectInputQA.SendKeys(Keys.Enter);

                        var elementSubmitBtn = Driver.FindElement(By.Id("submitbutton"));
                        Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", elementSubmitBtn);

                        if (this.Driver.FindElements(By.Id("econsult_reason")).Count != 0)
                        {
                            ReasonInputQA.SendKeys(this.Setup.Data.Consent);
                            Thread.Sleep(1000);
                            ConsentInputCheckQA.Click();
                        }

                        SendBtnQA.Click();

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
        }
        public void CreateNewPatientDEMO(Int16 module, String Connection)
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            if (this.Driver.FindElements(By.Id("save-patient")).Count != 0)
            {
                MySqlConnection connection = new MySqlConnection(Connection);

                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 8;
                    cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dr);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            FirstName = row["FirstName"].ToString();
                            LastName = row["LastName"].ToString();
                            Dob = row["Dob"].ToString();
                            EmailPatient = row["EmailPatient"].ToString();
                            Gender = row["Gender"].ToString();
                            PhoneNumber = row["PhoneNumber"].ToString();
                            SecondaryPhoneNumber = row["SecondaryPhoneNumber"].ToString();
                            AddressLine1 = row["AddressLine1"].ToString();
                            AddressLine2 = row["AddressLine2"].ToString();
                            City = row["City"].ToString();
                            State = row["State"].ToString();
                        }

                        Thread.Sleep(1000);
                        FirstNameInputDEMO.SendKeys(FirstName);
                        Thread.Sleep(1000);
                        LastNameInputDEMO.SendKeys(LastName);
                        Thread.Sleep(1000);
                        EmailInputDEMO.SendKeys(EmailPatient);
                        Thread.Sleep(1000);
                        DOBInputDEMO.SendKeys(Dob);
                        Thread.Sleep(1000);

                        if ((Gender) == "M")
                        {
                            this.Driver.FindElement(By.Id("gender_male")).Click();
                        }
                        else
                        {
                            this.Driver.FindElement(By.Id("gender_female")).Click();
                        }

                        PhoneNumberInputDEMO.SendKeys(PhoneNumber);
                        Thread.Sleep(1000);
                        //RefMrnInput.SendKeys(this.Setup.Data.ObjPatient.MRN);
                        //Thread.Sleep(1000);

                        var elementPhoneNumber2 = Driver.FindElement(By.Id("phone_number2"));
                        Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", elementPhoneNumber2);

                        PhoneNumberSecondaryDEMO.SendKeys(SecondaryPhoneNumber);
                        Thread.Sleep(1000);
                        AddressLine1InputDEMO.SendKeys(AddressLine1);
                        Thread.Sleep(1000);
                        AddressLine2InputDEMO.SendKeys(AddressLine2);
                        Thread.Sleep(1000);
                        CityInputDEMO.SendKeys(City);
                        Thread.Sleep(1000);

                        StateSelectDEMO.Click();
                        StateSelectInputDEMO.SendKeys(State);
                        Thread.Sleep(1000);
                        StateSelectInputDEMO.SendKeys(Keys.Enter);

                        var elementSubmitBtn = Driver.FindElement(By.Id("submitbutton"));
                        Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", elementSubmitBtn);

                        if (this.Driver.FindElements(By.Id("econsult_reason")).Count != 0)
                        {
                            ReasonInputDEMO.SendKeys(this.Setup.Data.Consent);
                            Thread.Sleep(1000);
                            ConsentInputCheckDEMO.Click();
                        }

                        SendBtnDEMO.Click();

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
        }
        public void CreateNewPatientPRD(Int16 module, String Connection)
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            if (this.Driver.FindElements(By.Id("save-patient")).Count != 0)
            {
                MySqlConnection connection = new MySqlConnection(Connection);

                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 8;
                    cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                    MySqlDataReader dr = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(dr);

                    if (dataTable.Rows.Count > 0)
                    {
                        foreach (DataRow row in dataTable.Rows)
                        {
                            FirstName = row["FirstName"].ToString();
                            LastName = row["LastName"].ToString();
                            Dob = row["Dob"].ToString();
                            EmailPatient = row["EmailPatient"].ToString();
                            Gender = row["Gender"].ToString();
                            PhoneNumber = row["PhoneNumber"].ToString();
                            SecondaryPhoneNumber = row["SecondaryPhoneNumber"].ToString();
                            AddressLine1 = row["AddressLine1"].ToString();
                            AddressLine2 = row["AddressLine2"].ToString();
                            City = row["City"].ToString();
                            State = row["State"].ToString();
                        }

                        Thread.Sleep(1000);
                        FirstNameInputPRD.SendKeys(FirstName);
                        Thread.Sleep(1000);
                        LastNameInputPRD.SendKeys(LastName);
                        Thread.Sleep(1000);
                        EmailInputPRD.SendKeys(EmailPatient);
                        Thread.Sleep(1000);
                        DOBInputPRD.SendKeys(Dob);
                        Thread.Sleep(1000);

                        if ((Gender) == "M")
                        {
                            this.Driver.FindElement(By.Id("gender_male")).Click();
                        }
                        else
                        {
                            this.Driver.FindElement(By.Id("gender_female")).Click();
                        }

                        PhoneNumberInputPRD.SendKeys(PhoneNumber);
                        Thread.Sleep(1000);
                        //RefMrnInput.SendKeys(this.Setup.Data.ObjPatient.MRN);
                        //Thread.Sleep(1000);

                        var elementPhoneNumber2 = Driver.FindElement(By.Id("phone_number2"));
                        Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", elementPhoneNumber2);

                        PhoneNumberSecondaryPRD.SendKeys(SecondaryPhoneNumber);
                        Thread.Sleep(1000);
                        AddressLine1InputPRD.SendKeys(AddressLine1);
                        Thread.Sleep(1000);
                        AddressLine2InputPRD.SendKeys(AddressLine2);
                        Thread.Sleep(1000);
                        CityInputPRD.SendKeys(City);
                        Thread.Sleep(1000);

                        StateSelectPRD.Click();
                        StateSelectInputPRD.SendKeys(State);
                        Thread.Sleep(1000);
                        StateSelectInputPRD.SendKeys(Keys.Enter);

                        var elementSubmitBtn = Driver.FindElement(By.Id("submitbutton"));
                        Driver.ExecuteJavaScript("arguments[0].scrollIntoView(true);", elementSubmitBtn);

                        if (this.Driver.FindElements(By.Id("econsult_reason")).Count != 0)
                        {
                            ReasonInputPRD.SendKeys(this.Setup.Data.Consent);
                            Thread.Sleep(1000);
                            ConsentInputCheckPRD.Click();
                        }

                        SendBtnPRD.Click();

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
        }
        #endregion
    }
}