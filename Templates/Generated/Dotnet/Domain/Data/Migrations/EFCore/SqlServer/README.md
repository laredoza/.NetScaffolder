# SqlServer Migrations 

- Go to correct project 
Open Package Manager
cd  Data\Migrations\EFCore\SqlServer
- Save Migration (if required)
dotnet ef migrations add --startup-project DotNetScaffolder.Domain.Migrations.EFCore.SqlServer.csproj --project ..\..\..\Contexts\EFCore\SqlServer\DotNetScaffolder.Domain.Data.Contexts.EFCore.SqlServer.csproj --context DotNetScaffolder.Domain.Data.Contexts.EFCore.SqlServer.Context.SqlServerFullContext 'Initial'
- Update Database
dotnet ef database update