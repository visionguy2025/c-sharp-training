##### **FILE STRUCTURE** #####
    Ecommerce/
    ├─ Controllers/
    │    ├─ CategoryController.cs
    │    └─ ProductController.cs
    ├─ Entities/
    │    ├─ Category.cs
    │    └─ Product.cs
    ├─ DAL/
    │    ├─ Configurations/
    │    │    ├─ CategoryConfig.cs
    │    │    └─ ProductConfig.cs
    │    ├─ Migrations/
    │    │    └─ ...
    │    └─ EcomDbContext.cs
    ├─ appsettings.json
    ├─ Ecommerce.csproj
    └─ Program.cs


##### **INITIAL SETUP COMMANDS** #####
    <!-- winget install --id Microsoft.DotNet.SDK.10 -e --version 10.0.1; -->
    <!-- open integrated terminal from root folder -->
    dotnet new webapi;
    mkdir Entities;
    New-Item Entities/Category.cs;
    New-Item Entities/Product.cs;
    mkdir Controllers;
    New-Item Controllers/CategoryController.cs;
    New-Item Controllers/ProductController.cs;
    mkdir DAL;
    New-Item DAL/EcomDbContext.cs;
    mkdir DAL/Configurations;
    New-Item DAL/Configurations/CategoryConfig.cs;
    New-Item DAL/Configurations/ProductConfig.cs;
    dotnet add package Microsoft.EntityFrameworkCore --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 10.0.1;
    dotnet new tool-manifest;
    dotnet tool install dotnet-ef --version 10.0.1;
    dotnet clean;
    dotnet build;
    dotnet run;
    <!-- dotnet add package Microsoft.OpenApi; // already exist from "dotnet new webapi" with >NET9 -->
    <!-- dotnet add package Swashbuckle.AspNetCore; // already exist from "dotnet new webapi" with >NET9 -->


#### **APPLICATION COMMANDS** #####
    dotnet run;
    dotnet ef migrations add InitalCreate -p ./Ecommerce.csproj -o ./DAL/Migrations;
    dotnet ef database update;
