# 🎓 Student Attendance Management System - REST API

A powerful and secure RESTful API built باستخدام ASP.NET Core لإدارة حضور الطلاب بشكل احترافي.

---

## 📌 Description
This project is a backend system designed to manage student attendance efficiently.  
It provides secure APIs for handling students, attendance tracking, authentication, and reporting.

The system is built as a graduation project to demonstrate strong backend development, clean architecture, and security best practices.

---

## 🚀 Features

- 👨‍🎓 Student Management (Add / Update / Delete / View)
- 📅 Attendance Tracking System
- 🔐 Authentication & Authorization using JWT
- 📊 Reports and Data Handling
- ⚡ Clean and Scalable Architecture
- 🛡️ Secure API (Protection against common vulnerabilities)

---

## 🛠️ Technologies Used

- ASP.NET Core Web API
- Entity Framework Core
- SQL Server
- JWT Authentication
- LINQ

---

## 📸 System Preview

<p align="center">
  <img src="https://github.com/user-attachments/assets/d6c2d87c-ac06-4168-83fe-70a594ec35cf" width="700"/>
</p>

> Example of API testing using Postman.

---

## 🔑 API Endpoints (Examples)

### 🔐 Authentication
- `POST /api/account/login`
- `POST /api/account/register`

### 👨‍🎓 Students
- `GET /api/students`
- `POST /api/students`
- `PUT /api/students/{id}`
- `DELETE /api/students/{id}`

### 📅 Attendance
- `GET /api/attendance`
- `POST /api/attendance`
- `GET /api/attendance/{studentId}`

---

## ⚙️ Setup & Installation

1. Clone the repository:
```bash
git clone https://github.com/Mostafa-Mahmoud13/Graduation-Project-Student-Attendance-Management-System-RESTAPI.git
