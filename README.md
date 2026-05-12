#  TechVault Inventory System

> A Windows Forms desktop application for managing tech product inventory, built with C# and MySQL.
> 
---

##  Project Description

**TechVault Inventory System** is a desktop-based inventory management application designed for tech product stores. It allows two types of users — **Admin** and **Customer** — to interact with a product database. Admins can add and manage products, while customers can browse and search available items.

The system is built using **C# Windows Forms (.NET)** for the front-end interface and **MySQL** as the back-end database, making it a lightweight yet functional solution for small-to-medium tech retail businesses.

---

##  UML Class Diagram

![UML Diagram][images/uml.png](https://github.com/tremonts/TechVault-Inventory/blob/4d0c63707efd81793931676ce65c4a81ff71dda7/uml_class_diagram.png)

![Alt text](https://github.com/tremonts/TechVault-Inventory/blob/812d42a4d2320ad077689162384a496da5cc54a7/uml.png)


---

##  Features and Functionalities

###  Admin

| Feature | Description |
|---|---|
| **Add Product** | Input product code, name, category, quantity, and unit price to add a new item to the database. Total price is automatically calculated. |
| **View All Products** | Displays all inventory items in a data grid upon login. |
| **Search Products** | Real-time search by product name, category, or product code. |

###  Customer

| Feature | Description |
|---|---|
| **Browse Products** | View all available products in the inventory. |
| **Search Products** | Search items by name, category, or product code in real time. |

---

##  How the Program Works

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


##OOP Principles

1. Encapsulation
Encapsulation is implemented through the Product class, which bundles all product-related data into a single, organized unit. All attributes such as ProductCode, ProductName, Category, Quantity, UnitPrice, TotalPrice, and DateAdded are defined as properties with controlled access. External classes cannot directly manipulate the data — they interact with it only through the class structure, protecting the integrity of inventory records.

2. Inheritance
Inheritance is demonstrated through the form classes of the system. LoginForm, AdminDashboard, and CustomerDashboard all inherit from the Form base class provided by the Windows Forms framework. This allows each form to reuse built-in GUI behavior such as rendering, event handling, and window management without rewriting those features from scratch. Each child class extends the base Form class with its own specific controls and logic, demonstrating a clear parent-child class hierarchy.

3. Polymorphism
Polymorphism is applied through the search functionality. Both AdminDashboard and CustomerDashboard implement a search method, but each behaves differently based on the user's role. The Admin version searches across all inventory fields with full data access, while the Customer version operates in a read-only context. The same operation — searching products — produces different behavior depending on which class executes it.

4. Abstraction
Abstraction is achieved through the DBConnection class, which hides the complexity of establishing a MySQL database connection. Other classes in the system such as AdminDashboard and CustomerDashboard do not need to know how the connection is built internally. They simply call GetConnection() and receive a ready-to-use connection object, simplifying database interaction across the entire system.
---

##  How to Run the Application

###  Prerequisites

- Visual Studio 2026
- MySQL Server
- MySqlConnector NuGet Package

---

###  Database Setup

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

###  Running the Application

1. Clone or download the repository.
2. Open `TechVault Inventory.slnx` in Visual Studio.
3. Restore NuGet packages.
4. Make sure MySQL Server is running.
5. Configure the database connection inside `DBConnection.cs`.
6. Press `F5` or click `Start`.



---

##  Developers

| Name | Role |
|---|---|
| **Zyra Ballesteros** | Developer |
| **Tremonti Canatuan** | Developer |
| **Renz Mariz Carilo** | Developer |

---

##  Built With

- C#
- Windows Forms
- .NET
- MySQL
- Visual Studio 2026

---

<p align="center">
Built with ❤️ using C# and MySQL
</p>
