
# JwtAuthDemo (.NET 8)

A minimal .NET 8 Web API project demonstrating **JWT-based authentication and authorization** using ASP.NET Core’s built-in authentication middleware. This project includes Swagger integration with JWT support.

## 🔐 Features

- User login endpoint that returns a JWT token
- JWT validation using built-in middleware (`AddAuthentication` & `AddJwtBearer`)
- Token-based access to protected endpoints
- Swagger UI with JWT input
- No database — users are hardcoded for demo

## 🛠 Technologies Used

- .NET 8 Web API
- C#
- JWT (via `System.IdentityModel.Tokens.Jwt`)
- ASP.NET Core Middleware
- Swagger / Swashbuckle

## 🚀 Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- Visual Studio 2022+ or Visual Studio Code

### Setup

```bash
git clone https://github.com/chenmanianu/JwtAuthDemo.git
cd JwtAuthDemo
dotnet run
```

App will be available at:
```
https://localhost:5001
http://localhost:5000
```

## 🔑 Authentication Flow

1. `POST /api/auth/login`
    - Request Body:
    ```json
    {
      "username": "test",
      "password": "test"
    }
    ```
    - Response:
    ```json
    {
      "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9..."
    }
    ```

2. Use this token in **Authorization** header for secure endpoints:
    ```
    Authorization: Bearer <your-token>
    ```

3. Access protected endpoints (e.g., `/users`) after login.

## 📦 Swagger UI

Navigate to `/swagger` in your browser.  
Click "Authorize" button and paste your token to test secured APIs.

## 🔐 JWT Configuration

In `Program.cs`, JWT authentication is added like this:

```csharp
builder.Services.AddAuthentication(...)
                .AddJwtBearer(...);
```
```csharp
app.UseAuthentication();
app.UseAuthorization();
```




This project is open-source and available under the MIT License.

---

Created by **Chenmani Anuradha**
