# 🗳️ Online Voting System

This repository contains a complete **Database Systems semester project** developed using **C# Windows Forms** and **SQL Server**.

The project simulates a secure and efficient digital voting platform where voters can cast votes electronically while administrators manage elections, candidates, constituencies, and results.

The system focuses heavily on **database integrity**, **secure data handling**, and **efficient relational database design**.

---

# 🛠️ Tech Stack

* **Frontend / Desktop Application:** C# Windows Forms (.NET)
* **Database:** Microsoft SQL Server
* **Language:** SQL + C#

---

# 📊 Database Concepts Implemented

This project implements core and advanced database concepts including:

* **Relational Database Design**

  * Proper normalization techniques
  * Entity relationships and foreign key constraints

* **Primary & Foreign Keys**

  * Ensures referential integrity between tables

* **Check Constraints**

  * Used for controlled and validated data entry

* **Joins & Complex Queries**

  * Used for election reports, candidate details, and vote counting

* **Data Integrity**

  * Prevents duplicate voting
  * Maintains constituency-based candidate filtering

* **CRUD Operations**

  * Complete insert, update, delete, and search functionalities

* **Authentication System**

  * Separate admin and voter login handling

---

# ✨ Features

## 👤 Voter Panel

* Secure Login
* View Ongoing Elections
* Constituency-based Candidate Filtering
* Cast Vote
* Prevent Duplicate Voting

## 🛠️ Admin Panel

* Manage Voters
* Manage Candidates
* Manage Political Parties
* Manage Elections
* View Election Results
* Dashboard Statistics

---

# 🗂️ Repository Contents

* `WindowsFromsApplication1/`

  * Contains all C# Windows Forms source code

* `Database/`

  * Contains SQL scripts including:

    * DDL
    * DML
    * Constraints
    * Queries

* `Documentation/`

  * Final project report
  * ERD / EERD diagrams
  * Project screenshots

---

# 🚀 How to Run Locally

## 1️⃣ Setup Database

* Open Microsoft SQL Server
* Create a database named:

```sql
CREATE DATABASE MyDB
```

* Run all provided SQL scripts in sequence.

---

## 2️⃣ Open Project

* Open the `.sln` file in Visual Studio 2015

---

## 3️⃣ Configure Database Connection

Update SQL Server connection string if needed:

```csharp
SqlConnection con = new SqlConnection(
@"Server=.\SQLEXPRESS;Database=MyDB;Integrated Security=True;");
```

---

## 4️⃣ Run the Application

* Press `Start` in Visual Studio
* Login as Admin or Voter
* Test election and voting functionalities

---

# 📌 Important Notes

* SQL Server must be running locally
* This project uses Windows Authentication
* Some forms depend on pre-inserted SQL data

---

# 👩‍💻 Developer

**Abeeha Farooq**
**Fiza Afzal**

Database Systems Semester Project — 2026
