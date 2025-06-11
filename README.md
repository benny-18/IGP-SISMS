# IGP SISMS (Stalls Inventory & Sales Management System)

**📌 Project Overview**

This system helps manage products, stalls, and sales at the IGP Trade Park inside Leyte Normal University. It includes these features:

- User login (admin or stall owner)
- Stall profile management (create, edit, delete, change photo/password)
- Product management (add, view, edit, delete products)
- Daily inventory & sales summary, with optional monthly/yearly estimates
- Export summaries and take screenshots
- User logout after secure session

---

## 🗂️ Folder Structure

```
/
├─ AdminAccount.vb, Home.vb, InSummary.vb, Login.vb, productslist.vb, SalesT.vb
├─ assets/           – Screenshots & UI assets (.png files)
├─ images/           – Banner and header images
├─ bin/              – Compiled output (Debug & Release)
├─ My Project/       – Visual Studio project files
├─ Resources/        – Icons and images used by app
├─ packages/         – NuGet dependencies
└─ README            – This file

```

---

## ⚙️ Requirements

- **OS:** Windows 7 or later
- **.NET Framework:** Compatible with VB.NET WinForms
- **Database:** MySQL server with `products` database
- **Data Libraries:** Included `MySql.Data`, `iTextSharp`, `Guna.UI2`, etc.

---

## 🛠️ Setup Instructions

1. **Clone the repo:**
    
    ```bash
    git clone https://github.com/benny-18/IGP-SISMS.git
    
    ```
    
2. **Install MySQL and create the `products` database** with tables:
    - `stall_profile` (stall info + login/password)
    - `products` (product_key, name, price, quantity, expiry_date, image, stall)
    - `inventory` (inventory_date, product_quantity, etc.)
3. **Open solution in Visual Studio**
    
    Load `System_OOP-Guna.sln`.
    
4. **Restore NuGet packages** (via Solution Explorer ➝ Manage NuGet Packages).
5. **Update database connection** in `App.config` if needed:
    
    ```xml
    <connectionStrings>
      <add name="ProductsDB" connectionString="server=localhost;userid=root;password=1234;database=products" providerName="MySql.Data.MySqlClient" />
    </connectionStrings>
    
    ```
    
6. **Build & run** the project.

---

## 🧩 Usage Flow

1. **Login** as admin (default: stall_username `admin` in `stall_profile` table) or as stall owner.
2. **Admin panel**: Add/edit/delete stall accounts. Manage passwords.
3. **Stall owner panel**:
    - Edit profile/photo
    - Manage products (via Products List)
    - Add, edit, delete products
    - View income summary and estimates
4. **Logout** to end session securely.

---

## ✅ Known Issues & Future Improvements

- Passwords are stored in **plain text** — future versions should use **hashing**.
- Input validation (e.g., numeric values) can be improved to prevent app crashes.
- Image handling should include better validation (missing or invalid paths).
- **Export to PDF** or formatted reports can be added (there’s already screenshot support).

---

## 🎓 Team & Credits

**Members:**

- Marvin Masubay
- Joyce Pabo
- Paula Bianca Oledan
- Paul Jorenz Pablo
- Jason Brylle Cabria

**Technology Stack:**

- VB.NET WinForms with Guna2 UI
- MySQL for database
- NuGet packages: MySql.Data, iTextSharp (PDF), Guna.UI2, etc.

---
