##### ■ SETUP ■ #####
    cd ROOT
    dotnet new sln
    cd ROOT/Executable
    dotnet new console // OR dotnet new console -o Executable // INSIDE ROOT FOLDER
    cd ROOT/Models
    dotnet new classlib

    cd ROOT
    dotnet add Executable/Executable.csproj reference Models/Models.csproj
    dotnet sln add Models/Models.csproj Executable/Executable.csproj
    <!-- dotnet add Models package Microsoft.EntityFrameworkCore -->

    cd ROOT/Executable
    dotnet add package Microsoft.EntityFrameworkCore --version 10.0.2
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.2
    dotnet add package Microsoft.EntityFrameworkCore.Tools --version 10.0.2
    dotnet new tool-manifest
    dotnet tool install dotnet-ef --version 10.0.2
    cls
    dotnet run

    dotnet ef migrations add InitialCreate (VS DB Console: add-migration init)
    dotnet ef database update (VS DB Console: update-database)

    dotnet tool restore
    dotnet ef migrations add Init

    cd ROOT/Models
    dotnet add package Microsoft.EntityFrameworkCore

##### ■ CONNECTION ■ #####
    Server=(localdb)\MSSQLLocalDB;Database=DevDB;Trusted_Connection=True;
