# ASP.NET Core Web API – Todo CRUD App

This is a basic ASP.NET Core Web API project built from scratch, featuring a controller-service-model architecture to manage Todo items.

## 🛠 Features

- RESTful API for managing todos
- In-memory data store (no database yet)
- Layered architecture with:
  - `Todo` model
  - `TodoService` for business logic
  - `TodosController` for API endpoints

## 🔧 Tech Stack

- ASP.NET Core 8
- C#
- .NET SDK 8
- Minimal API setup with classic controller support

## 🚀 Getting Started

### 1. Clone the repo

```bash
git clone https://github.com/chamodisam/todo-backend.git
cd backend
```

### 2. Run the app
```bash
dotnet run
```

#### 🔐 HTTPS Support
To run locally with HTTPS:

```bash
dotnet dev-certs https --trust
dotnet run
```
Make sure https profile is on top of the profiles in Properties/launchSettings.json
If not, use
```bash
dotnet run --launch-profile https
```


## 3. API Endpoints

You can test these endpoints using Postman, curl, or connect them to a frontend client.

| Method | Endpoint           | Description      |
|--------|--------------------|------------------|
| GET    | `/api/todos`       | Get all todos    |
| GET    | `/api/todos/{id}`  | Get todo by ID   |
| POST   | `/api/todos`       | Add a new todo   |
| PUT    | `/api/todos/{id}`  | Update a todo    |
| DELETE | `/api/todos/{id}`  | Delete a todo    |
