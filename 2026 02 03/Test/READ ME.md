##### **FILE STRUCTURE** #####
    Test/
    ├─ DataAccessLayer/
    │    ├─ DataAccessLayer.csproj
    │    └─ EFDbContext.cs
    ├─ Entities/
    │    ├─ Models/
    │    │    ├─ Product.cs
    │    │    └─ User.cs
    │    └─ Entities.csproj
    ├─ Config/
    │    └─ dotnet-tools.json
    ├─ WebAPI/
    │    ├─ appsettings.json
    │    ├─ Program.cs
    │    └─ WebAPI.csproj
    └─ Test.sln


##### **INSTALLATION COMMANDS** #####
    OPEN INTEGRATED TERMINAL FROM ROOT FOLDER (Test):
        dotnet new sln --format sln -n Test;
        dotnet new classlib -n DataAccessLayer;
        dotnet new classlib -n Entities;
        dotnet new webapi -n WebAPI;
        dotnet sln add DataAccessLayer/DataAccessLayer.csproj Entities/Entities.csproj WebAPI/WebAPI.csproj;
        dotnet add WebAPI/WebAPI.csproj reference DataAccessLayer/DataAccessLayer.csproj Entities/Entities.csproj;
        dotnet add DataAccessLayer/DataAccessLayer.csproj reference Entities/Entities.csproj;
        mkdir Entities/Models;
        New-Item Entities/Models/User.cs;
        New-Item Entities/Models/Product.cs;
        dotnet new tool-manifest;
        dotnet tool install dotnet-ef --version 10.0.1;
        dotnet add DataAccessLayer/DataAccessLayer.csproj package Microsoft.EntityFrameworkCore --version 10.0.1;
        dotnet add DataAccessLayer/DataAccessLayer.csproj package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.1;
        dotnet add DataAccessLayer/DataAccessLayer.csproj package Microsoft.EntityFrameworkCore.Tools --version 10.0.1;
        dotnet add DataAccessLayer/DataAccessLayer.csproj package Microsoft.EntityFrameworkCore.Design --version 10.0.1;
        Remove-Item Entities/Class1.cs;
        dotnet add WebAPI/WebAPI.csproj package Microsoft.EntityFrameworkCore --version 10.0.1;
        dotnet add WebAPI/WebAPI.csproj package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.1;
        dotnet add WebAPI/WebAPI.csproj package Swashbuckle.AspNetCore --version 10.0.1;
        dotnet add WebAPI/WebAPI.csproj package Microsoft.OpenApi --version 10.0.1;
        Rename-Item DataAccessLayer/Class1.cs EFDbContext.cs;
        dotnet tool restore;
        dotnet build Test.sln;
        dotnet run --project WebAPI/WebAPI.csproj;


##### **USAGE COMMANDS** #####
    OPEN INTEGRATED TERMINAL FROM ROOT FOLDER (Test):
        cd WebAPI; dotnet run;
        cd ../DataAccessLayer; dotnet ef migrations add Init; dotnet ef database update;
