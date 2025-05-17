# 🧑‍🎓 Student Management System

A clean, modular, and scalable **Student Management System** built using **.NET 8** using **Entity Framework Core**, following the **Clean Architecture** pattern and applies key design principles like **CQRS, MediatR-based command/query separation**, and **SOLID principles**. It demonstrates how to structure enterprise-grade .NET applications using layers that promote separation of concerns, testability, and flexibility.

---

## 🧰 Tech Stack & Tools

### 🏗️ Architecture
- 🧼 **Clean Architecture**
- 📚 **CQRS (Command Query Responsibility Segregation)**
- 🧠 **MediatR** – In-process messaging
- 🧪 **FluentValidation** – Request validation

### 🔧 Backend
- ![.NET](https://img.shields.io/badge/.NET-8.0-purple?style=flat&logo=dotnet&logoColor=white) .NET 8
- ![C#](https://img.shields.io/badge/C%23-%23239120.svg?style=flat-square&logo=c-sharp&logoColor=white) **C#**
- ![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-512BD4?style=flat-square&logo=.net&logoColor=white) **ASP.NET Core Web API**
- ![Entity Framework](https://img.shields.io/badge/Entity_Framework_Core-6DB33F?style=flat-square&logo=dotnet&logoColor=white) **EF Core**
- 🗃️ **SQL Server** (or any EF-compatible DB)

### 🧩 Libraries & Tools
- ![AutoMapper](https://img.shields.io/badge/AutoMapper-D94A31?style=flat-square) **AutoMapper** – Object mapping
- ![MediatR](https://img.shields.io/badge/MediatR-5A29E4?style=flat-square) **MediatR** – Request handling
- ![FluentValidation](https://img.shields.io/badge/FluentValidation-0075C9?style=flat-square) **FluentValidation** – Validation library
- 🔗 **Dependency Injection** via built-in .NET DI container

---

## 🧱 Architecture Overview
```bash
┌──────────────────────────────────────────────────────┐
│      Presentation │ ← API Controllers (WebAPI)       |
└──────────────────────────────────────────────────────┘
                           │
                           ▼
┌──────────────────────────────────────────────────────┐
│  Application │ ← CQRS Handlers, MediatR, Interfaces  |
└──────────────────────────────────────────────────────┘
                           │
                           ▼
┌──────────────────────────────────────────────────────┐
│        Domain │ ← Entities, Interfaces, Enums        |
└──────────────────────────────────────────────────────┘
                           │
                           ▼
┌──────────────────────────────────────────────────────┐
│  Infrastructure │ ← EF Core, DbContext, Repositories |
└──────────────────────────────────────────────────────┘
```

---

## ✅ Features
- 🧹 Clean Architecture with separation of concerns
- 📥 CQRS pattern using MediatR for clear command/query separation
- 📦 Dependency Injection for scalable components
- 🎯 Request validation using FluentValidation
- 🔄 AutoMapper for object mapping
- 🧪 Unit-testable and scalable project structure

---

## 🚀 Getting Started

### 1️⃣ Clone the repository
```bash
git clone https://github.com/iroshanaRavishan/CleanArchitectureWithCQRSandMediatR.git
cd CleanArchitectureWithCQRSandMediatR
```

### 2️⃣ Setup the Database
Update your connection string in appsettings.json.
```bash
"ConnectionStrings": {
  "StudentDbConnection": "server=*PLACE YOUR SERVER NAME HERE*;database=StudentDatabase;Trusted_Connection=true; TrustServerCertificate=true"
}
```

### 3️⃣ Run Migrations

#### 🛠️ Running Migrations using Package Manager Console (Visual Studio)

1. Open **Visual Studio**  
2. Navigate to **Tools > NuGet Package Manager > Package Manager Console**

3. Set your **Infrastructure** project as the default project in the dropdown above the console.

4. Run the following commands to create and apply migrations:

```powershell
# Add a new migration
Add-Migration InitialCreate

# Apply migrations to the database
Update-Database

```


### 4️⃣ Build and Run


## Running the Application in Visual Studio

1. **Build the solution:**  
   - Go to the menu: `Build` > `Build Solution`  

2. **Run the application:**  
   - Press `F5` to run with debugging, or  

✨ Happy Coding! ✨

---


Created with ❤️
📧 bandarairoshana@gmail.com
💼 [LinkedIn - Iroshana Ravishan](https://www.linkedin.com/in/iroshana-ravishan-376706172/)  

