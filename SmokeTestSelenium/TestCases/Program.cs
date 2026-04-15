using SmokeTestSelenium.Interface;
using SmokeTestSelenium.PageObjects;
using SmokeTestSelenium.Setup;
using SmokeTestSelenium.Setup.Entity;
using SmokeTestSelenium.Setup.Enum;
using SmokeTestSelenium.Setup.Libs;
using SmokeTestSelenium.WrapperFactory;
using System.Data;

namespace SmokeTestSelenium.TestCases
{
    public class Program : IAppointment
    {

        [TestCase(60, 1000, "TestReferralSearchByInsurance", (Int16)EnumModule.LoginYodaProviderReferraltelevideoSearchbyMRNUploadFileHighPriorityNotesFiles)]

        public async Task AppointmentCreate(Int16 order, Int16 wait, String Test, Int16 module)
        {
            String? message = "";
            String? TypeAppointment = "";
            String? EditAppointment = "";
            String? CreateNewPatient = "";
            String? GoDashboard = "";

            //Configuration to connect Consul
            ConsulConnection consulConnection = new ConsulConnection();
            DatabaseSettings json = await consulConnection.GetPairAsync<DatabaseSettings>("automation/selenium");

            MySqlConnectionStringBuilder builder = new();
            builder.Server = json.Database.Host;
            builder.Database = json.Database.Data;
            builder.UserID = json.Database.User;
            builder.Password = json.Database.Pass;
            string Connection = builder.ToString();

            MySqlConnection connection = new MySqlConnection(Connection);

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand("Get_SmokeTestCase_Data", connection);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Id_Consult", MySqlDbType.Int32).Value = 1;
                cmd.Parameters.AddWithValue("Id_TestCase", MySqlDbType.Int32).Value = module;
                MySqlDataReader dr = cmd.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dr);

                if (dataTable.Rows.Count > 0)
                {
                    var ArrayTable = dataTable.Rows[0];
                    var environment = ArrayTable[1];
                    var typeUser = ArrayTable[2];

                    foreach (DataRow row in dataTable.Rows)
                    {
                        var idJsonParameter = row["idJsonParameter"].ToString();

                        if (idJsonParameter == "11")
                        {
                            TypeAppointment = row["value"].ToString();
                        }
                        else if (idJsonParameter == "16")
                        {
                            EditAppointment = row["value"].ToString();
                        }
                        else if (idJsonParameter == "13")
                        {
                            CreateNewPatient = row["value"].ToString();
                        }
                        else if (idJsonParameter == "17")
                        {
                            GoDashboard = row["value"].ToString();
                        }
                    }
                    Thread.Sleep(1000);

                    //Configuration
                    Settings objSetup = new Settings(wait, Test);

                    //InitBrowser and environment
                    BrowserFactory.InitBrowser(objSetup.Data.Browser);
                    BrowserFactory.LoadApplication(Convert.ToInt16(environment));

                    //AppointmentProcess
                    LoginPage objLoginPage = new LoginPage(BrowserFactory.Driver, objSetup);
                    YodaPage objYodaPage = new YodaPage(BrowserFactory.Driver, objSetup);
                    PracticeAdministratorPage objPracticeAdministratorPage = new PracticeAdministratorPage(BrowserFactory.Driver, objSetup);
                    DashboardPage objDashboardPage = new DashboardPage(BrowserFactory.Driver, objSetup);
                    SelectProviderPage objSelectProviderPage = new SelectProviderPage(BrowserFactory.Driver, objSetup);
                    SearchPatientPage objSearchPatientPage = new SearchPatientPage(BrowserFactory.Driver, objSetup);
                    CreatePatientPage objCreatePatientPage = new CreatePatientPage(BrowserFactory.Driver, objSetup);
                    PatientInformationPage objPatientInformationPage = new PatientInformationPage(BrowserFactory.Driver, objSetup);
                    PrintPage objPrintPage = new PrintPage(BrowserFactory.Driver, objSetup);
                    AppointmentDetailPage objAppointmentDetailPage = new AppointmentDetailPage(BrowserFactory.Driver, objSetup);

                    //Start flow of testcases
                    if (environment == "1") // QA
                    {
                        if (typeUser == "1") //Provider
                        {
                            objLoginPage.LoginQA(module, Connection);

                        }
                        else if (typeUser == "2") // PAdmin
                        {
                            objPracticeAdministratorPage.SearchProviderQA(module, Connection);
                        }
                        else // YODA USer
                        {
                            objYodaPage.BecomeProviderQA(module, Connection);
                        }

                        if (TypeAppointment == "1") // eConsult
                        {
                            objDashboardPage.FindNewProvidereConsultQA(module, Connection);
                            objSelectProviderPage.RequesteConsultSessionQA();

                            if (CreateNewPatient == "1")
                            {
                                objSearchPatientPage.SelectNewPatientQA();
                                objCreatePatientPage.CreateNewPatientQA(module, Connection);
                            }
                            else
                            {
                                objSearchPatientPage.AddPatientQA(module, Connection);
                                objPatientInformationPage.PatientInformationConsentQA(module, Connection);
                            }

                            if (GoDashboard == "1")
                            {
                                objPrintPage.ValidarQA(module, Connection);
                                objDashboardPage.SelecteConsultQA(module, Connection);

                                if (EditAppointment == "1")
                                {
                                    objAppointmentDetailPage.EditAppointmentDetailQA(module, Connection);
                                }
                                else
                                {
                                    objAppointmentDetailPage.CreateNoteQA(module, Connection);
                                }
                            }
                            else
                            {
                                objPrintPage.ValidarQA(module, Connection);
                            }
                        }
                        else // Referral
                        {
                            objDashboardPage.FindNewProviderReferralQA(module, Connection);
                            objSelectProviderPage.RequestReferralSessionQA(module, Connection);
                            objSearchPatientPage.AddPatientQA(module, Connection);
                            objPatientInformationPage.PatientInformationConsentQA(module, Connection);

                            if(GoDashboard == "1")
                            {
                                objPrintPage.ValidarQA(module, Connection);
                                objDashboardPage.SelectReferralQA(module, Connection);

                                if(EditAppointment == "1")
                                {
                                    objAppointmentDetailPage.EditAppointmentDetailQA(module, Connection);
                                }
                                else
                                {
                                    objAppointmentDetailPage.CreateNoteQA(module, Connection);
                                }
                            }
                            else
                            {
                                objPrintPage.ValidarQA(module, Connection);
                            }
                        }
                    }
                    else if (environment == "2") // DEMO
                    {
                        if (typeUser == "1") //Provider
                        {
                            objLoginPage.LoginDEMO(module, Connection);

                        }
                        else if (typeUser == "2") // PAdmin
                        {
                            objPracticeAdministratorPage.SearchProviderDEMO(module, Connection);
                        }
                        else // YODA USer
                        {
                            objYodaPage.BecomeProviderDEMO(module, Connection);
                        }

                        if (TypeAppointment == "1") // eConsult
                        {
                            objDashboardPage.FindNewProvidereConsultDEMO(module, Connection);
                            objSelectProviderPage.RequesteConsultSessionDEMO();

                            if (CreateNewPatient == "1")
                            {
                                objSearchPatientPage.SelectNewPatientDEMO();
                                objCreatePatientPage.CreateNewPatientDEMO(module, Connection);
                            }
                            else
                            {
                                objSearchPatientPage.AddPatientDEMO(module, Connection);
                                objPatientInformationPage.PatientInformationConsentDEMO(module, Connection);
                            }

                            if (GoDashboard == "1")
                            {
                                objPrintPage.ValidarDEMO(module, Connection);
                                objDashboardPage.SelecteConsultDEMO(module, Connection);

                                if (EditAppointment == "1")
                                {
                                    objAppointmentDetailPage.EditAppointmentDetailDEMO(module, Connection);
                                }
                                else
                                {
                                    objAppointmentDetailPage.CreateNoteDEMO(module, Connection);
                                }
                            }
                            else
                            {
                                objPrintPage.ValidarDEMO(module, Connection);
                            }
                        }
                        else // Referral
                        {
                            objDashboardPage.FindNewProviderReferralDEMO(module, Connection);
                            objSelectProviderPage.RequestReferralSessionDEMO(module, Connection);
                            objSearchPatientPage.AddPatientDEMO(module, Connection);
                            objPatientInformationPage.PatientInformationConsentDEMO(module, Connection);

                            if (GoDashboard == "1")
                            {
                                objPrintPage.ValidarDEMO(module, Connection);
                                objDashboardPage.SelectReferralDEMO(module, Connection);

                                if (EditAppointment == "1")
                                {
                                    objAppointmentDetailPage.EditAppointmentDetailDEMO(module, Connection);
                                }
                                else
                                {
                                    objAppointmentDetailPage.CreateNoteDEMO(module, Connection);
                                }
                            }
                            else
                            {
                                objPrintPage.ValidarDEMO(module, Connection);
                            }
                        }
                    }
                    else // PRD
                    {
                        if (typeUser == "1") //Provider
                        {
                            objLoginPage.LoginPRD(module, Connection);

                        }
                        else if (typeUser == "2") // PAdmin
                        {
                            objPracticeAdministratorPage.SearchProviderPRD(module, Connection);
                        }
                        else // YODA USer
                        {
                            objYodaPage.BecomeProviderPRD(module, Connection);
                        }

                        if (TypeAppointment == "1") // eConsult
                        {
                            objDashboardPage.FindNewProvidereConsultPRD(module, Connection);
                            objSelectProviderPage.RequesteConsultSessionPRD();

                            if (CreateNewPatient == "1")
                            {
                                objSearchPatientPage.SelectNewPatientPRD();
                                objCreatePatientPage.CreateNewPatientPRD(module, Connection);
                            }
                            else
                            {
                                objSearchPatientPage.AddPatientPRD(module, Connection);
                                objPatientInformationPage.PatientInformationConsentPRD(module, Connection);
                            }

                            if (GoDashboard == "1")
                            {
                                objPrintPage.ValidarPRD(module, Connection);
                                objDashboardPage.SelecteConsultPRD(module, Connection);

                                if (EditAppointment == "1")
                                {
                                    objAppointmentDetailPage.EditAppointmentDetailPRD(module, Connection);
                                }
                                else
                                {
                                    objAppointmentDetailPage.CreateNotePRD(module, Connection);
                                }
                            }
                            else
                            {
                                objPrintPage.ValidarPRD(module, Connection);
                            }
                        }
                        else // Referral
                        {
                            objDashboardPage.FindNewProviderReferralPRD(module, Connection);
                            objSelectProviderPage.RequestReferralSessionPRD(module, Connection);
                            objSearchPatientPage.AddPatientPRD(module, Connection);
                            objPatientInformationPage.PatientInformationConsentPRD(module, Connection);

                            if (GoDashboard == "1")
                            {
                                objPrintPage.ValidarPRD(module, Connection);
                                objDashboardPage.SelectReferralPRD(module, Connection);

                                if (EditAppointment == "1")
                                {
                                    objAppointmentDetailPage.EditAppointmentDetailPRD(module, Connection);
                                }
                                else
                                {
                                    objAppointmentDetailPage.CreateNotePRD(module, Connection);
                                }
                            }
                            else
                            {
                                objPrintPage.ValidarPRD(module, Connection);
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
    }
}