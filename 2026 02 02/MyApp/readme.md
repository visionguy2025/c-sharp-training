##### INSTALLATION INSTRUCTIONS #####
    open integrated terminal from root folder
    create new solution file • dotnet new sln -n MyApp
    create new asp api project • dotnet new webapi -n MyAPIProject
    create models library • dotnet new classlib -n Entities
    create data access layer • dotnet new classlib -n DAL
    add projects to the solution • dotnet sln add DAL/DAL.csproj Entities/Entities.csproj MyAPIProject/MyAPIProject.csproj
    add Entities reference to DAL • dotnet add DAL/DAL.csproj reference Entities/Entities.csproj
    add Entities, DAL reference to MyAPIProject • dotnet add MyAPIProject/MyAPIProject.csproj reference Entities/Entities.csproj DAL/DAL.csproj
    dotnet --version
    install package 1 • dotnet add DAL/DAL.csproj package Microsoft.EntityFrameworkCore --version DOTNETVERSIONHERE
    install package 2 • dotnet add DAL/DAL.csproj package Microsoft.EntityFrameworkCore.SqlServer --version DOTNETVERSIONHERE
    install package 3 • dotnet add DAL/DAL.csproj package Microsoft.EntityFrameworkCore.Tools --version DOTNETVERSIONHERE
    install package 4 • dotnet add DAL/DAL.csproj package Microsoft.EntityFrameworkCore.Design --version DOTNETVERSIONHERE
    install package 5 • dotnet tool install dotnet-ef --version DOTNETVERSIONHERE
    verify setup • dotnet build
    make some file changes • mkdir Entities/Models; Remove-Item Entities/Class1.cs; New-Item Entities/Models/Person.cs; Rename-Item DAL/Class1.cs DAL/EFDbContext.cs;


##### FILE STRUCTURE #####
    ROOT/
    ├─ DAL/
    │    ├─ Migrations/
    │    │    └─ .
    │    ├─ EFDbContext.cs
    │    └─ DAL.csproj
    ├─ Entities/
    │    ├─ Models/
    │    │    ├─ User.cs
    │    │    └─ Person.cs
    │    └─ Entities.csproj
    ├─ MyAPIProject/
    │    ├─ Controllers/
    │    │    └─ .
    │    ├─ DTOs/
    │    │    ├─ User/
    │    │    │    ├─ UserCreateDto.cs
    │    │    │    ├─ UserReadDto.cs
    │    │    │    ├─ UserUpdateDto.cs
    │    │    │    └─ UserDeleteDto.cs
    │    │    └─ Auth/
    │    │         ├─ LoginDto.cs
    │    │         └─ RegisterDto.cs
    │    ├─ Program.cs
    │    └─ MyAPIProject.csproj
    └─ MyApp.sln
