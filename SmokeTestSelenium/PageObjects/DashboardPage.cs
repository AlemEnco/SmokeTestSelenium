using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SmokeTestSelenium.WrapperFactory;
using System.Data;

namespace SmokeTestSelenium.PageObjects
{
    public class DashboardPage : BasePage
    {
        #region Properties

        #region QA

        #region Creation Appointment

        [FindsBy(How = How.Id, Using = "find-provider-econsult")]
        [CacheLookup]
        private IWebElement eConsultBtnQA { get; set; }

        [FindsBy(How = How.Id, Using = "find-provider-referral")]
        [CacheLookup]
        private IWebElement ReferallBtnQA { get; set; }

        #region MRN Search

        #region MRN Search eConsult

        [FindsBy(How = How.Id, Using = "s2id_select-location-mrn")]
        [CacheLookup]
        private IWebElement LocationMrnSelectQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen10_search")]
        [CacheLookup]
        private IWebElement LocationMrnSelectInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-mrn")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen12_search")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-cpt-mrn")]

        #endregion

        #region MRN Search Referral

        [FindsBy(How = How.Id, Using = "s2id_select-location-mrn")]
        [CacheLookup]
        private IWebElement LocationMrnSelectReferralQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen10_search")]
        [CacheLookup]
        private IWebElement LocationMrnSelectInputReferralQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-mrn")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectReferralQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen12_search")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectInputReferralQA { get; set; }

        #endregion

        #endregion

        #region Member Id Search

        [FindsBy(How = How.Id, Using = "base_member_id_search")]
        [CacheLookup]
        private IWebElement MemberIdSearchTabQA { get; set; }

        #region Member Id Search eConsult        

        [FindsBy(How = How.Id, Using = "s2id_select-location-member-id")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen15_search")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectInputQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-member-id")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen18_search")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectInputQA { get; set; }

        #endregion

        #region Member Id Search Referral

        [FindsBy(How = How.Id, Using = "s2id_select-location-member-id")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectReferralQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen15_search")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectInputReferralQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-member-id")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectReferralQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen18_search")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectInputReferralQA { get; set; }

        #endregion

        #endregion

        #region Insurance Search

        [FindsBy(How = How.Id, Using = "base_specialty_search")]
        [CacheLookup]
        private IWebElement InsuranceSearchTabQA { get; set; }

        #region Insurance Search eConsult        

        [FindsBy(How = How.Id, Using = "s2id_select-specialty")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen2_search")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectInputQA { get; set; }

        #endregion

        #region Insurance Search Referral

        [FindsBy(How = How.Id, Using = "s2id_select-specialty")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectReferralQA { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen2_search")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectInputReferralQA { get; set; }

        #endregion

        #endregion

        [FindsBy(How = How.ClassName, Using = "find-providers-submit")]
        [CacheLookup]
        private IWebElement FindProvidersBtnQA { get; set; }

        #endregion

        #region Select an appointment

        #region eConsult

        [FindsBy(How = How.Id, Using = "ajax-econsults-requests")]
        [CacheLookup]
        private IWebElement RequestseConsulOptionQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='econsults-requests']/div/ul/li[1]/div/div[1]/span[1]/a")]
        [CacheLookup]
        private IWebElement FirsteConsulCreatedQA { get; set; }

        #endregion

        #region Referrals

        [FindsBy(How = How.ClassName, Using = "tab_referral")]
        [CacheLookup]
        private IWebElement ReferralTabQA { get; set; }

        [FindsBy(How = How.Id, Using = "ajax-request")]
        [CacheLookup]
        private IWebElement RequestsReferralOptionQA { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='referrals']/div[3]/ul/li[1]/div/div[1]/span[2]/a")]
        [CacheLookup]
        private IWebElement FirstReferralCreatedQA { get; set; }

        #endregion

        #endregion

        #endregion

        #region DEMO

        #region Creation Appointment

        [FindsBy(How = How.Id, Using = "find-provider-econsult")]
        [CacheLookup]
        private IWebElement eConsultBtnDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "find-provider-referral")]
        [CacheLookup]
        private IWebElement ReferallBtnDEMO { get; set; }

        #region MRN Search

        #region MRN Search eConsult

        [FindsBy(How = How.Id, Using = "s2id_select-location-mrn")]
        [CacheLookup]
        private IWebElement LocationMrnSelectDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen6_search")]
        [CacheLookup]
        private IWebElement LocationMrnSelectInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-mrn")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen8_search")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectInputDEMO { get; set; }

        #endregion

        #region MRN Search Referral

        [FindsBy(How = How.Id, Using = "s2id_select-location-mrn")]
        [CacheLookup]
        private IWebElement LocationMrnSelectReferralDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen6_search")]
        [CacheLookup]
        private IWebElement LocationMrnSelectInputReferralDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-mrn")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectReferralDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen8_search")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectInputReferralDEMO { get; set; }

        #endregion

        #endregion

        #region Member Id Search

        [FindsBy(How = How.Id, Using = "base_member_id_search")]
        [CacheLookup]
        private IWebElement MemberIdSearchTabDEMO { get; set; }

        #region Member Id Search eConsult        

        [FindsBy(How = How.Id, Using = "s2id_select-location-member-id")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen11_search")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectInputDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-member-id")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen14_search")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectInputDEMO { get; set; }

        #endregion

        #region Member Id Search Referral

        [FindsBy(How = How.Id, Using = "s2id_select-location-member-id")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectReferralDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen15_search")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectInputReferralDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-member-id")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectReferralDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen18_search")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectInputReferralDEMO { get; set; }

        #endregion

        #endregion

        #region Insurance Search

        [FindsBy(How = How.Id, Using = "base_specialty_search")]
        [CacheLookup]
        private IWebElement InsuranceSearchTabDEMO { get; set; }

        #region Insurance Search eConsult        

        [FindsBy(How = How.Id, Using = "s2id_select-specialty")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen2_search")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectInputDEMO { get; set; }

        #endregion

        #region Insurance Search Referral

        [FindsBy(How = How.Id, Using = "s2id_select-specialty")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectReferralDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen2_search")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectInputReferralDEMO { get; set; }

        #endregion

        #endregion

        [FindsBy(How = How.ClassName, Using = "find-providers-submit")]
        [CacheLookup]
        private IWebElement FindProvidersBtnDEMO { get; set; }

        #endregion

        #region Select an appointment

        #region eConsult

        [FindsBy(How = How.Id, Using = "ajax-econsults-requests")]
        [CacheLookup]
        private IWebElement RequestseConsulOptionDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='econsults-requests']/div/ul/li[1]/div/div[1]/span[1]/a")]
        [CacheLookup]
        private IWebElement FirsteConsulCreatedDEMO { get; set; }

        #endregion

        #region Referrals

        [FindsBy(How = How.ClassName, Using = "tab_referral")]
        [CacheLookup]
        private IWebElement ReferralTabDEMO { get; set; }

        [FindsBy(How = How.Id, Using = "ajax-request")]
        [CacheLookup]
        private IWebElement RequestsReferralOptionDEMO { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='referrals']/div[3]/ul/li[1]/div/div[1]/span[2]/a")]
        [CacheLookup]
        private IWebElement FirstReferralCreatedDEMO { get; set; }

        #endregion

        #endregion

        #endregion

        #region PRD

        #region Creation Appointment

        [FindsBy(How = How.Id, Using = "find-provider-econsult")]
        [CacheLookup]
        private IWebElement eConsultBtnPRD { get; set; }

        [FindsBy(How = How.Id, Using = "find-provider-referral")]
        [CacheLookup]
        private IWebElement ReferallBtnPRD { get; set; }

        #region MRN Search

        #region MRN Search eConsult

        [FindsBy(How = How.Id, Using = "s2id_select-location-mrn")]
        [CacheLookup]
        private IWebElement LocationMrnSelectPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen6_search")]
        [CacheLookup]
        private IWebElement LocationMrnSelectInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-mrn")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen8_search")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectInputPRD { get; set; }

        #endregion

        #region MRN Search Referral

        [FindsBy(How = How.Id, Using = "s2id_select-location-mrn")]
        [CacheLookup]
        private IWebElement LocationMrnSelectReferralPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen6_search")]
        [CacheLookup]
        private IWebElement LocationMrnSelectInputReferralPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-mrn")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectReferralPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen8_search")]
        [CacheLookup]
        private IWebElement SpecialtyMrnSelectInputReferralPRD { get; set; }

        #endregion

        #endregion

        #region Member Id Search

        [FindsBy(How = How.Id, Using = "base_member_id_search")]
        [CacheLookup]
        private IWebElement MemberIdSearchTabPRD { get; set; }

        #region Member Id Search eConsult        

        [FindsBy(How = How.Id, Using = "s2id_select-location-member-id")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen11_search")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectInputPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-member-id")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen14_search")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectInputPRD { get; set; }

        #endregion

        #region Member Id Search Referral

        [FindsBy(How = How.Id, Using = "s2id_select-location-member-id")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectReferralPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen15_search")]
        [CacheLookup]
        private IWebElement LocationMemberIdSelectInputReferralPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_select-specialty-member-id")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectReferralPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen18_search")]
        [CacheLookup]
        private IWebElement SpecialtyMemberIdSelectInputReferralPRD { get; set; }

        #endregion

        #endregion

        #region Insurance Search

        [FindsBy(How = How.Id, Using = "base_specialty_search")]
        [CacheLookup]
        private IWebElement InsuranceSearchTabPRD { get; set; }

        #region Insurance Search eConsult        

        [FindsBy(How = How.Id, Using = "s2id_select-specialty")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen2_search")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectInputPRD { get; set; }

        #endregion

        #region Insurance Search Referral

        [FindsBy(How = How.Id, Using = "s2id_select-specialty")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectReferralPRD { get; set; }

        [FindsBy(How = How.Id, Using = "s2id_autogen2_search")]
        [CacheLookup]
        private IWebElement SpecialtyInsuranceSelectInputReferralPRD { get; set; }

        #endregion

        #endregion

        [FindsBy(How = How.ClassName, Using = "find-providers-submit")]
        [CacheLookup]
        private IWebElement FindProvidersBtnPRD { get; set; }

        #endregion

        #region Select an appointment

        #region eConsult

        [FindsBy(How = How.Id, Using = "ajax-econsults-requests")]
        [CacheLookup]
        private IWebElement RequestseConsulOptionPRD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='econsults-requests']/div/ul/li[1]/div/div[1]/span[1]/a")]
        [CacheLookup]
        private IWebElement FirsteConsulCreatedPRD { get; set; }

        #endregion

        #region Referrals

        [FindsBy(How = How.ClassName, Using = "tab_referral")]
        [CacheLookup]
        private IWebElement ReferralTabPRD { get; set; }

        [FindsBy(How = How.Id, Using = "ajax-request")]
        [CacheLookup]
        private IWebElement RequestsReferralOptionPRD { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='referrals']/div[3]/ul/li[1]/div/div[1]/span[2]/a")]
        [CacheLookup]
        private IWebElement FirstReferralCreatedPRD { get; set; }

        #endregion

        #endregion

        #endregion

        public String message { get; set; }
        public String LocationDescription { get; set; }
        public String SpecialtyDescription { get; set; }
        public String TypeSearch { get; set; }

        #endregion

        #region Constructor
        public DashboardPage()
        {
            Driver = BrowserFactory.Driver;
        }

        public DashboardPage(IWebDriver driver, Setup.Settings setup)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
            this.Setup = setup;
        }
        #endregion

        #region Methods

        public void FindNewProvidereConsultQA(Int16 module, String Connection)
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            eConsultBtnQA.Click();

            MySqlConnection connection = new MySqlConnection(Connection);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 3;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "1")
                        {
                            LocationDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "3")
                        {
                            SpecialtyDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "10")
                        {
                            TypeSearch = row["value"].ToString();
                        }
                    }

                    switch (TypeSearch)
                    {
                        case "1":
                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectQA.Click();
                                LocationMrnSelectInputQA.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectInputQA.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectQA.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputQA.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputQA.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnQA.Click();

                            break;

                        case "2":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            MemberIdSearchTabQA.Click();

                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectQA.Click();
                                LocationMemberIdSelectInputQA.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectInputQA.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectQA.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputQA.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputQA.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnQA.Click();

                            break;

                        case "3":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            InsuranceSearchTabQA.Click();

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectQA.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputQA.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputQA.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnQA.Click();

                            break;
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
        public void FindNewProvidereConsultDEMO(Int16 module, String Connection)
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            eConsultBtnDEMO.Click();

            MySqlConnection connection = new MySqlConnection(Connection);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 3;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "1")
                        {
                            LocationDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "3")
                        {
                            SpecialtyDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "10")
                        {
                            TypeSearch = row["value"].ToString();
                        }
                    }

                    switch (TypeSearch)
                    {
                        case "1":
                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectDEMO.Click();
                                LocationMrnSelectInputDEMO.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectInputDEMO.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectDEMO.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputDEMO.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputDEMO.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnDEMO.Click();

                            break;

                        case "2":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            MemberIdSearchTabDEMO.Click();

                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectDEMO.Click();
                                LocationMemberIdSelectInputDEMO.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectInputDEMO.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectDEMO.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputDEMO.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputDEMO.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnDEMO.Click();

                            break;

                        case "3":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            InsuranceSearchTabDEMO.Click();

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectDEMO.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputDEMO.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputDEMO.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnDEMO.Click();

                            break;
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
        public void FindNewProvidereConsultPRD(Int16 module, String Connection)
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            eConsultBtnPRD.Click();

            MySqlConnection connection = new MySqlConnection(Connection);
            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 3;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "1")
                        {
                            LocationDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "3")
                        {
                            SpecialtyDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "10")
                        {
                            TypeSearch = row["value"].ToString();
                        }
                    }

                    switch (TypeSearch)
                    {
                        case "1":
                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectPRD.Click();
                                LocationMrnSelectInputPRD.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectInputPRD.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectPRD.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputPRD.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputPRD.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnPRD.Click();

                            break;

                        case "2":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            MemberIdSearchTabPRD.Click();

                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectPRD.Click();
                                LocationMemberIdSelectInputPRD.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectInputPRD.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectPRD.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputPRD.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputPRD.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnPRD.Click();

                            break;

                        case "3":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            InsuranceSearchTabPRD.Click();

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectPRD.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputPRD.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputPRD.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnPRD.Click();

                            break;
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

        public void FindNewProviderReferralQA(Int16 module, String Connection)
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            ReferallBtnQA.Click();

            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 3;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "1")
                        {
                            LocationDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "3")
                        {
                            SpecialtyDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "10")
                        {
                            TypeSearch = row["value"].ToString();
                        }
                    }

                    switch (TypeSearch)
                    {
                        case "1":

                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectReferralQA.Click();
                                LocationMrnSelectInputReferralQA.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectInputReferralQA.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectReferralQA.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputReferralQA.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputReferralQA.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnQA.Click();

                            break;

                        case "2":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            MemberIdSearchTabQA.Click();

                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectReferralQA.Click();
                                LocationMemberIdSelectInputReferralQA.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectInputReferralQA.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectReferralQA.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputReferralQA.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputReferralQA.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnQA.Click();

                            break;

                        case "3":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            InsuranceSearchTabQA.Click();

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectReferralQA.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputReferralQA.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputReferralQA.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnQA.Click();

                            break;
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
        public void FindNewProviderReferralDEMO(Int16 module, String Connection)
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            ReferallBtnDEMO.Click();

            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 3;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "1")
                        {
                            LocationDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "3")
                        {
                            SpecialtyDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "10")
                        {
                            TypeSearch = row["value"].ToString();
                        }
                    }

                    switch (TypeSearch)
                    {
                        case "1":

                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectReferralDEMO.Click();
                                LocationMrnSelectInputReferralDEMO.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectInputReferralDEMO.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectReferralDEMO.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputReferralDEMO.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputReferralDEMO.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnDEMO.Click();

                            break;

                        case "2":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            MemberIdSearchTabDEMO.Click();

                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectReferralDEMO.Click();
                                LocationMemberIdSelectInputReferralDEMO.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectInputReferralDEMO.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectReferralDEMO.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputReferralDEMO.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputReferralDEMO.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnDEMO.Click();

                            break;

                        case "3":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            InsuranceSearchTabDEMO.Click();

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectReferralDEMO.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputReferralDEMO.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputReferralDEMO.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnDEMO.Click();

                            break;
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
        public void FindNewProviderReferralPRD(Int16 module, String Connection)
        {
            Thread.Sleep(this.Setup.SmWaitTime);
            ReferallBtnPRD.Click();

            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 3;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "1")
                        {
                            LocationDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "3")
                        {
                            SpecialtyDescription = row["value"].ToString();
                        }
                        else if (idJsonParameter == "10")
                        {
                            TypeSearch = row["value"].ToString();
                        }
                    }

                    switch (TypeSearch)
                    {
                        case "1":

                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectReferralPRD.Click();
                                LocationMrnSelectInputReferralPRD.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMrnSelectInputReferralPRD.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectReferralPRD.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputReferralPRD.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMrnSelectInputReferralPRD.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnPRD.Click();

                            break;

                        case "2":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            MemberIdSearchTabPRD.Click();

                            if (LocationDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectReferralPRD.Click();
                                LocationMemberIdSelectInputReferralPRD.SendKeys(LocationDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                LocationMemberIdSelectInputReferralPRD.SendKeys(Keys.Enter);
                            }

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectReferralPRD.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputReferralPRD.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyMemberIdSelectInputReferralPRD.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnPRD.Click();

                            break;

                        case "3":

                            Thread.Sleep(this.Setup.SmWaitTime);
                            InsuranceSearchTabPRD.Click();

                            if (SpecialtyDescription is not null)
                            {
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectReferralPRD.Click();
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputReferralPRD.SendKeys(SpecialtyDescription);
                                Thread.Sleep(this.Setup.SmWaitTime);
                                SpecialtyInsuranceSelectInputReferralPRD.SendKeys(Keys.Enter);
                            }

                            FindProvidersBtnPRD.Click();

                            break;
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

        public void SelecteConsultQA(Int16 module, String Connection)
        {
            RequestseConsulOptionQA.Click();
            FirsteConsulCreatedQA.Click();
        }
        public void SelecteConsultDEMO(Int16 module, String Connection)
        {
            RequestseConsulOptionDEMO.Click();
            FirsteConsulCreatedDEMO.Click();
        }
        public void SelecteConsultPRD(Int16 module, String Connection)
        {
            RequestseConsulOptionPRD.Click();
            FirsteConsulCreatedPRD.Click();
        }

        public void SelectReferralQA(Int16 module, String Connection)
        {
            ReferralTabQA.Click();
            //wait until
            RequestsReferralOptionQA.Click();
            //wait until
            FirstReferralCreatedQA.Click();
        }
        public void SelectReferralDEMO(Int16 module, String Connection)
        {
            ReferralTabDEMO.Click();
            //wait until
            RequestsReferralOptionDEMO.Click();
            //wait until
            FirstReferralCreatedDEMO.Click();
        }
        public void SelectReferralPRD(Int16 module, String Connection)
        {
            ReferralTabDEMO.Click();
            //wait until
            RequestsReferralOptionDEMO.Click();
            //wait until
            FirstReferralCreatedDEMO.Click();
        }

        #endregion
    }
}