# 🎓 Student Attendance Management System - REST API

![.NET](https://img.shields.io/badge/.NET-ASP.NET%20Core-blue)
![SQL Server](https://img.shields.io/badge/Database-SQL%20Server-red)
![JWT](https://img.shields.io/badge/Auth-JWT-green)
![Status](https://img.shields.io/badge/Project-Completed-brightgreen)

A secure and scalable Student Attendance Management System built as a RESTful API using ASP.NET Core.

---

## 📌 Description

This project is a backend system designed to manage student attendance efficiently.  
It provides secure APIs for handling students, professors, attendance tracking, authentication, and reporting.

Built as a graduation project to demonstrate strong backend development skills, clean architecture, and security best practices.

---

## 🚀 Features

- 👨‍🎓 Student Management (CRUD Operations)
- 👨‍🏫 Professor Management
- 📅 Attendance Tracking System
- 📊 Dashboard for Students & Professors
- 🔐 Authentication & Authorization using JWT
- 📱 QR Code Attendance System
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

## 🏗️ Architecture

The project follows a clean and modular architecture:

- Controllers → Handle HTTP Requests  
- Services → Business Logic  
- Data Layer → Entity Framework Core  
- Models → Database Entities  
- DTOs → Data Transfer Objects  

---

## 📸 API Endpoints Preview

### 🔐 Account Endpoints
<p align="center">
  <img src="https://github.com/user-attachments/assets/d66ce548-5b4a-4b68-a80b-abc55ca29873" width="700"/>
</p>
> Handles authentication and password management.

---

### 📊 Dashboard Endpoints
<p align="center">
  <img src="https://github.com/user-attachments/assets/5a81c27d-3eb9-47f6-9bf6-6fbf5269bd56" width="700"/>
</p>
> Provides overview data for students and professors.

---

### 👨‍🏫 Professor Endpoints
<p align="center">
  <img src="https://github.com/user-attachments/assets/01641683-ec17-4e77-b576-aa86aa4493ee" width="700"/>
</p>
> Manage students, mark attendance, and generate QR codes.

---

### 👨‍🎓 Student Endpoints
<p align="center">
  <img src="https://github.com/user-attachments/assets/702aacc3-75f1-4b9b-badf-24669546db69" width="700"/>
</p>
> Access student data and attendance percentage.

---

### 👤 Profile Endpoints
<p align="center">
  <img src="https://github.com/user-attachments/assets/6cfa6ac2-0cbd-4ca7-a0dd-62366d1842f3" width="700"/>
</p>
> Manage profile information for students and professors.

---

## 🔑 API Endpoints (Examples)

| Method | Endpoint | Description |
|--------|--------|-------------|
| POST | /api/account/login-student | Student Login |
| POST | /api/account/login-professor | Professor Login |
| GET | /api/student/list-all-student | Get all students |
| GET | /api/professor/my-students | Get professor students |
| POST | /api/professor/mark-attendance | Mark attendance |
| GET | /api/student/attendance-percentage | Get attendance percentage |

---

## 🔒 Security Features

- JWT Authentication
- Role-Based Authorization
- Secure Password Handling
- Input Validation
- Protection against SQL Injection

---

## ⚙️ Setup & Installation

1. Clone the repository:
```bash
git clone https://github.com/your-username/Graduation-Project-Student-Attendance-Management-System-RESTAPI.git
