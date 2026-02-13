##### **FILE STRUCTURE** #####
    StoreAppSolution/
        |_ Business/
        |    |_ Services/
        |    |_ Validators/
        |_ Core/
        |    |_ DAL/
        |    |    |_ Repositories/
        |    |         |_ Abstract/
        |    |         |_ Concrete/
        |    |              |_ Dapper/
        |    |              |_ EntityFrameworkCore/
        |    |_ Entities/
        |    |_ Utilities/
        |    |    |_ Exceptions/
        |    |    |_ Result/
        |    |    |    |_ Abstract/
        |    |    |    |_ Concrete/
        |    |_ ConfigurationServices.cs
        |_ DAL/
        |    |_ EFCore/
        |    |_ Repositories/
        |    |_ Migrations/
        |    |_ ConfigurationServices.cs
        |_ Entities/
        |    |_ Common/
        |    |_ Concrete/
        |    |_ DTOs/
        |    |_ Enums/
        |_ WebAPI/
        |    |_ Controllers/
        |    |_ Program.cs
        |_ StoreAppSolution.sln


##### **DOTNET SDK C# & VSCODE SETUP** #####
    mkdir StoreAppSolution;
    cd StoreAppSolution;
    dotnet new sln -n StoreAppSolution --format sln;
    dotnet new classlib -n Business;
    dotnet new classlib -n Core;
    dotnet new classlib -n DAL;
    dotnet new classlib -n Entities;
    dotnet new webapi -n WebAPI --framework net10.0;
    dotnet sln ./ add ./Business/Business.csproj;
    dotnet sln ./ add ./Core/Core.csproj;
    dotnet sln ./ add ./DAL/DAL.csproj;
    dotnet sln ./ add ./Entities/Entities.csproj;
    dotnet sln ./ add ./WebAPI/WebAPI.csproj;
    dotnet add ./Business/Business.csproj package AutoMapper --version 12.0.1;
    dotnet add ./Business/Business.csproj package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1;
    dotnet add ./Business/Business.csproj package FluentValidation;
    dotnet add ./Business/Business.csproj package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.3;
    dotnet add ./DAL/DAL.csproj package Microsoft.EntityFrameworkCore --version 10.0.3;
    dotnet add ./DAL/DAL.csproj package Microsoft.EntityFrameworkCore.SqlServer --version 10.0.3;
    dotnet add ./DAL/DAL.csproj package Microsoft.EntityFrameworkCore.Tools --version 10.0.3;
    dotnet add ./DAL/DAL.csproj package Microsoft.AspNetCore.Identity.EntityFrameworkCore --version 10.0.3;
    dotnet add ./WebAPI/WebAPI.csproj package Swashbuckle.AspNetCore;
    dotnet add ./WebAPI/WebAPI.csproj package FluentValidation.AspNetCore;
    dotnet add ./WebAPI/WebAPI.csproj package Microsoft.AspNetCore.Authentication.JwtBearer --version 10.0.3;
    dotnet add ./WebAPI/WebAPI.csproj package Microsoft.EntityFrameworkCore.Design --version 10.0.3;
    dotnet new tool-manifest;
    dotnet tool install dotnet-ef --version 10.0.3;
    dotnet add ./Business/Business.csproj reference ./Core/Core.csproj;
    dotnet add ./Business/Business.csproj reference ./Entities/Entities.csproj;
    dotnet add ./Business/Business.csproj reference ./DAL/DAL.csproj;
    dotnet add ./DAL/DAL.csproj reference ./Core/Core.csproj;
    dotnet add ./DAL/DAL.csproj reference ./Entities/Entities.csproj;
    dotnet add ./Entities/Entities.csproj reference ./Core/Core.csproj;
    dotnet add ./WebAPI/WebAPI.csproj reference ./Business/Business.csproj;
    dotnet add ./WebAPI/WebAPI.csproj reference ./Entities/Entities.csproj;
    New-Item READ_ME.md;
    Remove-Item ./Business/Class1.cs;
    Remove-Item ./Core/Class1.cs;
    Remove-Item ./DAL/Class1.cs;
    Remove-Item ./Entities/Class1.cs;
    dotnet build ./StoreAppSolution.sln;
    mkdir ./Business/Services/Abstract;
    mkdir ./Business/Services/Concrete/Dapper;
    mkdir ./Business/Services/Concrete/EntityFrameworkCore;
    cd ./Business/Services/Abstract;
    dotnet new interface -n IProductService;
    cd ../Concrete/Dapper;
    New-Item empty;
    cd ../EntityFrameworkCore;
    dotnet new class -n ProductService;
    cd ../../../..;
    mkdir ./WebAPI/Controllers;
    cd ./WebAPI/Controllers;
    dotnet new apicontroller -n ProductsController;
    cd ../..;


##### **APP USAGE COMMANDS** #####
    cd WebAPI; dotnet run;
    # cd DAL; dotnet ef migrations add Init -s ../WebAPI/WebAPI.csproj; dotnet ef database update; cd ..;
