# Smoke Test Automation

## Index

1. [Description](#description)
2. [Requirements](#requirements)
3. [Project Structure](#project-structure)
4. [Access to the Project](#access-to-the-project)
5. [NuGet Packages](#nuget-packages)
6. [Configuration](#configuration)
7. [Environments](#environments)
8. [Page Objects](#page-objects)
9. [Running Tests](#running-tests)
10. [Languages & Technologies](#languages--technologies)
11. [Documentation](#documentation)

---

## Description

This project contains the automation of smoke tests for the **** platform, developed and maintained by the QA team. It covers end-to-end flows including login, referral creation, patient search, appointment management, notes, file uploads, and logout across multiple environments (QA, DEMO).

The framework is built using the **Page Object Model (POM)** pattern with **NUnit** as the test runner and **Selenium WebDriver 4** for browser automation.

---

## Requirements

- [Visual Studio Community](https://visualstudio.microsoft.com/) (latest version) with the **.NET desktop development** workload installed
- [.NET 6.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
- [Git Desktop](https://desktop.github.com/) — log in with the `.zltech` account
- [MySQL Workbench Community](https://www.mysql.com/products/workbench/) (latest version)
- **Google Chrome** browser installed (ChromeDriver v111 is bundled via NuGet)
- Access to the **Consul** service (`http://consul.service.consul:8500`) for configuration retrieval

---

## Project Structure

```
SmokeTestSelenium/
├── Interface/
│   └── IAppointment.cs          # Contract for test case classes
├── PageObjects/
│   ├── BasePage.cs              # Base class with shared Driver and Setup references
│   ├── LoginPage.cs             # Login flow (QA / DEMO / PRD)
│   ├── YodaPage.cs              # Yoda admin: become provider
│   ├── PracticeAdministratorPage.cs  # Practice admin: search provider
│   ├── DashboardPage.cs         # Dashboard navigation and referral/eConsult selection
│   ├── SelectProviderPage.cs    # Provider selection
│   ├── SearchPatientPage.cs     # Patient search by MRN / insurance
│   ├── CreatePatientPage.cs     # New patient creation
│   ├── PatientInformationPage.cs # Patient info & consent
│   ├── AppointmentDetailPage.cs # Appointment detail, notes, file upload
│   └── PrintPage.cs             # Print page / logout
├── Setup/
│   ├── Settings.cs              # Loads test data from JSON file
│   ├── Data/
│   │   └── dataSmokeTest.json   # Test data (browser, credentials, etc.)
│   ├── Entity/
│   │   ├── AppointmentEntity.cs # Data model for test configuration
│   │   └── DatabaseSettings.cs  # DB connection model from Consul
│   ├── Enum/
│   │   └── EnumAppointment.cs   # Enum of test module identifiers
│   └── Libs/
│       └── ConsulConnection.cs  # Consul KV store client
├── TestCases/
│   └── Program.cs               # Main NUnit test class (AppointmentCreate)
├── WrapperFactory/
│   └── BrowserFactory.cs        # WebDriver initialization and URL loading
└── Usings.cs                    # Global using directives
```

---

## Access to the Project

1. Open **Git Desktop** and clone the repository into a local folder.
2. Open **Visual Studio** → **Clone a Repository** → select the project from GitHub.
3. Open the solution file `SmokeTestSelenium.sln`.
4. Restore NuGet packages automatically (or via **Tools → NuGet Package Manager → Manage NuGet Packages for Solution**).
5. Build the solution (**Build → Build Solution** or `Ctrl+Shift+B`).

---

## NuGet Packages

| Package | Version |
|---|---|
| `Consul` | 1.6.10.8 |
| `coverlet.collector` | 3.2.0 |
| `DotNetSeleniumExtras.PageObjects.Core` | 4.3.0 |
| `DotNetSeleniumExtras.WaitHelpers` | 3.11.0 |
| `Microsoft.NET.Test.Sdk` | 17.3.2 |
| `MySqlConnector` | 2.2.5 |
| `Newtonsoft.Json` | 13.0.3 |
| `NUnit` | 3.13.3 |
| `NUnit3TestAdapter` | 4.4.2 |
| `NUnit.Analyzers` | 3.6.1 |
| `Selenium.Support` | 4.8.1 |
| `Selenium.WebDriver` | 4.8.1 |
| `Selenium.WebDriver.ChromeDriver` | 111.0.5563.6400 |
| `Selenium.WebDriverBackedSelenium` | 4.1.0 |

---

## Configuration

Test configuration is loaded from two sources:

### 1. JSON data file
Located at `Setup/Data/dataSmokeTest.json`. The path is resolved by `Settings.cs` using the test name passed to each `[TestCase]`. This file contains browser type, user credentials, and other test parameters mapped to `AppointmentEntity`.

### 2. Consul KV Store
Database connection settings (host, database name, user, password) are fetched at runtime from the Consul service at:
```
http://consul.service.consul:8500
```
Key: `automation/selenium`

The response is deserialized into `DatabaseSettings` and used to build the `MySqlConnectionStringBuilder`.

---

## Environments

The test supports three target environments selected via the `environment` variable (read from the database):

| Value | Environment | URL |
|---|---|---|
| `1` | QA | `https://qa.referwell.com/login` |
| `2` | DEMO | `https://demo.referwell.com/login` |

User types per environment:

| Value | User Type |
|---|---|
| `1` | Provider (direct login) |
| `2` | Practice Administrator |
| `3` | Yoda admin (become provider) |

---

## Page Objects

Each `PageObject` class follows the **Page Object Model** pattern:
- Uses `SeleniumExtras.PageObjects.PageFactory` to initialize `[FindsBy]` element mappings.
- Receives `IWebDriver` and `Settings` via constructor injection from `BasePage`.
- Methods are environment-scoped (`QA`, `DEMO`, `PRD`) and call the stored procedure `Get_SmokeTestCase_Data` via `MySqlConnector` to retrieve data-driven test inputs.

---

## Running Tests

Tests are executed through the **NUnit** framework via Visual Studio Test Explorer or the .NET CLI:

```bash
dotnet test
```

The main test case is:

```csharp
[TestCase(60, 1000, "TestReferralSearchByInsurance",
    (Int16)EnumModule.LoginYodaProviderReferraltelevideoSearchbyMRNUploadFileHighPriorityNotesFiles)]
public async Task AppointmentCreate(Int16 order, Int16 wait, String Test, Int16 module)
```

This test covers the full smoke test flow:
1. Connect to Consul and build the DB connection string
2. Query test parameters from MySQL stored procedures
3. Initialize the Chrome browser and navigate to the target environment
4. Execute: Login → Provider selection → Dashboard → Referral/eConsult → Patient search/creation → Patient information → Appointment detail (notes, file upload) → Print page → Logout

---

## Languages & Technologies

- **Language:** C# (.NET 6.0)
- **Test Framework:** NUnit 3
- **Browser Automation:** Selenium WebDriver 4
- **Pattern:** Page Object Model (POM)
- **Database:** MySQL (via `MySqlConnector`)
- **Configuration:** Consul KV Store + JSON files
- **Serialization:** Newtonsoft.Json

---

## Documentation

- [Automation Smoke Test — Confluence](https://referwell.atlassian.net/wiki/spaces/QD/pages/4966776852/Automation+Smoke+Test)
- [Automation Test Plan V.1 — Confluence](https://referwell.atlassian.net/wiki/spaces/QD/pages/4966580250/Automation+Test+Plan+V.1)
