dotnet new webapi -n TestViaGrok;
cd TestViaGrok;
mkdir Controllers;
mkdir Dtos;
mkdir Models;
mkdir Services;
mkdir DAL;
New-Item Controllers/AuthControllers.cs;
New-Item Dtos/LoginDto.cs;
New-Item Dtos/RegisterDto.cs;
New-Item Models/AppUser.cs;
New-Item Services/JWTServices.cs;
New-Item DAL/TVGDbContext.cs;
dotnet add package Microsoft.EntityFrameworkCore --version 10.0.1;
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.1;
dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.1;
dotnet add package Microsoft.EntityFrameworkCore.Design --version 10.0.1;
dotnet add package Swashbuckle.AspNetCore;
dotnet add package AutoMapper;
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection;
dotnet add package FluentValidation;
dotnet add package FluentValidation.AspNetCore;
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.1;
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer;
dotnet new tool-manifest;
dotnet tool install dotnet-ef --version 10.0.1;
dotnet build;

TestViaGrok/
├─ Controllers/
│    └─ AuthControllers.cs
├─ Dtos/
│    ├─ LoginDto.cs
│    └─ RegisterDto.cs
├─ Models/
│    └─ AppUser.cs
├─ Services/
│    └─ JWTService.cs
└─ Program.cs

dotnet run;
dotnet ef migrations add Init -p ./TestViaGrok.csproj -o ./DAL/Migrations;
dotnet ef database update;
