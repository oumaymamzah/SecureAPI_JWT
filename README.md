# 🛡️ SecureAPI_JWT – Sécurisation d'une API .NET avec JSON Web Tokens (JWT)

## 📌 Introduction

SecureAPI_JWT est un projet ASP.NET Core Web API conçu pour démontrer la mise en place d’un système d’authentification sécurisé basé sur **JWT (JSON Web Token)**.
Il implémente la gestion des utilisateurs, l’attribution des rôles, ainsi que la protection des endpoints grâce aux mécanismes d’autorisation d’ASP.NET Core Identity.

Ce projet est basé sur un atelier pratique visant à comprendre et appliquer les bonnes pratiques de sécurité dans une API moderne.

---

## 🚀 Fonctionnalités principales

* 🔐 **Authentification avec JWT**
* 👤 **Gestion des utilisateurs avec ASP.NET Core Identity**
* 📝 **Inscription (Register) & Connexion (Login)**
* 🎫 **Génération de token JWT sécurisé**
* 🔏 **Protection des endpoints avec [Authorize]**
* 🛂 **Gestion des rôles (User / Admin)**
* 🧪 **Tests via Swagger avec bouton "Authorize"**
* 🗄️ **Connexion à SQL Server avec Entity Framework Core**
* 🧩 **Architecture claire : Models, Services, Controllers**

---

## 🧱 Technologies utilisées

* **ASP.NET Core 8 / Web API**
* **Entity Framework Core**
* **Identity Framework**
* **SQL Server**
* **JWT – System.IdentityModel.Tokens.Jwt**
* **Swagger / OpenAPI**
* **Visual Studio 2022**

---

## 📁 Structure du projet

```
SecureAPI_JWT/
│── Controllers/
│     └── AuthController.cs
│── Models/
│     ├── ApplicationUser.cs
│     ├── AuthModels.cs
│     ├── RoleModels.cs
│── Services/
│     ├── IAuthService.cs
│     └── AuthService.cs
│── Helpers/
│     └── JWT.cs
│── appsettings.json
│── Program.cs
│── SecureAPI_JWT.csproj
```


