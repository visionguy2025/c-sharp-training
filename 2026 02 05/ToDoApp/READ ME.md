##### **FILE STRUCTURE** #####
    ToDoApp/
    ├─ Controllers/
    │    ├─ TasksCtrl.cs
    │    ├─ TaskCategoriesCtrl.cs
    │    └─ UsersCtrl.cs
    ├─ DataAccessLayer/
    │    ├─ Configurations/
    │    │    ├─ TaskConfig.cs
    │    │    ├─ TaskCategoryConfig.cs
    │    │    └─ UserConfig.cs
    │    ├─ Migrations/
    │    │    └─ Init.cs
    │    └─ ToDoAppDbContext.cs
    ├─ Entities/
    │    ├─ DTOs/
    │    │    ├─ Task/
    │    │    │    ├─ GetAllTasksDto.cs
    │    │    │    ├─ GetTaskByIdDto.cs
    │    │    │    ├─ CreateNewTaskDto.cs
    │    │    │    ├─ UpdateSelectedTaskDto.cs
    │    │    │    └─ DeleteTaskByIdDto.cs
    │    │    ├─ TaskCategory/
    │    │    │    ├─ GetAllTaskCategoriesDto.cs
    │    │    │    ├─ GetTaskCategoryByIdDto.cs
    │    │    │    ├─ CreateNewTaskCategoryDto.cs
    │    │    │    ├─ UpdateSelectedTaskCategoryDto.cs
    │    │    │    └─ DeleteTaskCategoryByIdDto.cs
    │    │    └─ User/
    │    │         ├─ GetAllUsersDto.cs
    │    │         ├─ GetUserByIdDto.cs
    │    │         ├─ CreateNewUserDto.cs
    │    │         ├─ UpdateSelectedUserDto.cs
    │    │         └─ DeleteUserByIdDto.cs
    │    ├─ Validators/
    │    │         └─ Untitled.cs
    │    ├─ Person.cs
    │    ├─ Task.cs
    │    ├─ TaskCategory.cs
    │    └─ User.cs
    ├─ Profiles/
    │    ├─ TaskMapper.cs
    │    ├─ TaskCategoryMapper.cs
    │    └─ UserMapper.cs
    ├─ appsettings.json
    ├─ Program.cs
    └─ ToDoApp.csproj


##### **SETUP COMMANDS** #####
    dotnet new webapi -n ToDoApp -f net9.0;
    mkdir Controllers;
    mkdir DataAccessLayer;
    mkdir DataAccessLayer/Configurations;
    mkdir Entities;
    mkdir Entities/DTOs;
    mkdir Entities/DTOs/Task;
    mkdir Entities/DTOs/TaskCategory;
    mkdir Entities/DTOs/User;
    mkdir Entities/Validators;
    mkdir Profiles;
    New-Item Controllers/TasksCtrl.cs;
    New-Item Controllers/TaskCategoriesCtrl.cs;
    New-Item Controllers/UsersCtrl.cs;
    New-Item DataAccessLayer/ToDoAppDbContext.cs;
    New-Item DataAccessLayer/Configurations/TaskConfig.cs;
    New-Item DataAccessLayer/Configurations/TaskCategoryConfig.cs;
    New-Item DataAccessLayer/Configurations/UserConfig.cs;
    New-Item Entities/Person.cs;
    New-Item Entities/Task.cs;
    New-Item Entities/TaskCategory.cs;
    New-Item Entities/User.cs;
    New-Item Entities/DTOs/Task/CreateNewTaskDto.cs;
    New-Item Entities/DTOs/TaskCategory/CreateNewTaskCategoryDto.cs;
    New-Item Entities/DTOs/User/CreateNewUserDto.cs;
    New-Item Entities/Validators/Untitled.cs;
    New-Item Profiles/TaskMapper.cs;
    New-Item Profiles/TaskCategoryMapper.cs;
    New-Item Profiles/UserMapper.cs;
    dotnet add package Microsoft.EntityFrameworkCore --version 9.0.3;
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 9.0.3;
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 9.0.3;
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.3;
    dotnet add package Swashbuckle.AspNetCore;
    dotnet add package FluentValidation;
    dotnet add package FluentValidation.AspNetCore;
    dotnet add package AutoMapper;
    dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection;
    dotnet new tool-manifest;
    dotnet tool install dotnet-ef --version 9.0.3;
    dotnet build;


##### **APP USAGE** #####
    dotnet run;
    dotnet ef migrations add Init -p ./ToDoApp.csproj -o ./DataAccessLayer/Migrations;
    dotnet ef database update;
