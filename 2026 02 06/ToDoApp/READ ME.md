##### USED COMMANDS DOTNET SDK V 10.0.1 #####
    dotnet new webapi;
    mkdir Controllers;
    mkdir Validators;
    mkdir Profiles;
    mkdir DAL;
    mkdir DAL/Configurations;
    mkdir Entities;
    mkdir Entities/DTOs;
    mkdir Entities/DTOs/User;
    mkdir Entities/DTOs/Task;
    mkdir Entities/DTOs/Category;
    New-Item Entities/Person.cs;
    New-Item Entities/User.cs;
    New-Item Entities/Task.cs;
    New-Item Entities/Category.cs;
    New-Item Entities/DTOs/User/CreateUserDto.cs;
    New-Item Entities/DTOs/User/GetAllUsers.cs;
    New-Item Entities/DTOs/Task/CreateTaskDto.cs;
    New-Item Entities/DTOs/Task/GetAllTasks.cs;
    New-Item Entities/DTOs/Category/CreateCategoryDto.cs;
    New-Item Entities/DTOs/Category/GetAllCategories.cs;
    New-Item Controllers/UsersControllers.cs;
    New-Item Controllers/TasksControllers.cs;
    New-Item Controllers/CategoriesControllers.cs;
    New-Item DAL/ToDoAppDBContext.cs;
    New-Item DAL/Configurations/UserConfig.cs;
    New-Item DAL/Configurations/TaskConfig.cs;
    New-Item DAL/Configurations/CategoryConfig.cs;
    New-Item Validators/Model.cs;
    New-Item Profiles/ModelProfile.cs;
    dotnet add package Microsoft.EntityFrameworkCore --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 10.0.1;
    dotnet add package Swashbuckle.AspNetCore;
    dotnet add package AutoMapper;
    dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection;
    dotnet add package FluentValidation.AspNetCore;
    dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.1;
    dotnet new tool-manifest;
    dotnet tool install dotnet-ef --version 10.0.1;
    dotnet build;


##### MSSQL CONNECTION STRING #####
    Server=localhost;Database=ToDoAppDB;Trusted_Connection=True;TrustServerCertificate=True;


##### PROGRAM FILE STRUCTURE #####
    ToDoApp/
        ├
        ─
        └
        │


##### APP USAGE AND MIGRATIONS #####
    dotnet run;
    dotnet ef migrations add Init -p ./ToDoApp.csproj -o DAL/Migrations;
    dotnet ef migrations add NAME;
    dotnet ef database update;
    dotnet new apicontroller -n Controllers/MyController;
    dotnet new class -n Entities/MyClass;
