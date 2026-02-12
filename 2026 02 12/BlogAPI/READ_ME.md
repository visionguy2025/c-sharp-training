##### **PROGRAM ARCHITECTURE** #####
    BlogAPI/
        ├─ DataAccessLayer/
        │    ├─ Configurations/
        │    │    ├─ BlogConfigurations.cs
        │    │    └─ CategoryConfigurations.cs
        │    ├─ Migrations/
        │    │    └─ Init.cs
        │    ├─ Repositories/
        │    │    ├─ Abstract/
        │    │    │    ├─ IBlogRepository.cs
        │    │    │    └─ ICategoryRepository.cs
        │    │    └─ Concrete/
        │    │         ├─ Dapper/
        │    │         │    └─ empty
        │    │         └─ EntityFrameworkCore/
        │    │              ├─ EFBlogRepository.cs
        │    │              └─ EFCategoryRepository.cs
        │    └─ BlogDBContext.cs
        ├─ Controllers/
        │    ├─ Auth/
        │    │    └─ AuthController.cs
        │    ├─ BlogsController.cs
        │    └─ CategoriesController.cs
        ├─ Core/
        │    ├─ Abstract/
        │    │    └─ IBaseRepository.cs
        │    ├─ Concrete/
        │    │    ├─ Dapper/
        │    │    │    └─ empty
        │    │    └─ EntityFrameworkCore/
        │    │         └─ EFBaseRepository.cs
        │    └─ Entity/
        │         └─ BaseEntitiy.cs
        ├─ Entities/
        │    ├─ Auth/
        │    │    ├─ AppUser.cs
        │    │    └─ TokenOptions.cs
        │    ├─ DTOs/
        │    │    ├─ Auth/
        │    │    │    ├─ LoginDto.cs
        │    │    │    └─ RegisterDto.cs
        │    │    ├─ Blog/
        │    │    │    ├─ CreateBlogDto.cs
        │    │    │    ├─ GetBlogDto.cs
        │    │    │    └─ UpdateBlogDto.cs
        │    │    └─ Category/
        │    │         ├─ CreateCategoryDto.cs
        │    │         ├─ GetCategoryDto.cs
        │    │         └─ UpdateCategoryDto.cs
        │    ├─ Models/
        │    │    ├─ Blog.cs
        │    │    └─ Category.cs
        │    └─ Validators/
        │         ├─ BlogValidations.cs
        │         └─ CategoryValidations.cs
        ├─ Extensions/
        │         └─ CustomClaimTypes.cs
        ├─ Profiles/
        │    ├─ BlogMapper.cs
        │    └─ CategoryMapper.cs
        ├─ Properties/
        │    └─ launchSettings.json
        ├─ Services/
        │    ├─ Abstract/
        │    │    ├─ IBlogServices.cs
        │    │    └─ ICategoryServices.cs
        │    └─ Concrete/
        │         ├─ Dapper/
        │         │    └─ empty
        │         └─ EntityFrameworkCore/
        │              ├─ EFBlogServices.cs
        │              └─ EFCategoryServices.cs
        ├─ appsettings.json
        ├─ BlogAPI.csproj
        └─ Program.cs


##### **SETUP COMMANDS** #####
    dotnet new webapi --framework net10.0;

    dotnet new class -n BlogConfigurations -o ./DataAccessLayer;
    dotnet new class -n CategoryConfigurations -o ./DataAccessLayer;
    dotnet new interface -n IBlogRepository -o ./DataAccessLayer/Repositories/Abstract;
    dotnet new interface -n ICategoryRepository -o ./DataAccessLayer/Repositories/Abstract;
    dotnet new class -n EFBlogRepository -o ./DataAccessLayer/Repositories/Concrete/EntityFrameworkCore;
    dotnet new class -n EFCategoryRepository -o ./DataAccessLayer/Repositories/Concrete/EntityFrameworkCore;
    dotnet new class -n BlogDBContext -o ./DataAccessLayer;

    dotnet new apicontroller -n AuthController -o ./;
    dotnet new apicontroller -n BlogsController -o ./;
    dotnet new apicontroller -n CategoriesController -o ./;
    dotnet new interface -n IBaseRepository -o ./;
    dotnet new class -n EFBaseRepository -o ./;
    dotnet new class -n BaseEntitiy -o ./;
    dotnet new class -n AppUser -o ./;
    dotnet new class -n TokenOptions -o ./;
    dotnet new class -n LoginDto -o ./;
    dotnet new class -n RegisterDto -o ./;
    dotnet new class -n CreateBlogDto -o ./;
    dotnet new class -n GetBlogDto -o ./;
    dotnet new class -n UpdateBlogDto -o ./;
    dotnet new class -n CreateCategoryDto -o ./;
    dotnet new class -n GetCategoryDto -o ./;
    dotnet new class -n UpdateCategoryDto -o ./;
    dotnet new class -n Blog -o ./;
    dotnet new class -n Category -o ./;
    dotnet new class -n BlogValidations -o ./;
    dotnet new class -n CategoryValidations -o ./;
    dotnet new class -n CustomClaimTypes -o ./;
    dotnet new class -n BlogMapper -o ./;
    dotnet new class -n CategoryMapper -o ./;
    dotnet new interface -n IBlogServices -o ./;
    dotnet new interface -n ICategoryServices -o ./;
    dotnet new class -n EFBlogServices -o ./;
    dotnet new class -n EFCategoryServices -o ./;

    dotnet add package AutoMapper --version 12.0.1;
    dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1;
    dotnet add package FluentValidation;
    dotnet add package FluentValidation.AspNetCore;
    dotnet add package Microsoft.EntityFrameworkCore --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 10.0.1;
    dotnet add package Swashbuckle.AspNetCore;
    dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.1;
    dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 10.0.1;
    dotnet new tool-manifest;
    dotnet tool install dotnet-ef --version 10.0.1;
    dotnet build;


##### **APP USAGE** #####
    dotnet run;
    dotnet ef migrations add Init -p ./ -o ./DataAccessLayer/Migrations;
    dotnet ef database update;
