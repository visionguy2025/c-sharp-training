■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
##### FILE STRUCTURE #####
■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
ROOT/
│
├─ Models/
│   ├─ User.cs
│   ├─ Product.cs
│   └─ Models.csproj
│
├─ DAL/
│   ├─ AppDbContext.cs
│   ├─ Migrations/
│   └─ DAL.csproj
│
├─ ConsoleApp/
│   ├─ Program.cs
│   ├─ appsettings.json
│   └─ ConsoleApp.csproj
└─ MyProject.sln


■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
##### INSTALLATION LOG #####
■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
01. open integrated terminal for the root folder
02. create project solution file • dotnet new sln -n MyProject
03. create folders Models, DataAccessLayer, ConsoleApp, CustomExceptions folders • mkdir Models; mkdir DAL; mkdir ConsoleApp; mkdir CustomExceptions;
04. create project files at once part 1 • cd Models; dotnet new classlib; cd ../DAL; dotnet new classlib; cd ..; dotnet new console -n ConsoleApp;
05. add projects to the solution • dotnet sln add Models/Models.csproj; dotnet sln add ConsoleApp/ConsoleApp.csproj; dotnet sln add DAL/DAL.csproj;
06. verify • dotnet sln list
07. add Models reference to DAL • dotnet add DAL/DAL.csproj reference Models/Models.csproj
08. add Models & DAL references to ConsoleApp • dotnet add ConsoleApp/ConsoleApp.csproj reference Models/Models.csproj DAL/DAL.csproj
09. sanity check • dotnet build
10. check .net version • dotnet --version
11. go to DAL folder from ROOT • cd DAL
12. replace SAME_V_W_DOTNET with current .net version and install packages part 1 • dotnet add package Microsoft.EntityFrameworkCore --version SAME_V_W_DOTNET
13. replace SAME_V_W_DOTNET with current .net version and install packages part 2 • dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version SAME_V_W_DOTNET
14. replace SAME_V_W_DOTNET with current .net version and install packages part 3 • dotnet add package Microsoft.EntityFrameworkCore.Tools --version SAME_V_W_DOTNET
15. replace SAME_V_W_DOTNET with current .net version and install packages part 4 • dotnet add package Microsoft.EntityFrameworkCore.Design --version SAME_V_W_DOTNET
16. replace SAME_V_W_DOTNET with current .net version and install packages part 5 • dotnet tool install --global dotnet-ef --version SAME_V_W_DOTNET
17. sanity check again • cd ..; dotnet build


■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
##### MIGRATION AND LAUNCH #####
■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
- mssql uri • Server=localhost;Database=DB_NAME_HERE;TrustServerCertificate=True;TrustedConneciton=True;
- launch project • dotnet run
- create migration files • dotnet ef migrations add MIGRATION_NAME -p .\ConoleApp\ConsoleApp.csproj -o .\DAL\Migrations
- update database • dotnet ef database update
