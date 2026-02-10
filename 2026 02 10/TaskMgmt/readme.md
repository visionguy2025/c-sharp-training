##### **■■■■■ SETUP COMMANDS ■■■■■** #####
    dotnet new webapi;
    mkdir Controllers; cd Controllers; dotnet new apicontroller -n TasksCtrl; cd ..;
    mkdir DAL; cd DAL; dotnet new class -n TMdbContext; cd ..;
    mkdir Entities; cd Entities; dotnet new class -n Task;
    mkdir DTOs; cd DTOs; dotnet new class -n GetAllTasksDto; dotnet new class -n CreateTaskDto; dotnet new class -n UpdateTaskDto; cd ../..;
    dotnet add package Microsoft.EntityFrameworkCore --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 10.0.1;
    dotnet add package AutoMapper;
    dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection;
    dotnet add package Swashbuckle.AspNetCore;
    dotnet add package FluentValidation;
    dotnet add package FluentValidation.AspNetCore;
    dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.1;
    dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer --version 10.0.1;
    dotnet new tool-manifest;
    dotnet tool install dotnet-ef --version 10.0.1;
    dotnet build;


##### **■■■■■ FILE STRUCTURE ■■■■■** #####
    TaskMgmt/
        ├─ Controllers/
        │    ├─ Auth/
        │    │    └─ AuthCtrl.cs
        │    ├─ TasksCtrl.cs
        │    └─ CategoryCtrl.cs
        ├─ DAL/
        │    ├─ Configurations/
        │    │    ├─ Auth/
        │    │    │    ├─ AppUserConfig.cs
        │    │    │    └─ RefreshTokenConfig.cs
        │    │    ├─ TaskConfig.cs
        │    │    └─ CategoryConfig.cs
        │    ├─ Repositories/
        │    │    ├─ Auth/
        │    │    │    ├─ IAuthRepoInterface.cs
        │    │    │    └─ AuthRepository.cs
        │    │    ├─ Task/
        │    │    │    ├─ ITaskRepoInterface.cs
        │    │    │    └─ TaskRepository.cs
        │    │    └─ Category/
        │    │         ├─ ICategoryRepoInterface.cs
        │    │         └─ CategoryRepository.cs
        │    └─ TMdbContext.cs
        ├─ Profiles/
        │    ├─ AuthMapper.cs
        │    ├─ TaskMapper.cs
        │    └─ CategoryMapper.cs
        ├─ Entities/
        │    ├─ Auth/
        │    │    ├─ AppUser.cs
        │    │    ├─ TokenOptions.cs
        │    │    └─ RefreshToken.cs
        │    ├─ DTOs/
        │    │    ├─ Auth/
        │    │    │    ├─ LoginDto
        │    │    │    ├─ RegisterDto
        │    │    │    └─ AuthResponseDto
        │    │    ├─ Task/
        │    │    │    ├─ GetAllDtoTasks.cs
        │    │    │    ├─ CreateNewDtoTask.cs
        │    │    └─ Category/
        │    │         ├─ GetAllDtoCategories.cs
        │    │         └─ CreateNewDtoCategory.cs
        │    ├─ Base.cs
        │    ├─ Task.cs
        │    └─ Category.cs
        ├─ Validations/
        │    ├─ Auth/
        │    │    ├─ LoginDtoValidator.cs
        │    │    └─ RegisterDtoValidator.cs
        │    ├─ Task/
        │    │    ├─ CreateTaskDtoValidator.cs
        │    │    └─ UpdateTaskDtoValidator.cs
        │    └─ Category/
        │         ├─ CreateCategoryDtoValidator.cs
        │         └─ UpdateCategoryDtoValidator.cs
        ├─ Security/
        │    ├─ JwtTokenService.cs
        │    └─ PasswordHasher.cs
        ├─ Services/
        │    ├─ Auth/
        │    │    ├─ IAuthService.cs
        │    │    └─ AuthService.cs
        │    ├─ Task/
        │    │    ├─ ITaskService.cs
        │    │    └─ TaskService.cs
        │    └─ Category/
        │         ├─ ICategoryService.cs
        │         └─ CategoryService.cs
        ├─ Middleware/
        │    └─ ExceptionMiddleware.cs
        ├─ Extensions/
        │    ├─ ServiceExtensions.cs
        │    ├─ AuthExtensions.cs
        │    └─ SwaggerExtensions.cs
        ├─ appsettings.json
        ├─ Program.cs
        └─ TaskMgmt.csproj


##### **■■■■■ APP USAGE ■■■■■** #####
    dotnet run;
    dotnet ef migrations add Init -p ./TaskMgmt.csproj -o DAL/Migrations;
    dotnet ef database update;
