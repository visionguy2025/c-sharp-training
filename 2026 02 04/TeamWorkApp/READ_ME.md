##### **FILE STRUCTURE** #####
    TeamWorkApp/
    ├─ Controllers/
    │    ├─ EmployeeCtrl.cs
    │    ├─ EmployeeRoleCtrl.cs
    │    ├─ ManagerCtrl.cs
    │    ├─ TeamCtrl.cs
    │    ├─ TaskCtrl.cs
    │    ├─ TaskStatusCtrl.cs
    │    └─ TaskCategoryCtrl.cs
    ├─ DAL/
    │    ├─ Configurations/
    │    │    ├─ EmployeeConfig.cs
    │    │    ├─ EmployeeRoleConfig.cs
    │    │    ├─ ManagerConfig.cs
    │    │    ├─ TeamConfig.cs
    │    │    ├─ TaskConfig.cs
    │    │    ├─ TaskStatusConfig.cs
    │    │    └─ TaskCategoryConfig.cs
    │    ├─ Migrations/
    │    │    └─ init.cs
    │    └─ TWA_DB_Context.cs
    ├─ Entities/
    │    ├─ DTOs/
    │    │    ├─ Employee/
    │    │    │    ├─ GetAllEmployeesDto.cs
    │    │    │    └─ CreateNewEmployeeDto.cs
    │    │    ├─ EmployeeRole/
    │    │    │    ├─ GetAllEmployeeRolesDto.cs
    │    │    │    └─ CreateNewEmployeeRoleDto.cs
    │    │    ├─ Manager/
    │    │    │    ├─ GetAllManagersDto.cs
    │    │    │    └─ CreateNewManagerDto.cs
    │    │    ├─ Team/
    │    │    │    ├─ GetAllTeamsDto.cs
    │    │    │    └─ CreateNewTeamDto.cs
    │    │    ├─ Task/
    │    │    │    ├─ GetAllTasksDto.cs
    │    │    │    └─ CreateNewTaskDto.cs
    │    │    ├─ TaskStatus/
    │    │    │    ├─ GetAllTaskStatusesDto.cs
    │    │    │    └─ CreateNewTaskStatusDto.cs
    │    │    └─ TaskCategory/
    │    │         ├─ GetAllTaskCategoriesDto.cs
    │    │         └─ CreateNewTaskCategoryDto.cs
    │    ├─ Person.cs
    │    ├─ Employee.cs
    │    ├─ EmployeeRole.cs
    │    ├─ Manager.cs
    │    ├─ Team.cs
    │    ├─ Task.cs
    │    ├─ TaskStatus.cs
    │    └─ TaskCategory.cs
    ├─ TeamWorkApp.csproj
    ├─ appsettings.json
    └─ Program.cs


##### **SETUP COMMANDS** #####
    dotnet new webapi -n TeamWorkApp;
    cd TeamWorkApp;
    mkdir Controllers;
    mkdir DAL;
    mkdir DAL/Configurations;
    mkdir Entities;
    mkdir Entities/DTOs;
    mkdir Entities/DTOs/Employee;
    mkdir Entities/DTOs/EmployeeRole;
    mkdir Entities/DTOs/Manager;
    mkdir Entities/DTOs/Team;
    mkdir Entities/DTOs/Task;
    mkdir Entities/DTOs/TaskStatus;
    mkdir Entities/DTOs/TaskCategory;
    New-Item Controllers/EmployeesCtrl.cs;
    New-Item Controllers/EmployeeRolesCtrl.cs;
    New-Item Controllers/ManagersCtrl.cs;
    New-Item Controllers/TeamsCtrl.cs;
    New-Item Controllers/TasksCtrl.cs;
    New-Item Controllers/TaskStatusesCtrl.cs;
    New-Item Controllers/TaskCategoriesCtrl.cs;
    New-Item DAL/TWA_DB_Context.cs;
    New-Item DAL/Configurations/EmployeeConfig.cs;
    New-Item DAL/Configurations/EmployeeRoleConfig.cs;
    New-Item DAL/Configurations/ManagerConfig.cs;
    New-Item DAL/Configurations/TeamConfig.cs;
    New-Item DAL/Configurations/TaskConfig.cs;
    New-Item DAL/Configurations/TaskStatusConfig.cs;
    New-Item DAL/Configurations/TaskCategoryConfig.cs;
    New-Item Entities/Person.cs;
    New-Item Entities/Employee.cs;
    New-Item Entities/EmployeeRole.cs;
    New-Item Entities/Manager.cs;
    New-Item Entities/Team.cs;
    New-Item Entities/Task.cs;
    New-Item Entities/TaskStatus.cs;
    New-Item Entities/TaskCategory.cs;
    New-Item Entities/DTOs/Employee/GetAllEmployeesDto.cs;
    New-Item Entities/DTOs/Employee/CreateNewEmployeeDto.cs;
    New-Item Entities/DTOs/EmployeeRole/GetAllEmployeeRolesDto.cs;
    New-Item Entities/DTOs/EmployeeRole/CreateNewEmployeeRoleDto.cs;
    New-Item Entities/DTOs/Manager/GetAllManagersDto.cs;
    New-Item Entities/DTOs/Manager/CreateNewManagerDto.cs;
    New-Item Entities/DTOs/Team/GetAllTeamsDto.cs;
    New-Item Entities/DTOs/Team/CreateNewTeamDto.cs;
    New-Item Entities/DTOs/Task/GetAllTasksDto.cs;
    New-Item Entities/DTOs/Task/CreateNewTaskDto.cs;
    New-Item Entities/DTOs/TaskStatus/GetAllTaskStatusesDto.cs;
    New-Item Entities/DTOs/TaskStatus/CreateNewTaskStatusDto.cs;
    New-Item Entities/DTOs/TaskCategory/GetAllTaskCategoriesDto.cs;
    New-Item Entities/DTOs/TaskCategory/CreateNewTaskCategoryDto.cs;
    dotnet add package Microsoft.EntityFrameworkCore --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.1;
    dotnet add package Microsoft.EntityFrameworkCore.Design --version 10.0.1;
    dotnet new tool-manifest;
    dotnet tool install dotnet-ef --version 10.0.1;
    dotnet build;


##### **APP USAGE** #####
    dotnet run;
    dotnet ef migrations add Init -p ./TeamWorkApp.csproj -o ./DAL/Migrations;
    dotnet ef database update;
