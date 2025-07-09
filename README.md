# Product Manager Application

A full-stack product management application built with .NET 8.0, featuring a Web API backend and a Blazor Server frontend for managing products in an e-commerce or inventory system.

## 🚀 Features

- **Product Management**: Create, view, and manage products with name and pricing
- **Real-time UI**: Interactive Blazor Server components with live updates
- **RESTful API**: Clean API endpoints for product operations
- **Entity Framework Core**: Code-first database approach with SQL Server
- **Swagger Documentation**: Auto-generated API documentation
- **Modern UI**: Bootstrap-styled responsive interface with dark theme
- **Separation of Concerns**: Clean architecture with separate API and client projects

## 🏗️ Architecture

The solution consists of two main projects:

### ProductApi (Backend)
- **Framework**: ASP.NET Core Web API (.NET 8.0)
- **Database**: SQL Server with Entity Framework Core
- **Features**: 
  - RESTful endpoints for product CRUD operations
  - Swagger/OpenAPI documentation
  - Database migrations
  - Dependency injection

### ProductClient (Frontend)
- **Framework**: Blazor Server (.NET 8.0)
- **Features**:
  - Interactive server-side rendering
  - HTTP client services for API communication
  - Responsive Bootstrap UI
  - Real-time product management

## 📋 Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or SQL Server Express
- [Visual Studio 2022](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)
- [Git](https://git-scm.com/)

## 🔧 Installation & Setup

### 1. Clone the Repository
```bash
git clone https://github.com/Mamoonalatif/ProductManager.git
cd ProductManager
```

### 2. Database Configuration

1. Update the connection string in `ProductApi/appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=ProductDb;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

2. Run database migrations:
```bash
cd ProductApi
dotnet ef database update
```

### 3. Run the Application

#### Start the API (Backend)
```bash
cd ProductApi
dotnet run
```
The API will be available at:
- HTTPS: `https://localhost:7229`
- HTTP: `http://localhost:5229`
- Swagger UI: `https://localhost:7229/swagger`

#### Start the Client (Frontend)
```bash
cd ProductClient
dotnet run
```
The web application will be available at:
- HTTPS: `https://localhost:7191`
- HTTP: `http://localhost:5191`

## 📚 API Documentation

### Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/products` | Retrieve all products |
| POST | `/api/products` | Create a new product |

### Product Model
```json
{
  "id": 0,
  "name": "string",
  "price": 0.0
}
```

### Example API Calls

#### Get All Products
```bash
curl -X GET "https://localhost:7229/api/products" -H "accept: application/json"
```

#### Create a Product
```bash
curl -X POST "https://localhost:7229/api/products" \
  -H "accept: application/json" \
  -H "Content-Type: application/json" \
  -d '{
    "name": "Sample Product",
    "price": 29.99
  }'
```

## 🛠️ Technology Stack

### Backend
- **ASP.NET Core 8.0** - Web API framework
- **Entity Framework Core 9.0.5** - ORM for database operations
- **SQL Server** - Database engine
- **Swashbuckle.AspNetCore 6.6.2** - Swagger/OpenAPI documentation

### Frontend
- **Blazor Server** - Interactive web UI framework
- **Bootstrap 5** - CSS framework for responsive design
- **HttpClient** - API communication

## 📁 Project Structure

```
ProductAppSolution/
├── ProductApi/                 # Backend Web API
│   ├── Controllers/
│   │   ├── ProductController.cs
│   │   └── WeatherForecastController.cs
│   ├── Data/
│   │   └── AppDbContext.cs
│   ├── Models/
│   │   └── Product.cs
│   ├── Migrations/
│   ├── Properties/
│   ├── Program.cs
│   └── ProductApi.csproj
├── ProductClient/              # Frontend Blazor App
│   ├── Components/
│   │   ├── Layout/
│   │   ├── Pages/
│   │   ├── Products.razor
│   │   └── App.razor
│   ├── Models/
│   │   └── Product.cs
│   ├── Services/
│   │   └── ProductService.cs
│   ├── wwwroot/
│   ├── Program.cs
│   └── ProductClient.csproj
└── ProductAppSolution.sln      # Solution file
```

## 🚀 Development

### Adding New Features

1. **Backend (API)**:
   - Add new models to `Models/` folder
   - Create controllers in `Controllers/` folder
   - Update `AppDbContext` for new entities
   - Run migrations: `dotnet ef migrations add NewFeature`

2. **Frontend (Client)**:
   - Create new Razor components in `Components/` folder
   - Add services in `Services/` folder for API communication
   - Update routing in `Routes.razor`

### Database Migrations

Create a new migration:
```bash
dotnet ef migrations add MigrationName
```

Update the database:
```bash
dotnet ef database update
```

Remove last migration:
```bash
dotnet ef migrations remove
```

## 🔐 Configuration

### Environment Variables
- `ASPNETCORE_ENVIRONMENT`: Set to `Development` or `Production`
- `ConnectionStrings__DefaultConnection`: Database connection string

### CORS Configuration
The API is configured to allow cross-origin requests. Modify in `Program.cs` if needed.

## 📝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

## 🐛 Troubleshooting

### Common Issues

1. **Database Connection Issues**:
   - Verify SQL Server is running
   - Check connection string in `appsettings.json`
   - Ensure database exists (run migrations)

2. **API Communication Issues**:
   - Verify API is running on correct port
   - Check CORS configuration
   - Ensure both projects are running

3. **Migration Issues**:
   - Delete `Migrations` folder and `bin/obj` folders
   - Run `dotnet ef migrations add InitialCreate`
   - Run `dotnet ef database update`

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👥 Authors

- **Mamoona Latif** - *Initial work* - [Mamoonalatif](https://github.com/Mamoonalatif)

## 🙏 Acknowledgments

- Built with .NET 8.0 and Entity Framework Core
- UI styled with Bootstrap 5
- API documentation with Swagger/OpenAPI
