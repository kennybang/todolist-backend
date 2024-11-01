# TodoList Backend

This is the backend for a TodoList application, built using ASP.NET Core and SQL Server. This backend provides a RESTful API for managing a simple todo list application. You can create, read, update, and delete todo items.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (or SQL Server Express)
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

## Installation

1. Clone the repository
2. Restore the project dependencies in project root directory: `dotnet restore`
3. Open `appsettings.json` and update the `TodoConnection` string to match your SQL Server configuration:
```bash
  "ConnectionStrings": {
    "TodoConnection": "Server=your_server;Database=TodoListDb;Trusted_Connection=True;"
    }
```
4. Run the application: `dotnet run`

## API Endpoints
- GET `/api/todoitems` - Get all todo items
- GET `/api/todoitems/{id}` - Get a todo item by ID
- POST `/api/todoitems` - Create a new todo item
- PUT `/api/todoitems/{id}` - Update an existing todo item
- DELETE `/api/todoitems/{id}` - Delete a todo item

