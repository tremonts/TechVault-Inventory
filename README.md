# 🗄️ TechVault Inventory System

> A Windows Forms desktop application for managing tech product inventory, built with C# and MySQL.
> 
---

## 📌 Project Description

**TechVault Inventory System** is a desktop-based inventory management application designed for tech product stores. It allows two types of users — **Admin** and **Customer** — to interact with a product database. Admins can add and manage products, while customers can browse and search available items.

The system is built using **C# Windows Forms (.NET)** for the front-end interface and **MySQL** as the back-end database, making it a lightweight yet functional solution for small-to-medium tech retail businesses.

---

## 📐 UML Class Diagram

![UML Diagram]([images/uml.png](https://github.com/tremonts/TechVault-Inventory/blob/4d0c63707efd81793931676ce65c4a81ff71dda7/uml_class_diagram.png))

---

## ⚙️ Features and Functionalities

### 👤 Admin

| Feature | Description |
|---|---|
| **Add Product** | Input product code, name, category, quantity, and unit price to add a new item to the database. Total price is automatically calculated. |
| **View All Products** | Displays all inventory items in a data grid upon login. |
| **Search Products** | Real-time search by product name, category, or product code. |
| **Clear Fields** | Resets all input fields after adding a product. |

### 🧑‍💼 Customer

| Feature | Description |
|---|---|
| **Browse Products** | View all available products in the inventory. |
| **Search Products** | Search items by name, category, or product code in real time. |

---

## 🔄 How the Program Works

1. **Application Start** — `Program.cs` launches the `LoginForm` as the entry point.

2. **Login**
   - The user selects their role from the dropdown.
   - Choosing **Admin** opens the `AdminDashboard`.
   - Choosing **Customer** opens the `CustomerDashboard`.

3. **Admin Dashboard**
   - Displays all products from the database.
   - Allows adding new products.
   - Supports real-time searching.

4. **Customer Dashboard**
   - Displays product inventory in read-only mode.
   - Supports real-time product searching.

5. **Database Connection**
   - `DBConnection.cs` manages the connection to MySQL.
   - Uses `MySqlConnector` package.

6. **Product Model**
   - `Product.cs` defines the product structure and properties.

---

## 🚀 How to Run the Application

### 📌 Prerequisites

- Visual Studio 2022 or later
- .NET 6.0 SDK or later
- MySQL Server
- MySqlConnector NuGet Package

---

### 🗃️ Database Setup

Run the following SQL script:

```sql
CREATE DATABASE techvaultdb;

USE techvaultdb;

CREATE TABLE products (
    id INT AUTO_INCREMENT PRIMARY KEY,
    product_code VARCHAR(50),
    product_name VARCHAR(100),
    category VARCHAR(50),
    quantity INT,
    unit_price DECIMAL(10,2),
    total_price DECIMAL(10,2),
    date_added DATETIME
);
```

---

### ▶️ Running the Application

1. Clone or download the repository.
2. Open `TechVault Inventory.slnx` in Visual Studio.
3. Restore NuGet packages.
4. Make sure MySQL Server is running.
5. Configure the database connection inside `DBConnection.cs`.
6. Press `F5` or click `Start`.

---

## 🖼️ System Preview

### 🔐 Login Form

![Login Form](images/loginform.png)

---

### 📦 Admin Dashboard

![Admin Dashboard](images/admindashboard.png)

---

### 🛒 Customer Dashboard

![Customer Dashboard](images/customerdashboard.png)

---

## 👨‍💻 Developers

| Name | Role |
|---|---|
| **Zyra** | Developer |
| **Tremonti** | Developer |
| **Renz** | Developer |

---

## 🛠️ Built With

- C#
- Windows Forms
- .NET
- MySQL
- Visual Studio 2022

---

<p align="center">
Built with ❤️ using C# and MySQL
</p>
