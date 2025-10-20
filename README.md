# 📦 AnytimeFitness Database Deployment Guide (XAMPP)

This guide provides instructions for deploying the **AnytimeFitness** database in a local development environment using **XAMPP**.

---

## 📁 Requirements

Before proceeding, ensure you have the following installed:

- [XAMPP](https://www.apachefriends.org/index.html) (latest version recommended)

---

## ⚙️ Step-by-Step Setup

### 1. 🛠 Start XAMPP Services

- Open the **XAMPP Control Panel**
- Start the following services:
  - **Apache**
  - **MySQL**

### 2. 🗃 Access phpMyAdmin

- Open your browser and go to:  
  `http://localhost/phpmyadmin`



3. 📥 Import SQL File 



1. Click on the newly created database (`anytimefitness`).
2. Go to the **Import** tab.
3. Click **Choose File** and select your `.sql` file.
4. Click **Go** to execute the import.

> 💡 Ensure the SQL file includes table creation and necessary inserts.

### 4. 👤 Admin Credentials

The default admin user for the system is:

- **Username:** `James`  
- **Password:** `James@123`

Make sure to update these credentials in your application config or environment files.

---

## 📌 Notes

- For production environments, **change the default admin password**.
- Ensure XAMPP's MySQL port (default: 3306) is not being blocked.
- If accessing from another device on the network, configure XAMPP to allow remote MySQL access securely.

---

## 🧰 Troubleshooting

- **MySQL not starting?**
  - Ensure port 3306 isn't already in use (e.g., by another MySQL installation).
- **phpMyAdmin errors?**
  - Check `config.inc.php` file under `xampp/phpMyAdmin` for proper configuration.

---

## 📞 Support

For help, contact the system administrator or the development team.

