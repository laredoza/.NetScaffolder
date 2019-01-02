# MySql Migrations 

- Go to correct project 
Open Package Manager
cd  Data\Migrations\EFCore\MySql
- Save Migration (if required)
dotnet ef migrations add --startup-project DotNetScaffolder.Domain.Migrations.EFCore.MySql.csproj --project ..\..\..\Contexts\EFCore\MySql\DotNetScaffolder.Domain.Data.Contexts.EFCore.MySql.csproj --context DotNetScaffolder.Domain.Data.Contexts.EFCore.MySql.Context.MySqlFullContext 'Initial'
- Update Database
dotnet ef database update
