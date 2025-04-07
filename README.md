# SimplyBooks API

Welcome to the **SimplyBooks API** — a RESTful web service for managing authors and their books, built with **ASP.NET Core** and **Entity Framework Core**. This API supports full CRUD operations and is designed to serve as the backend for book-focused applications.

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [PostgreSQL](https://www.postgresql.org/)
- [PgAdmin](https://www.pgadmin.org/) (optional, for GUI access)
- [Postman](https://www.postman.com/) (for API testing)

---

### 1. Clone the Repository

```bash
git clone https://github.com/sirenabailie/SimplyBooks
cd SimplyBooks
```

---

### 2. Configure Your Connection String

Create a file called `appsettings.Development.json` in the root of the project (next to `Program.cs`) and add your PostgreSQL connection string:

```json
{
  "SimplyBooksBEDbConnectionString": "Host=localhost;Port=5432;Database=SimplyBooksBE;Username=postgres;Password=yourpassword"
}
```

>  This file is included in `.gitignore` to prevent secrets from being committed.

---

### 3. Apply Migrations and Seed the Database

```bash
dotnet ef database update
```

This will:
- Create the database (if it doesn't exist)
- Apply schema migrations
- Seed initial data (authors and books)

---

### 4. Run the Application

```bash
dotnet run
```

Once running, the API will be available at:

- `https://localhost:7129`

You can test the API using:

- **Swagger UI**: `https://localhost:7129/swagger`
- **Postman**: Import the collection below

---

## Postman Collection

Interact with the API using the documented Postman collection:

[SimplyBooks Postman Documentation](https://documenter.getpostman.com/view/36778695/2sB2cVdLv5)

---

## Authentication

This API is designed to integrate with **Firebase Authentication**. While authentication is not enforced in this version, the `uid` field on authors and books can be used to associate records with specific users.

In a production environment, Firebase token validation middleware would secure routes based on the authenticated user.

---

## API Endpoints

| Method | Endpoint                    | Description                            |
|--------|-----------------------------|----------------------------------------|
| GET    | `/api/books`                | Retrieve all books                     |
| GET    | `/api/books/{id}`           | Retrieve a specific book by ID         |
| POST   | `/api/books`                | Create a new book                      |
| PUT    | `/api/books/{id}`           | Update a book by ID                    |
| DELETE | `/api/books/{id}`           | Delete a book by ID                    |
| GET    | `/api/authors`              | Retrieve all authors                   |
| GET    | `/api/authors/{id}`         | Retrieve a specific author by ID       |
| POST   | `/api/authors`              | Create a new author                    |
| PUT    | `/api/authors/{id}`         | Update an author by ID                 |
| DELETE | `/api/authors/{id}`         | Delete an author by ID                 |

---

## Features

- Full CRUD for **Books** and **Authors**
- One-to-many relationship (an author can have many books)
- Optional Firebase Authentication integration
- API documentation via Swagger and Postman

---

## Tech Stack

- C#
- ASP.NET Core 8 (Minimal APIs)
- Entity Framework Core 8
- PostgreSQL
- Swagger / Swashbuckle
- LINQ & async/await
- Clean RESTful architecture

---

## Author

**Sirena Foster**  
💻 [GitHub: sirenabailie](https://github.com/sirenabailie)  

---

## 📹 API Demo

> TBA
