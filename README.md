TechVault Management System
Overview

TechVault Management is a C# Windows Forms Inventory Management System connected to a MySQL database using:

C#
Windows Forms
MySQL
XAMPP
MySqlConnector

The system has:

Admin Dashboard
Customer Dashboard
Product Inventory
Search Function
MySQL Database Integration

Features
Admin Dashboard
Add products
View products
Search products
Inventory management
Customer Dashboard
View products
Search products


Requirements

Install these before running the project:

Software Needed


Software	  Purpose
Visual Studio	  C# Development
XAMPP	          MySQL Database
.NET Framework	  Windows Forms
MySqlConnector	  MySQL Connection


Installing XAMPP
Step 1 — Download XAMPP

Download from:

XAMPP Official Website

Install XAMPP normally.

Step 2 — Start MySQL

Open XAMPP Control Panel.

Start:

Apache
MySQL

MySQL must be running before opening the project.

Creating the Database
Step 1 — Open phpMyAdmin

Open:

phpMyAdmin

Step 2 — Create Database

Click:

New

Database name:

techvaultdb

Click:

Create

Step 3 — Create Products Table

Click the database:

techvaultdb

Open SQL tab and run:

CREATE TABLE products (
    id INT PRIMARY KEY AUTO_INCREMENT,
    product_code VARCHAR(50),
    product_name VARCHAR(100),
    category VARCHAR(100),
    quantity INT,
    unit_price DECIMAL(10,2),
    total_price DECIMAL(10,2),
    date_added DATE
);


Installing MySqlConnector Package
Step 1 — Open Visual Studio

Open the project.

Step 2 — Open Package Manager Console

Go to:

Tools
→ NuGet Package Manager
→ Package Manager Console
Step 3 — Install Package

Run:

Install-Package MySqlConnector

Wait until installation finishes.


Database Connection
DBConnection.cs
string conn =
"server=localhost;user=root;password=;database=techvaultdb;";


Project Structure
TechVaultManagement
│
├── Program.cs
├── DBConnection.cs
├── Product.cs
│
├── LoginForm.cs
├── LoginForm.Designer.cs
│
├── AdminDashboard.cs
├── AdminDashboard.Designer.cs
│
├── CustomerDashboard.cs
└── CustomerDashboard.Designer.cs


Running the Project
Step 1

Start XAMPP MySQL.

Step 2

Open Visual Studio.

Step 3

Build the project:

Ctrl + Shift + B

Step 4

Run the project:

F5

Login Instructions

Select user type:

Admin
Customer

Click:

LOGIN

Search Function

The search bar can search by:

Product Name
Category
Product Code

Search updates automatically while typing.

Common Errors Fix
Error: dataGridView1 does not exist

Add this inside .Designer.cs:

private System.Windows.Forms.DataGridView dataGridView1;
Error: InitializeComponent() does not exist

Right click form:

View Designer

Save and rebuild solution.

Error: MySQL connection failed

Check:

XAMPP MySQL is running
Database name is correct
MySqlConnector package installed
Future Improvements

Possible upgrades:

Update products
Delete products
User authentication
Reports
Charts
Inventory analytics
Dark mode
Export to Excel/PDF
Role management
Developer Notes

This project is intended for:

School projects
Inventory management practice
C# Windows Forms learning
MySQL database integration learning
Technologies Used
C#
Windows Forms
MySQL
XAMPP
MySqlConnector
.NET Framework
