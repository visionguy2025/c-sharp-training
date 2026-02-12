##### **SETUP** #####
    dotnet new sln --format sln -n EcomApp;
    dotnet new webapi --framework net10.0 -n EcommerceAPI;
    dotnet new classlib -n Core;
    dotnet new classlib -n Entities;
    dotnet new classlib -n DataAccessLayer;
    dotnet new classlib -n Business;
    dotnet sln add EcommerceAPI/EcommerceAPI.csproj Core/Core.csproj Entities/Entities.csproj DataAccessLayer/DataAccessLayer.csproj Business/Business.csproj;
    dotnet add EcommerceAPI/EcommerceAPI.csproj reference DataAccessLayer/DataAccessLayer.csproj;
    <!-- dotnet add EcommerceAPI/EcommerceAPI.csproj reference ; -->
    <!-- dotnet add EcommerceAPI/EcommerceAPI.csproj reference ; -->
    <!-- dotnet add EcommerceAPI/EcommerceAPI.csproj reference ; -->
    dotnet add package Microsoft.



1️⃣ Project References (N-Tier Structure)
Your layers:
EcommerceAPI → Presentation Layer (Web API)
Business → Business Logic Layer
DataAccessLayer → Data Access Layer
Entities → Domain Models
Core → Shared abstractions (interfaces, base classes, utilities)

🔗 Recommended Dependency Flow (Clean Direction)
EcommerceAPI
    ↓
Business
    ↓
DataAccessLayer
    ↓
Entities

Business → Core
DataAccessLayer → Core



dotnet add EcommerceAPI reference Business
dotnet add Business reference DataAccessLayer
dotnet add Business reference Entities
dotnet add Business reference Core
dotnet add DataAccessLayer reference Entities
dotnet add DataAccessLayer reference Core



dotnet add EcommerceAPI package Swashbuckle.AspNetCore
dotnet add EcommerceAPI package FluentValidation.AspNetCore
dotnet add EcommerceAPI package Microsoft.AspNetCore.Authentication.JwtBearer --version 10.0.1
dotnet add EcommerceAPI package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.1
efc design ?

dotnet add Business package AutoMapper --version 12.0.1
dotnet add Business package FluentValidation

dotnet add EcommerceAPI package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1

dotnet add DataAccessLayer package Microsoft.EntityFrameworkCore --version 10.0.1
dotnet add DataAccessLayer package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.1
dotnet add DataAccessLayer package Microsoft.EntityFrameworkCore.Tools --version 10.0.1
dotnet add DataAccessLayer package Microsoft.EntityFrameworkCore.Design --version 10.0.1

dotnet add DataAccessLayer package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.1
