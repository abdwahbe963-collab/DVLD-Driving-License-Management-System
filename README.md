[README.md](https://github.com/user-attachments/files/30755069/README.md)
# DVLD - Driving & Vehicle License Department

## Overview

DVLD is a desktop application built with C# and Windows Forms that simulates the core operations of a Driving & Vehicle License Department. The system manages the lifecycle of driver-related services, including people management, driving license applications, license testing, license issuance, renewal, replacement, and detention/release operations.

The application models a multi-step workflow in which a person applies for a driving license, completes the required vision, written, and street tests, and becomes eligible for license issuance. It also supports international licenses, license history, test appointments, and user management.

The project follows a **3-Tier Architecture** and uses **SQL Server** with **ADO.NET** for database access. It was developed as a practical project to apply object-oriented programming, layered architecture, relational database design, and business-rule implementation in a C#/.NET Framework application.

---

## Some Images of the project interface

* LoginScreen
  
<img width="913" height="487" alt="Image" src="https://github.com/user-attachments/assets/779e3305-24b4-4ef2-9a9a-e6288512d338" />


* MainScreen
  
<img width="1580" height="805" alt="Image" src="https://github.com/user-attachments/assets/7064a6e7-eb6a-4162-bd54-956f0af394c4" />


* Add New Person
  
<img width="1576" height="795" alt="Image" src="https://github.com/user-attachments/assets/e6d09aa4-ed11-412e-b0e0-86ac08b23e7b" />


* Local Driving License Management

<img width="1573" height="937" alt="Image" src="https://github.com/user-attachments/assets/64baae74-334e-4453-bf10-766b2651a383" />


* Take Test

<img width="1397" height="907" alt="Image" src="https://github.com/user-attachments/assets/87c538d7-28e8-4a26-98dc-cf8eb60f6c87" />


* International Driving Licence

<img width="1582" height="802" alt="Image" src="https://github.com/user-attachments/assets/3196c7ab-d56b-4f7b-8699-fdb816319776" />

---------
## Database Diagram 
* Database ScreenShot

<img width="1313" height="786" alt="Image" src="https://github.com/user-attachments/assets/ac105801-07ff-4a47-bb11-cfdaf1b7e7f5" />

## Features

### People & Drivers

* Add, update, and search for people.
* Store personal information such as national number, name, date of birth, gender, address, contact information, nationality, and photo.
* Manage driver records linked to people.

### Applications

* Manage driving license applications.
* Manage different application types.
* Track application status and related information.

### Driving License Testing

* Schedule and manage vision tests.
* Schedule and manage written tests.
* Schedule and manage street tests.
* Track test results and attempts.
* Support paid test appointments and retake scenarios.
* Lock appointments according to the application's workflow rules.

### Local Driving Licenses

* Issue a first-time local driving license.
* Support different license classes.
* Renew existing driving licenses.
* Replace lost or damaged licenses.
* View license history.

### International Driving Licenses

* Issue international driving licenses linked to existing local licenses.
* View international license records.

### Detained Licenses

* Detain driving licenses.
* Record detention fees.
* View detained licenses.
* Release previously detained licenses.

### User Management

* User login.
* Remember-me functionality.
* Active/inactive user accounts.
* Create and manage system users.
* Link users to person records.
* Change user passwords.

### Reference Data

* Manage test types.
* Manage driving license classes.
* Use country/nationality reference data for person records.

---

## Technologies

* **Language:** C#
* **UI:** Windows Forms
* **Framework:** .NET Framework 4.7.2
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET (`System.Data.SqlClient`)
* **SQL:** Hand-written parameterized SQL queries
* **UI Components:** Guna.UI2
* **IDE:** Visual Studio

The project does not use an ORM such as Entity Framework. Database operations are implemented directly in the Data Access Layer using ADO.NET.

---

## Architecture

The solution follows a **3-Tier Architecture** consisting of three main layers:

### 1. Presentation Layer

**`DVLD_Full_Proj_Ui_Layer`**

This layer contains the Windows Forms user interface, including forms and user controls for the different system modules.

It is responsible for:

* Displaying the user interface.
* Receiving user input.
* Calling the Business Layer.
* Displaying results and validation messages.

The Presentation Layer does not access the database directly.

### 2. Business Logic Layer

**`DVLD_Business_Layer`**

This layer contains the application's business entities and business logic.

It is responsible for:

* Applying business rules.
* Validating data.
* Managing application workflows.
* Communicating with the Data Access Layer.
* Providing the Presentation Layer with the required operations.

The Business Layer uses an Add/Update mode pattern through the `_EnMode` enum and a shared `Save()` method across many entities.

### 3. Data Access Layer

**`DVLD_Data_Access_Layer`**

This layer is responsible for communication with SQL Server.

It contains Data Access classes for the application's entities and performs database operations using:

* `SqlConnection`
* `SqlCommand`
* `SqlParameter`
* `SqlDataReader`
* `ExecuteScalar()`
* `ExecuteNonQuery()`

The layers communicate in the following direction:

**Presentation Layer → Business Layer → Data Access Layer → SQL Server**

---

## Database

The application uses a Microsoft SQL Server database named **`DVLD_DB`**.

The database contains entities such as:

* `People`
* `Users`
* `Drivers`
* `Applications`
* `ApplicationTypes`
* `LocalDrivingLicenseApplications`
* `Licenses`
* `LicenseClasses`
* `InternationalLicenses`
* `DetainedLicenses`
* `TestTypes`
* `TestAppointments`
* `Tests`

Database operations are implemented using parameterized SQL queries in the Data Access Layer.

Identity values generated by SQL Server are retrieved using `SCOPE_IDENTITY()` where required.

---

## Project Highlights

* **3-Tier Architecture** with separate Presentation, Business Logic, and Data Access projects.
* **ADO.NET-based data access** using `SqlConnection`, `SqlCommand`, and parameterized queries.
* **Business-rule implementation** for license applications, testing, issuance, renewal, replacement, and detention workflows.
* **Consistent Add/Update pattern** across many Business Layer entities using an `_EnMode` enum and a shared `Save()` method.
* **Multi-step driving license workflow** covering vision, written, and street tests before license issuance.
* **Relational database design** with multiple linked entities representing people, drivers, applications, tests, and licenses.
* **Reusable Business and Data Access classes** organized by application entity.
* **Windows Forms interface** with Guna.UI2 components for the user interface.

---

## How to Run

### Requirements

* Windows
* Visual Studio 2022 or compatible version
* .NET Framework 4.7.2 Developer Pack / Targeting Pack
* Microsoft SQL Server
* Guna.UI2 library

### 1. Clone the Repository

Clone the repository and open the solution file:

`DVLD_Full_Proj.sln`

### 2. Restore the Database

Restore the provided **`DVLD_DB.bak`** database backup in SQL Server.

### 3. Configure the Database Connection

Update the database connection configuration to match the SQL Server instance on your machine.

Do not commit real database credentials or passwords to the repository.

### 4. Guna.UI2 Reference

The project uses the Guna.UI2 WinForms UI library.

If the reference does not resolve automatically after cloning the repository, update the reference to point to the appropriate `Guna.UI2.dll` location on your machine.

### 5. Run the Application

Set:

`DVLD_Full_Proj_Ui_Layer`

as the startup project and run the solution.

The application starts with the login screen before opening the main application window.

---

## Notes

This project was developed as a practical C# desktop application to demonstrate layered architecture, database programming, business logic, and implementation of a realistic multi-step workflow.

The project is intended primarily as a **portfolio and learning project** and is not presented as a production-ready government system.
